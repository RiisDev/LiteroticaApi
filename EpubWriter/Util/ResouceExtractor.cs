using System.Reflection;

namespace LiteroticaApi.EpubWriter.Util
{
	internal static class ResourceExtractor
	{
		public static void WriteEpubManifest(string outputDirectory)
		{
			if (string.IsNullOrWhiteSpace(outputDirectory))
				throw new ArgumentException("Output directory cannot be null or empty.", nameof(outputDirectory));

			string metaInfDir = Path.Combine(outputDirectory, "META-INF");
			string epubDir = Path.Combine(outputDirectory, "EPUB");
			string stylesDir = Path.Combine(epubDir, "styles");

			Directory.CreateDirectory(outputDirectory);
			Directory.CreateDirectory(metaInfDir);
			Directory.CreateDirectory(stylesDir);
			Directory.CreateDirectory(epubDir);
			Directory.CreateDirectory(Path.Combine(epubDir, "text"));

			Assembly assembly = Assembly.GetExecutingAssembly();
			string root = $"{assembly.GetName().Name}.EpubWriter.Standards.";

			WriteEmbeddedFile(assembly, $"{root}mimetype", Path.Combine(outputDirectory, "mimetype"));
			WriteEmbeddedFile(assembly, $"{root}META_INF.container.xml", Path.Combine(metaInfDir, "container.xml"));
			WriteEmbeddedFile(assembly, $"{root}META_INF.com.apple.ibooks.display-options.xml", Path.Combine(metaInfDir, "com.apple.ibooks.display-options.xml"));
			WriteEmbeddedFile(assembly, $"{root}styles.stylesheet1.css", Path.Combine(stylesDir, "stylesheet1.css"));
		}

		private static void WriteEmbeddedFile(Assembly assembly, string resourceName, string outputPath)
		{
			using Stream? stream = assembly.GetManifestResourceStream(resourceName);
			if (stream == null)
				throw new FileNotFoundException($"Embedded resource not found: {resourceName}");

			using FileStream fileStream = new(outputPath, FileMode.Create, FileAccess.Write);
			stream.CopyTo(fileStream);
		}
	}
}
