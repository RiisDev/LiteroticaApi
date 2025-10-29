using System.IO.Compression;
using System.Xml.Linq;
using LiteroticaApi.Api;
using LiteroticaApi.DataObjects;
using LiteroticaApi.EpubWriter.Util;
using LiteroticaApi.Util;

namespace LiteroticaApi.EpubWriter
{
	/// <summary>
	/// Represents metadata about a story series, including its title and volume number.
	/// </summary>
	/// <param name="Title">The title of the series.</param>
	/// <param name="Volume">The volume number of the story within the series.</param>
	public record EpubSeries(string Title, int Volume);

	/// <summary>
	/// Represents a story prepared for EPUB generation, containing its metadata and chapters.
	/// </summary>
	/// <param name="Title">The title of the story.</param>
	/// <param name="Language">The language in which the story is written (e.g., "English").</param>
	/// <param name="Author">The author’s name or pseudonym.</param>
	/// <param name="Series">Optional series metadata if the story belongs to one.</param>
	/// <param name="Tags">An array of associated tags or genres describing the story.</param>
	/// <param name="Chapters">A collection of file paths to the chapter text files for the story.</param>
	/// <param name="CoverPath">Optional file path to the story’s cover image.</param>
	public record EpubStory(
		string Title,
		string Language,
		string Author,
		EpubSeries? Series,
		string[] Tags,
		IReadOnlyList<string> Chapters,
		string? CoverPath = null)
	{
		/// <summary>
		/// Gets a unique identifier for this story instance. 
		/// Used internally for metadata consistency and manifest references.
		/// </summary>
		public object Identifier { get; } = Guid.NewGuid();
	}

	/// <summary>
	/// Provides functionality for generating EPUB files from Literotica stories and series.
	/// </summary>
	/// <remarks>
	/// This class uses the Literotica API to fetch story or series data, and then compiles it into
	/// a standards-compliant EPUB structure. It generates all required EPUB components such as
	/// <c>toc.ncx</c>, <c>content.opf</c>, and XHTML files for chapters, cover, and navigation.
	/// </remarks>
	public static class StoryWriter
	{
		private static readonly string TempDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "temp");

		/// <summary>
		/// Creates an EPUB file from a given <see cref="EpubStory"/> object and outputs it to the specified directory.
		/// </summary>
		/// <param name="story">The <see cref="EpubStory"/> containing metadata, chapters, and optional cover.</param>
		/// <param name="outputDirectory">The directory where the final EPUB file should be saved. Defaults to the base directory.</param>
		/// <exception cref="Exception">Thrown when a required file cannot be written or an I/O operation fails.</exception>
		public static void CreateEpub(EpubStory story, string? outputDirectory = null)
		{
			string baseDirectory = string.IsNullOrEmpty(outputDirectory)
				? AppDomain.CurrentDomain.BaseDirectory
				: outputDirectory!;
			string storyDirectory = Path.Combine(baseDirectory, story.Title);

			// Extract the default EPUB manifest structure from embedded resources.
			ResourceExtractor.WriteEpubManifest(storyDirectory);

			// Generate core EPUB metadata and navigation files.
			XDocument tocNcx = WriterUtil.GenerateTocNcx(story);
			string tocNcxPath = Path.Combine(storyDirectory, "EPUB", "toc.ncx");
			tocNcx.Save(tocNcxPath);

			XDocument contentOpf = WriterUtil.GenerateContentOpf(story);
			string contentOpfPath = Path.Combine(storyDirectory, "EPUB", "content.opf");
			contentOpf.Save(contentOpfPath);

			XDocument navXhtml = WriterUtil.GenerateNavXhtml(story);
			string navXhtmlPath = Path.Combine(storyDirectory, "EPUB", "nav.xhtml");
			navXhtml.Save(navXhtmlPath);

			// Generate title page.
			XDocument titlePageXhtml = WriterUtil.GenerateTitlePage(story);
			string titlePagePath = Path.Combine(storyDirectory, "EPUB", "text", "title_page.xhtml");
			titlePageXhtml.Save(titlePagePath);

			// Handle optional cover image.
			if (!string.IsNullOrEmpty(story.CoverPath))
			{
				string coverDestDir = Path.Combine(storyDirectory, "EPUB", "images");
				Directory.CreateDirectory(coverDestDir);
				string coverDest = Path.Combine(coverDestDir, "cover" + Path.GetExtension(story.CoverPath));
				File.Copy(story.CoverPath!, coverDest, true);

				XDocument coverXhtml = WriterUtil.GenerateCoverPage(story);
				coverXhtml.Save(Path.Combine(storyDirectory, "EPUB", "text", "cover.xhtml"));
			}

			// Write each chapter file into the EPUB structure.
			for (int i = 0; i < story.Chapters.Count; i++)
			{
				string chapterPathInput = story.Chapters[i];
				string chapterContent = File.ReadAllText(chapterPathInput);

				XDocument chapterDoc = WriterUtil.GenerateChapterXhtml(
					Path.GetFileNameWithoutExtension(chapterPathInput),
					chapterContent,
					i + 1
				);

				string chapterOutputPath = Path.Combine(storyDirectory, "EPUB", "text", $"ch{i + 1:000}.xhtml");
				chapterDoc.Save(chapterOutputPath);
			}

			// Package all files into a final EPUB zip archive.
			string epubFilePath = Path.Combine(baseDirectory, $"{story.Title}.epub");
			if (File.Exists(epubFilePath)) File.Delete(epubFilePath);

			ZipFile.CreateFromDirectory(storyDirectory, epubFilePath, CompressionLevel.NoCompression, false);

			// Clean up temporary working directory.
			Directory.Delete(storyDirectory, true);
		}

		/// <summary>
		/// Generates an EPUB file from an entire series on Literotica, including all its parts (stories).
		/// </summary>
		/// <param name="seriesUrl">The URL of the Literotica series to download and convert.</param>
		/// <param name="outputDirectory">The directory where the EPUB file should be created.</param>
		/// <exception cref="Exception">Thrown if the series cannot be found or has no valid stories.</exception>
		public static async Task CreateEpubFromSeries(string seriesUrl, string outputDirectory)
		{
			string seriesSlug = UrlUtil.GetSeriesId(seriesUrl);
			Series? seriesData = await SeriesApi.GetSeriesInfoAsync(seriesSlug);

			if (seriesData is null || seriesData.Parts.Count == 0 || !seriesData.UserId.HasValue)
				throw new Exception("No stories found in the specified series.");

			Author? author = await AuthorsApi.GetAuthorByIdAsync(seriesData.UserId.Value);

			// Attempt to retrieve the series cover image.
			string? coverPath;
			try
			{
				Cover cover = await SeriesApi.GetSeriesCoverAsync(seriesSlug);
				coverPath = cover.Data.Mobile.X1.FilePath;
			}
			catch
			{
				coverPath = "";
			}

			// Fetch content for each story in the series.
			Dictionary<string, string> chapters = [];
			foreach (Part story in seriesData.Parts)
			{
				string[] pages = await StoryApi.GetStoryContentAsync(story.Url);
				chapters.Add(story.Title, string.Join(Environment.NewLine + Environment.NewLine, pages));
			}

			// Prepare temporary directory for writing chapter files.
			string storyLocation = Path.Combine(TempDir, seriesData.Title, "Chapters");
			Directory.CreateDirectory(storyLocation);

			foreach (KeyValuePair<string, string> chapter in chapters)
			{
				string chapterFilePath = Path.Combine(storyLocation, $"{chapter.Key}.txt");
				File.WriteAllText(chapterFilePath, chapter.Value);
			}

			// Assemble and create the EPUB.
			EpubStory epubStory = new(
				Title: seriesData.Title,
				Language: "English",
				CoverPath: string.IsNullOrEmpty(coverPath) ? null : coverPath,
				Author: author?.Username ?? "Unknown Author",
				Series: new EpubSeries(seriesData.Title, 1),
				Tags: [],
				Chapters: Directory.GetFiles(storyLocation)
			);

			CreateEpub(epubStory, outputDirectory);
		}

		/// <summary>
		/// Generates an EPUB file from a single Literotica story.
		/// </summary>
		/// <param name="storyUrl">The URL of the story to convert.</param>
		/// <param name="outputDirectory">The directory where the EPUB file should be created.</param>
		/// <exception cref="Exception">Thrown if the story or author information cannot be retrieved.</exception>
		public static async Task CreateEpubFromStory(string storyUrl, string outputDirectory)
		{
			string storySlug = UrlUtil.GetStorySlug(storyUrl);
			StoryInfo? storyData = await StoryApi.GetStoryInfoAsync(storySlug);

			if (storyData is null || string.IsNullOrEmpty(storyData.Submission.Authorname))
				throw new Exception("The specified story could not be found or contains no valid content.");

			string[] storyText = await StoryApi.GetStoryContentAsync(storySlug);

			// Prepare directory for temporary text file storage.
			string storyLocation = Path.Combine(TempDir, storyData.Submission.Title, "Chapters");
			Directory.CreateDirectory(storyLocation);

			string chapterFilePath = Path.Combine(storyLocation, $"{storyData.Submission.Title}.txt");
			File.WriteAllText(chapterFilePath, string.Join("\n\n", storyText));

			// Construct the EPUB metadata and generate the final file.
			EpubStory epubStory = new(
				Title: storyData.Submission.Title,
				Language: "English",
				CoverPath: null,
				Author: storyData.Submission.Author.Username,
				Series: new EpubSeries(storyData.Submission.Title, 1),
				Tags: storyData.Submission.Tags.Select(tag => tag.TagText.ToString()).ToArray(),
				Chapters: Directory.GetFiles(storyLocation)
			);

			CreateEpub(epubStory, outputDirectory);
		}
	}
}
