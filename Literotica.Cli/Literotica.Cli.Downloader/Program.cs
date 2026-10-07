using System.CommandLine;
using System.CommandLine.Parsing;
using LiteroticaApi.Api;
using LiteroticaApi.DataObjects;
using EpubManager.ContentSources;
using EpubManager.Util;

namespace Literotica.Cli.Downloader
{
	public class Program
	{
		private static bool EventHandled { get; set; }

		private static readonly EpubManager.Writers.Literotica StoryWriter = new ();

		public static async Task<int> Main(string[] args)
		{
			Argument<string> sourceArgument = new("source")
			{
				Description = "A single URL or a path to a file containing URLs separated by newline.",
				CustomParser = result =>
				{
					string resultData = result.Tokens.Single().Value;
					if (Uri.TryCreate(resultData, UriKind.Absolute, out Uri? uriValue))
					{
						return uriValue.ToString();
					}

					if (File.Exists(resultData))
					{
						return resultData;
					}

					result.AddError("Url is invalid or the designated file does not exist");
					return null;
				}
			};

			Option<string> coverPathOption = new ("--cover", "-c" )
			{
				Description = "Path to a custom cover image to use for EPUB output. (Does not support bulk downloading)",
				CustomParser = result =>
				{
					string resultData = result.Tokens.Single().Value;
					if (Uri.TryCreate(resultData, UriKind.Absolute, out Uri? uriValue))
					{
						return uriValue.ToString();
					}

					if (File.Exists(resultData))
					{
						return resultData;
					}

					result.AddError("Url is invalid or the designated file does not exist");
					return null;
				},
				DefaultValueFactory = _ => string.Empty
			};

			Option<bool> logOption = new("--log", "-l")
			{
				Description = "Enable logging output to the console.",
				DefaultValueFactory = _ => true
			};
			Option<string> formatOption = new("--format", "-f")
			{
				Description = "Output format: epub | epub-raw | txt | singlefile (default: singlefile)",
				DefaultValueFactory = _ => "singlefile",

			};
			formatOption.AcceptOnlyFromAmong("singlefile", "txt", "epub", "epub-raw");

			Option<string> outputOption = new("--output", "-o")
			{
				Description = "Output directory for downloaded stories (default: current directory)",
				DefaultValueFactory = _ => Directory.GetCurrentDirectory()
			};

			Option<int> startAtOption = new("--index", "--startat", "--start", "--chapter", "--page")
			{
				Description = "Starting chapter or page index to start downloading from (default: 0)",
				DefaultValueFactory = _ => 0
			};

			Option<int> endAtOption = new("--end-index", "--endat", "--end", "--last-chapter", "--last-page")
			{
				Description = "Chapter to end or finish on, (default: int.Max)",
				DefaultValueFactory = _ => int.MaxValue
			};

			// EPUB appearance and metadata (ignored for txt / singlefile output). Defaults match the stock look.
			EpubStyle defaults = EpubStyle.Default;

			Option<string> languageOption = new("--language")
			{
				Description = "Book language: a code such as en or pt-BR, or a name such as French. (default: writer default, English)",
				DefaultValueFactory = _ => string.Empty
			};
			Option<string> descriptionOption = new("--description")
			{
				Description = "Synopsis shown on the title page. Use \\n\\n for a new paragraph, or --description-file.",
				DefaultValueFactory = _ => string.Empty
			};
			Option<string> descriptionFileOption = new("--description-file")
			{
				Description = "Path to a text file containing the synopsis (blank lines separate paragraphs).",
				DefaultValueFactory = _ => string.Empty
			};
			descriptionFileOption.Validators.Add(result =>
			{
				string value = result.GetValueOrDefault<string>() ?? string.Empty;
				if (value.Length > 0 && !File.Exists(value)) result.AddError($"Description file does not exist: {value}");
			});

			Option<string> fontOption = new("--font")
			{
				Description = "Body font: Serif | SansSerif | Monospace (default: Serif)",
				DefaultValueFactory = _ => defaults.Font.ToString()
			};
			fontOption.AcceptOnlyFromAmong(Enum.GetNames(typeof(EpubFont)));

			Option<int> fontSizeOption = new("--font-size")
			{
				Description = "Base text size in percent, 50-300 (default: 100)",
				DefaultValueFactory = _ => defaults.FontSizePercent
			};
			fontSizeOption.Validators.Add(result =>
			{
				int value = result.GetValueOrDefault<int>();
				if (value < 50 || value > 300) result.AddError("--font-size must be between 50 and 300.");
			});

			Option<double> lineHeightOption = new("--line-height")
			{
				Description = "Line height multiplier, 1.0-3.0 (default: 1.2)",
				DefaultValueFactory = _ => defaults.LineHeight
			};
			lineHeightOption.Validators.Add(result =>
			{
				double value = result.GetValueOrDefault<double>();
				if (double.IsNaN(value) || value < 1.0 || value > 3.0) result.AddError("--line-height must be between 1.0 and 3.0.");
			});

			Option<string> alignOption = new("--align")
			{
				Description = "Paragraph alignment: Left | Justify (default: Left)",
				DefaultValueFactory = _ => defaults.TextAlign.ToString()
			};
			alignOption.AcceptOnlyFromAmong(Enum.GetNames(typeof(EpubTextAlign)));

			Option<string> paragraphsOption = new("--paragraphs")
			{
				Description = "Paragraph separation: Spaced | Indented (default: Spaced)",
				DefaultValueFactory = _ => defaults.ParagraphStyle.ToString()
			};
			paragraphsOption.AcceptOnlyFromAmong(Enum.GetNames(typeof(EpubParagraphStyle)));

			Option<string> headingAlignOption = new("--heading-align")
			{
				Description = "Chapter heading alignment: Left | Center (default: Left)",
				DefaultValueFactory = _ => defaults.ChapterHeadingAlign.ToString()
			};
			headingAlignOption.AcceptOnlyFromAmong(Enum.GetNames(typeof(EpubHeadingAlign)));

			Option<string> sceneBreakOption = new("--scene-break")
			{
				Description = "Text shown at scene breaks; an empty value draws a thin line (default: \"* * *\")",
				DefaultValueFactory = _ => defaults.SceneBreak
			};

			RootCommand rootCommand = new("Story Downloader CLI")
			{
				sourceArgument,
				logOption,
				formatOption,
				outputOption,
				startAtOption,
				endAtOption,
				coverPathOption,
				languageOption,
				descriptionOption,
				descriptionFileOption,
				fontOption,
				fontSizeOption,
				lineHeightOption,
				alignOption,
				paragraphsOption,
				headingAlignOption,
				sceneBreakOption
			};


			rootCommand.SetAction(async parseResult =>
			{
				string source = parseResult.GetRequiredValue(sourceArgument);
				string format = parseResult.GetRequiredValue(formatOption);
				string outputDir = parseResult.GetRequiredValue(outputOption);
				string coverPath = parseResult.GetRequiredValue(coverPathOption);
				bool logEnabled = parseResult.GetRequiredValue(logOption);
				int startAt = parseResult.GetRequiredValue(startAtOption);
				int endAt = parseResult.GetRequiredValue(endAtOption);

				string description = parseResult.GetRequiredValue(descriptionOption).Replace("\\n", "\n");
				string descriptionFile = parseResult.GetRequiredValue(descriptionFileOption);
				if (descriptionFile.Length > 0) description = await File.ReadAllTextAsync(descriptionFile);

				EpubOptions epubOptions = new()
				{
					Language = parseResult.GetRequiredValue(languageOption),
					Description = description,
					Style = new EpubStyle
					{
						Font = Enum.Parse<EpubFont>(parseResult.GetRequiredValue(fontOption), true),
						FontSizePercent = parseResult.GetRequiredValue(fontSizeOption),
						LineHeight = parseResult.GetRequiredValue(lineHeightOption),
						TextAlign = Enum.Parse<EpubTextAlign>(parseResult.GetRequiredValue(alignOption), true),
						ParagraphStyle = Enum.Parse<EpubParagraphStyle>(parseResult.GetRequiredValue(paragraphsOption), true),
						ChapterHeadingAlign = Enum.Parse<EpubHeadingAlign>(parseResult.GetRequiredValue(headingAlignOption), true),
						SceneBreak = parseResult.GetRequiredValue(sceneBreakOption)
					}
				};

				if (!format.Contains("epub", StringComparison.OrdinalIgnoreCase) && (epubOptions.Description.Length > 0 || epubOptions.Language.Length > 0 || epubOptions.Style != EpubStyle.Default))
					Console.WriteLine("Language, description and style options only apply to epub output. Ignoring them.");

				bool urlInput = source.Contains("literotica.com");

				string[] urls = urlInput
					? [source.Trim()]
					: (await File.ReadAllLinesAsync(source))
					.Select(line => line.Trim())
					.Where(line => !string.IsNullOrWhiteSpace(line))
					.ToArray();

				if (urls.Length > 1 && !string.IsNullOrEmpty(coverPath))
				{
					Console.WriteLine("Custom cover image is not supported for bulk downloading. Ignoring cover option.");
					coverPath = string.Empty;
				}
				
				if (logEnabled)
					Console.WriteLine($"Found {urls.Length} urls...");

				await HandleOutput(urls, format, outputDir, logEnabled, startAt, endAt, coverPath, epubOptions);
			});

			ParseResult parseResult = rootCommand.Parse(args);
			foreach (ParseError error in parseResult.Errors) Console.WriteLine(error.Message);

			return await parseResult.InvokeAsync();
		}

		private static async Task HandleOutput(string[] urls, string format, string outputDir, bool logEnabled, int startIndex, int endIndex, string coverPath, EpubOptions epubOptions)
		{
			foreach (string url in urls)
			{
				if (logEnabled)
					Console.WriteLine($"Processing URL: {url}");

				bool isSeries = url.Contains("/se/");
				bool singleFile = format == "singlefile";

				if (!format.Contains("epub", StringComparison.CurrentCultureIgnoreCase))
				{
					if (isSeries) await HandleSeries(url, outputDir, singleFile, logEnabled, startIndex, endIndex, coverPath);
					else await HandleStory(url, outputDir, logEnabled, startIndex, endIndex, coverPath);
				}
				else
				{
					if (logEnabled && !EventHandled)
					{
						EventHandled = true;
					}

					bool raw = format.Contains("raw", StringComparison.CurrentCultureIgnoreCase);

					if (isSeries) await StoryWriter.CreateEpubFromSeriesAsync(url, outputDir, coverPath, raw, startIndex, endIndex, epubOptions);
					else await StoryWriter.CreateEpubFromStoryAsync(url, outputDir, coverPath, raw, epubOptions);
				}
			}
		}

		private static async Task HandleSeries(string url, string outputDir, bool singleFile, bool logEnabled, int startAt, int endAt, string coverPath)
		{
			if (logEnabled)
				Console.WriteLine("[HandleSeries] Verifying series url...");

			string seriesSlug = await EpubManager.Writers.Literotica.UrlUtil.GetSeriesIdAsync(url);

			if (logEnabled)
				Console.WriteLine("[HandleSeries] Fetching series info from api...");

			Series? seriesData = await SeriesApi.GetSeriesInfoAsync(seriesSlug);

			if (seriesData is null || seriesData.Parts.Count == 0 || !seriesData.UserId.HasValue)
				throw new Exception("No stories found in the specified series.");

			if (logEnabled)
				Console.WriteLine("[HandleSeries] Fetching author info from api...");

			Author? author = await AuthorsApi.GetAuthorByIdAsync(seriesData.UserId.Value);

			if (logEnabled)
				Console.WriteLine("[HandleSeries] Downloading chapters...");

			Dictionary<string, string> chapters = [];
			
			for (int storyIndex = startAt; storyIndex < seriesData.Parts.Count; storyIndex++)
			{
				if (storyIndex > endAt - 1) break;

				Part story = seriesData.Parts[storyIndex];

				if (logEnabled)
					Console.WriteLine($"[HandleSeries] Downloading chapter: {story.Title}...");

				string[] pages = await StoryApi.GetStoryContentAsync(story.Url);
				chapters.Add(story.Title, string.Join(Environment.NewLine + Environment.NewLine, pages));
			}

			if (singleFile)
			{
				if (logEnabled)
					Console.WriteLine("[HandleSeries] Writing to single file...");
				
				string seriesDir = Path.Combine(outputDir, UrlUtil.ToSafeFileName(author?.Username ?? "Unknown Author"));
				string seriesFilePath = Path.Combine(seriesDir, $"{UrlUtil.ToSafeFileName(seriesData.Title)}.txt");

				Directory.CreateDirectory(seriesDir);

				if (!string.IsNullOrEmpty(coverPath))
				{
					string coverDestPath = Path.Combine(seriesDir, Path.GetFileName(coverPath));

					if (File.Exists(coverPath))
					{
						try { File.Copy(coverPath, coverDestPath, true); }
						catch (Exception ex) { Console.WriteLine($"[HandleSeries] Warning: Could not copy cover image. {ex.Message}"); }
					}
					else if (coverPath.StartsWith("http", StringComparison.OrdinalIgnoreCase))
					{
						try
						{
							Console.WriteLine("[HandleSeries] Detected URL based cover path, attempting download...");
							using HttpClient httpClient = new();
							HttpResponseMessage response = httpClient.GetAsync(coverPath).Result;

							if (response.IsSuccessStatusCode)
							{
								await using FileStream fileStream = new(
									coverDestPath,
									FileMode.Create,
									FileAccess.Write,
									FileShare.None,
									bufferSize: 8192,
									useAsync: true);

								response.Content.CopyToAsync(fileStream).Wait();
								Console.WriteLine($"[CreateEpub] Downloaded cover from URL: {coverPath}");
							}
							else
							{
								Console.WriteLine($"[CreateEpub] Failed to download cover (HTTP {response.StatusCode}) from {coverPath}");
							}
						}
						catch (Exception ex) { Console.WriteLine($"[HandleSeries] Warning: Could not download cover image. {ex.Message}"); }
					}
				}
				
				await using StreamWriter writer = new(seriesFilePath);

				await writer.WriteLineAsync($"""
				                             Story Title: {seriesData.Title}
				                             Story Author: {author?.Username}
				                             Chapter Count: {seriesData.Parts.Count}
				                             Series URL: {url}
				                             
				                             
				                             
				                             """);

				foreach (KeyValuePair<string, string> chapter in chapters)
				{
					await writer.WriteLineAsync(chapter.Key);
					await writer.WriteLineAsync(new string('=', chapter.Key.Length));
					await writer.WriteLineAsync();
					await writer.WriteLineAsync(chapter.Value);
					await writer.WriteLineAsync();
					await writer.WriteLineAsync();
				}

				if (logEnabled)
					Console.WriteLine($"[HandleSeries] Single file write complete: {seriesFilePath}");

			}
			else
			{
				if (logEnabled)
					Console.WriteLine("[HandleSeries] Writing chapters to individual files...");

				string seriesDir = Path.Combine(outputDir, UrlUtil.ToSafeFileName(author?.Username ?? "Unknown Author"), UrlUtil.ToSafeFileName(seriesData.Title));
				Directory.CreateDirectory(seriesDir);

				if (!string.IsNullOrEmpty(coverPath))
				{
					string coverDestPath = Path.Combine(seriesDir, Path.GetFileName(coverPath));

					if (File.Exists(coverPath))
					{
						try { File.Copy(coverPath, coverDestPath, true); }
						catch (Exception ex) { Console.WriteLine($"[HandleSeries] Warning: Could not copy cover image. {ex.Message}"); }
					}
					else if (coverPath.StartsWith("http", StringComparison.OrdinalIgnoreCase))
					{
						try
						{
							Console.WriteLine("[HandleSeries] Detected URL based cover path, attempting download...");
							using HttpClient httpClient = new();
							HttpResponseMessage response = httpClient.GetAsync(coverPath).Result;

							if (response.IsSuccessStatusCode)
							{
								await using FileStream fileStream = new(
									coverDestPath,
									FileMode.Create,
									FileAccess.Write,
									FileShare.None,
									bufferSize: 8192,
									useAsync: true);

								response.Content.CopyToAsync(fileStream).Wait();
								Console.WriteLine($"[CreateEpub] Downloaded cover from URL: {coverPath}");
							}
							else
							{
								Console.WriteLine($"[CreateEpub] Failed to download cover (HTTP {response.StatusCode}) from {coverPath}");
							}
						}
						catch (Exception ex) { Console.WriteLine($"[HandleSeries] Warning: Could not download cover image. {ex.Message}"); }
					}
				}

				foreach (KeyValuePair<string, string> chapter in chapters)
				{
					if (logEnabled)
						Console.WriteLine($"[HandleSeries] Writing chapter file: {chapter.Key}...");
					string chapterFilePath = Path.Combine(seriesDir, UrlUtil.ToSafeFileName($"{chapter.Key}.txt"));
					await File.WriteAllTextAsync(chapterFilePath, chapter.Value);
				}

				if (logEnabled)
					Console.WriteLine($"[HandleSeries] Individual chapter files write complete: {seriesDir}");
			}
		}

		private static async Task HandleStory(string url, string outputDir, bool logEnabled, int startAt, int endAt, string coverPath)
		{
			if (logEnabled)
				Console.WriteLine("[HandleStory] Verifying story url...");
			string storySlug = await EpubManager.Writers.Literotica.UrlUtil.GetStorySlugAsync(url).ConfigureAwait(false);

			if (logEnabled)
				Console.WriteLine("[HandleStory] Fetching story info from api...");
			StoryInfo? storyData = await StoryApi.GetStoryInfoAsync(storySlug);

			if (storyData?.Submission.Author.Userid == null)
				throw new Exception("The specified story could not be found.");

			if (logEnabled)
				Console.WriteLine("[HandleStory] Downloading story content...");

			string[] fullStoryText = await StoryApi.GetStoryContentAsync(storyData.Submission.Url);
			int start = Math.Max(startAt - 1, 0);
			int end = Math.Min(endAt, fullStoryText.Length);

			if (start > end)
				throw new Exception("Invalid start or end index for story content.");

			string[] pages = fullStoryText[start..end];

			string storyContent = string.Join(Environment.NewLine + Environment.NewLine, pages);
			string authorDir = Path.Combine(outputDir, UrlUtil.ToSafeFileName(storyData.Submission.Author.Username));
			Directory.CreateDirectory(authorDir);
			string storyFilePath = Path.Combine(authorDir, UrlUtil.ToSafeFileName($"{storyData.Submission.Title}.txt"));
			
			if (logEnabled)
				Console.WriteLine("[HandleStory] Writing story to file...");

			if (!string.IsNullOrEmpty(coverPath))
			{
				string coverDestPath = Path.Combine(authorDir, $"{UrlUtil.ToSafeFileName(storyData.Submission.Title)}-{Path.GetFileName(coverPath)}");

				if (File.Exists(coverPath))
				{
					try { File.Copy(coverPath, coverDestPath, true); }
					catch (Exception ex) { Console.WriteLine($"[HandleSeries] Warning: Could not copy cover image. {ex.Message}"); }
				}
				else if (coverPath.StartsWith("http", StringComparison.OrdinalIgnoreCase))
				{
					try
					{
						Console.WriteLine("[HandleSeries] Detected URL based cover path, attempting download...");
						using HttpClient httpClient = new();
						HttpResponseMessage response = httpClient.GetAsync(coverPath).Result;

						if (response.IsSuccessStatusCode)
						{
							await using FileStream fileStream = new(
								coverDestPath,
								FileMode.Create,
								FileAccess.Write,
								FileShare.None,
								bufferSize: 8192,
								useAsync: true);

							response.Content.CopyToAsync(fileStream).Wait();
							Console.WriteLine($"[CreateEpub] Downloaded cover from URL: {coverPath}");
						}
						else
						{
							Console.WriteLine($"[CreateEpub] Failed to download cover (HTTP {response.StatusCode}) from {coverPath}");
						}
					}
					catch (Exception ex) { Console.WriteLine($"[HandleSeries] Warning: Could not download cover image. {ex.Message}"); }
				}
			}

			await using StreamWriter writer = new(storyFilePath);

			await writer.WriteLineAsync($"""
			                             Story Title: {storyData.Submission.Title}
			                             Story Author: {storyData.Submission.Author.Username}
			                             Word Count: {storyData.Submission.WordsCount}
			                             Story URL: {url}
			                             
			                             {storyContent}
			                             """);
		}
	}
}
