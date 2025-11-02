using System.CommandLine;
using System.CommandLine.Parsing;
using LiteroticaApi.Api;
using LiteroticaApi.DataObjects;
using LiteroticaApi.EpubWriter;
using LiteroticaApi.Util;

namespace Literotica.Cli.Downloader
{
	public class Program
	{
		private static bool EventHandled { get; set; }

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

			RootCommand rootCommand = new("Story Downloader CLI")
			{
				sourceArgument,
				logOption,
				formatOption,
				outputOption
			};


			rootCommand.SetAction(async parseResult =>
			{
				string source = parseResult.GetRequiredValue(sourceArgument);
				bool logEnabled = parseResult.GetRequiredValue(logOption);
				string format = parseResult.GetRequiredValue(formatOption);
				string outputDir = parseResult.GetRequiredValue(outputOption);

				bool urlInput = source.Contains("literotica.com");

				string[] urls = urlInput
					? [source.Trim()]
					: (await File.ReadAllLinesAsync(source))
					.Select(line => line.Trim())
					.Where(line => !string.IsNullOrWhiteSpace(line))
					.ToArray();

				if (logEnabled)
					Console.WriteLine($"Found {urls.Length} urls...");

				await HandleOutput(urls, format, outputDir, logEnabled);
			});

			ParseResult parseResult = rootCommand.Parse(args);
			foreach (ParseError error in parseResult.Errors) Console.WriteLine(error.Message);

			return await parseResult.InvokeAsync();
		}

		private static async Task HandleOutput(string[] urls, string format, string outputDir, bool logEnabled)
		{
			foreach (string url in urls)
			{
				if (logEnabled)
					Console.WriteLine($"Processing URL: {url}");

				bool isSeries = url.Contains("/se/");
				bool singleFile = format == "singlefile";

				if (!format.Contains("epub", StringComparison.CurrentCultureIgnoreCase))
				{
					if (isSeries) await HandleSeries(url, outputDir, singleFile, logEnabled);
					else await HandleStory(url, outputDir, logEnabled);
				}
				else
				{
					if (logEnabled && !EventHandled)
					{
						EventHandled = true;
						StoryWriter.OnLog += Console.WriteLine;
					}

					bool raw = format.Contains("raw", StringComparison.CurrentCultureIgnoreCase);

					if (isSeries) await StoryWriter.CreateEpubFromSeries(url, outputDir, raw);
					else await StoryWriter.CreateEpubFromStory(url, outputDir, raw);
				}

			}
		}

		private static async Task HandleSeries(string url, string outputDir, bool singleFile, bool logEnabled)
		{
			if (logEnabled)
				Console.WriteLine("[HandleSeries] Verifying series url...");

			string seriesSlug = await UrlUtil.GetSeriesId(url);

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
			foreach (Part story in seriesData.Parts)
			{
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

		private static async Task HandleStory(string url, string outputDir, bool logEnabled)
		{
			if (logEnabled)
				Console.WriteLine("[HandleStory] Verifying story url...");
			string storySlug = await UrlUtil.GetStorySlug(url).ConfigureAwait(false);

			if (logEnabled)
				Console.WriteLine("[HandleStory] Fetching story info from api...");
			StoryInfo? storyData = await StoryApi.GetStoryInfoAsync(storySlug);

			if (storyData?.Submission.Author.Userid == null)
				throw new Exception("The specified story could not be found.");

			if (logEnabled)
				Console.WriteLine("[HandleStory] Downloading story content...");
			string[] pages = await StoryApi.GetStoryContentAsync(storyData.Submission.Url);

			string storyContent = string.Join(Environment.NewLine + Environment.NewLine, pages);
			string authorDir = Path.Combine(outputDir, UrlUtil.ToSafeFileName(storyData.Submission.Author.Username));
			Directory.CreateDirectory(authorDir);
			string storyFilePath = Path.Combine(authorDir, UrlUtil.ToSafeFileName($"{storyData.Submission.Title}.txt"));
			
			if (logEnabled)
				Console.WriteLine("[HandleStory] Writing story to file...");

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
