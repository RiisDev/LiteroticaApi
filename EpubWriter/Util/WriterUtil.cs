using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml.Linq;

namespace LiteroticaApi.EpubWriter.Util
{
	internal static class WriterUtil
	{
		internal static void CleanChapterFile(string chapterPathInput, StoryWriter.OnLogEventHandler? onLog = null)
		{

			string chapterContent = File.ReadAllText(chapterPathInput, Encoding.UTF8);

			string cleanedContent = DecodeHtmlEntities(chapterContent);

			cleanedContent = Regex.Replace(
				cleanedContent,
				@"<(/?)([A-Z][A-Z0-9]*)",
				m => $"<{m.Groups[1].Value}{m.Groups[2].Value.ToLower()}",
				RegexOptions.IgnoreCase
			);

			string[] voidTags = ["br", "hr", "img", "input", "meta", "link"];
			cleanedContent = voidTags.Aggregate(cleanedContent, (current, tag) => Regex.Replace(current, $@"<({tag})([^>/]*?)(?<!/)>", "<$1$2 />", RegexOptions.IgnoreCase));

			string[] lines = cleanedContent.Split('\n');
			List<string> cleanedLines = [];

			Regex tagRegex = new(@"<(/?)([a-zA-Z0-9]+)(?:\s[^>]*)?>", RegexOptions.IgnoreCase | RegexOptions.Compiled);
			
			foreach (string rawLine in lines)
			{
				string line = rawLine.Trim();

				if (!line.StartsWith("<p>"))
				{
					cleanedLines.Add(rawLine);
					continue;
				}

				if (string.IsNullOrEmpty(line)) continue;

				line = HttpUtility.HtmlDecode(line);

				MatchCollection matches = tagRegex.Matches(line);

				List<string> openTags = [];
				List<string> closeTags = [];

				foreach (Match match in matches)
				{
					string tag = match.Groups[2].Value;
					bool isClosing = match.Groups[1].Value == "/";

					if (isClosing)
						closeTags.Add(tag);
					else if (!voidTags.Contains(tag))
						openTags.Add(tag);
				}

				line = openTags.Where(tag => !closeTags.Contains(tag)).Aggregate(line, (current, tag) => Regex.Replace(current, $@"<{tag}[^>]*>", "", RegexOptions.IgnoreCase));
				line = closeTags.Where(tag => !openTags.Contains(tag)).Aggregate(line, (current, tag) => Regex.Replace(current, $@"</{tag}>", "", RegexOptions.IgnoreCase));
				
				line = line.Replace("<p>", "").Replace("<p", "");
				line = line.Replace("</p>", "").Replace("</p", "");

				line = line.Insert(0, "<p>");
				line = line.Insert(line.Length, "</p>");

				if (!string.IsNullOrWhiteSpace(line))
					cleanedLines.Add(line);
			}

			cleanedContent = string.Join("\n", cleanedLines.Where(x=> !string.IsNullOrWhiteSpace(x.Replace("<p>", "").Replace("</p>", ""))));

			cleanedContent = cleanedContent
				.Replace("\r\n", "\n")
				.Replace("\r", "\n")
				.Trim();

			cleanedContent = DecodeHtmlEntities(cleanedContent);

			try { _ = XDocument.Parse(cleanedContent); }
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				onLog?.Invoke($"[CleanChapter] Warning: XHTML parsing failed for {Path.GetFileName(chapterPathInput)}: {ex.Message}");
				Console.ResetColor();
			}

			File.WriteAllText(chapterPathInput, cleanedContent, Encoding.UTF8);

			onLog?.Invoke($"[CleanChapter] XHTML-normalized and paragraph-cleaned: {Path.GetFileName(chapterPathInput)}");
		}

		private static string DecodeHtmlEntities(string chapterContent)
		{
			return chapterContent
				.Replace("&lt;", "<") // Keep these
				.Replace("&gt;", ">") // Keep these
				.Replace("&amp;", "&#38;")
				.Replace("&", "&#38;")
				.Replace("&nbsp;", "&#160;")
				.Replace("&quot;", "&#34;")
				.Replace("&apos;", "&#39;")
				.Replace("&iexcl;", "&#161;")
				.Replace("&cent;", "&#162;")
				.Replace("&pound;", "&#163;")
				.Replace("&curren;", "&#164;")
				.Replace("&yen;", "&#165;")
				.Replace("&brvbar;", "&#166;")
				.Replace("&sect;", "&#167;")
				.Replace("&uml;", "&#168;")
				.Replace("&copy;", "&#169;")
				.Replace("&ordf;", "&#170;")
				.Replace("&laquo;", "&#171;")
				.Replace("&not;", "&#172;")
				.Replace("&shy;", "&#173;")
				.Replace("&reg;", "&#174;")
				.Replace("&macr;", "&#175;")
				.Replace("&deg;", "&#176;")
				.Replace("&plusmn;", "&#177;")
				.Replace("&sup2;", "&#178;")
				.Replace("&sup3;", "&#179;")
				.Replace("&acute;", "&#180;")
				.Replace("&micro;", "&#181;")
				.Replace("&para;", "&#182;")
				.Replace("&middot;", "&#183;")
				.Replace("&cedil;", "&#184;")
				.Replace("&sup1;", "&#185;")
				.Replace("&ordm;", "&#186;")
				.Replace("&raquo;", "&#187;")
				.Replace("&frac14;", "&#188;")
				.Replace("&frac12;", "&#189;")
				.Replace("&frac34;", "&#190;")
				.Replace("&iquest;", "&#191;")
				.Replace("&times;", "&#215;")
				.Replace("&divide;", "&#247;")
				.Replace("&forall;", "&#8704;")
				.Replace("&part;", "&#8706;")
				.Replace("&exist;", "&#8707;")
				.Replace("&empty;", "&#8709;")
				.Replace("&nabla;", "&#8711;")
				.Replace("&isin;", "&#8712;")
				.Replace("&notin;", "&#8713;")
				.Replace("&ni;", "&#8715;")
				.Replace("&prod;", "&#8719;")
				.Replace("&sum;", "&#8721;")
				.Replace("&minus;", "&#8722;")
				.Replace("&lowast;", "&#8727;")
				.Replace("&radic;", "&#8730;")
				.Replace("&prop;", "&#8733;")
				.Replace("&infin;", "&#8734;")
				.Replace("&ang;", "&#8736;")
				.Replace("&and;", "&#8743;")
				.Replace("&or;", "&#8744;")
				.Replace("&cap;", "&#8745;")
				.Replace("&cup;", "&#8746;")
				.Replace("&int;", "&#8747;")
				.Replace("&there4;", "&#8756;")
				.Replace("&sim;", "&#8764;")
				.Replace("&cong;", "&#8773;")
				.Replace("&asymp;", "&#8776;")
				.Replace("&ne;", "&#8800;")
				.Replace("&equiv;", "&#8801;")
				.Replace("&le;", "&#8804;")
				.Replace("&ge;", "&#8805;")
				.Replace("&sub;", "&#8834;")
				.Replace("&sup;", "&#8835;")
				.Replace("&nsub;", "&#8836;")
				.Replace("&sube;", "&#8838;")
				.Replace("&supe;", "&#8839;")
				.Replace("&oplus;", "&#8853;")
				.Replace("&otimes;", "&#8855;")
				.Replace("&perp;", "&#8869;")
				.Replace("&sdot;", "&#8901;")
				.Replace("&alpha;", "&#945;")
				.Replace("&beta;", "&#946;")
				.Replace("&gamma;", "&#947;")
				.Replace("&delta;", "&#948;")
				.Replace("&epsilon;", "&#949;")
				.Replace("&zeta;", "&#950;")
				.Replace("&eta;", "&#951;")
				.Replace("&theta;", "&#952;")
				.Replace("&iota;", "&#953;")
				.Replace("&kappa;", "&#954;")
				.Replace("&lambda;", "&#955;")
				.Replace("&mu;", "&#956;")
				.Replace("&nu;", "&#957;")
				.Replace("&xi;", "&#958;")
				.Replace("&omicron;", "&#959;")
				.Replace("&pi;", "&#960;")
				.Replace("&rho;", "&#961;")
				.Replace("&sigmaf;", "&#962;")
				.Replace("&sigma;", "&#963;")
				.Replace("&tau;", "&#964;")
				.Replace("&upsilon;", "&#965;")
				.Replace("&phi;", "&#966;")
				.Replace("&chi;", "&#967;")
				.Replace("&psi;", "&#968;")
				.Replace("&omega;", "&#969;")
				.Replace("&Alpha;", "&#913;")
				.Replace("&Beta;", "&#914;")
				.Replace("&Gamma;", "&#915;")
				.Replace("&Delta;", "&#916;")
				.Replace("&Epsilon;", "&#917;")
				.Replace("&Zeta;", "&#918;")
				.Replace("&Eta;", "&#919;")
				.Replace("&Theta;", "&#920;")
				.Replace("&Iota;", "&#921;")
				.Replace("&Kappa;", "&#922;")
				.Replace("&Lambda;", "&#923;")
				.Replace("&Mu;", "&#924;")
				.Replace("&Nu;", "&#925;")
				.Replace("&Xi;", "&#926;")
				.Replace("&Omicron;", "&#927;")
				.Replace("&Pi;", "&#928;")
				.Replace("&Rho;", "&#929;")
				.Replace("&Sigma;", "&#931;")
				.Replace("&Tau;", "&#932;")
				.Replace("&Upsilon;", "&#933;")
				.Replace("&Phi;", "&#934;")
				.Replace("&Chi;", "&#935;")
				.Replace("&Psi;", "&#936;")
				.Replace("&Omega;", "&#937;")
				.Replace("&larr;", "&#8592;")
				.Replace("&uarr;", "&#8593;")
				.Replace("&rarr;", "&#8594;")
				.Replace("&darr;", "&#8595;")
				.Replace("&harr;", "&#8596;")
				.Replace("&crarr;", "&#8629;")
				.Replace("&lArr;", "&#8656;")
				.Replace("&uArr;", "&#8657;")
				.Replace("&rArr;", "&#8658;")
				.Replace("&dArr;", "&#8659;")
				.Replace("&hArr;", "&#8660;")
				.Replace("&loz;", "&#9674;")
				.Replace("&spades;", "&#9824;")
				.Replace("&clubs;", "&#9827;")
				.Replace("&hearts;", "&#9829;")
				.Replace("&diams;", "&#9830;")
				.Replace("&bull;", "&#8226;")
				.Replace("&hellip;", "&#8230;")
				.Replace("&prime;", "&#8242;")
				.Replace("&Prime;", "&#8243;")
				.Replace("&oline;", "&#8254;")
				.Replace("&frasl;", "&#8260;")
				.Replace("&weierp;", "&#8472;")
				.Replace("&image;", "&#8465;")
				.Replace("&real;", "&#8476;")
				.Replace("&trade;", "&#8482;")
				.Replace("&alefsym;", "&#8501;")
				.Replace("&lsquo;", "&#8216;")
				.Replace("&rsquo;", "&#8217;");
		}
		
		internal static XDocument GenerateChapterXhtml(string chapterTitle, string chapterText, int chapterNumber)
		{
			XNamespace xhtml = "http://www.w3.org/1999/xhtml";
			XNamespace epub = "http://www.idpf.org/2007/ops";

			string[] paragraphs = chapterText.Split(["\r\n", "\n"], StringSplitOptions.RemoveEmptyEntries);

			return new XDocument(
				new XDeclaration("1.0", "utf-8", "yes"),
				new XElement(xhtml + "html",
					new XAttribute(XNamespace.Xmlns + "epub", epub),
					new XElement(xhtml + "head",
						new XElement(xhtml + "meta", new XAttribute("charset", "utf-8")),
						new XElement(xhtml + "title", chapterTitle),
						new XElement(xhtml + "link",
							new XAttribute("rel", "stylesheet"),
							new XAttribute("type", "text/css"),
							new XAttribute("href", "../styles/stylesheet1.css")
						)
					),
					new XElement(xhtml + "body",
						new XElement(xhtml + "h1",
							new XAttribute("id", $"chapter-{chapterNumber:00}"),
							chapterTitle
						),
						paragraphs.Select(p => new XElement(xhtml + "p", p))
					)
				)
			);
		}

		internal static XDocument GenerateTitlePage(EpubStory story)
		{
			XNamespace xhtml = "http://www.w3.org/1999/xhtml";
			XNamespace epub = "http://www.idpf.org/2007/ops";

			List<XElement> bodyElements = [new(xhtml + "h1", new XAttribute("class", "title"), story.Title)];

			if (story.Series != null)
			{
				bodyElements.Add(
					new XElement(xhtml + "h2", new XAttribute("class", "series"),
						$"{story.Series.Title} - Volume {story.Series.Volume}")
				);
			}

			return new XDocument(
				new XDeclaration("1.0", "utf-8", "yes"),
				new XElement(xhtml + "html",
					new XAttribute(XNamespace.Xmlns + "epub", epub),
					new XElement(xhtml + "head",
						new XElement(xhtml + "meta", new XAttribute("charset", "utf-8")),
						new XElement(xhtml + "title", story.Title),
						new XElement(xhtml + "link",
							new XAttribute("rel", "stylesheet"),
							new XAttribute("type", "text/css"),
							new XAttribute("href", "../styles/stylesheet1.css")
						)
					),
					new XElement(xhtml + "body", bodyElements)
				)
			);
		}

		internal static XDocument GenerateCoverPage(EpubStory story)
		{
			if (string.IsNullOrEmpty(story.CoverPath)) return null!;

			XNamespace xhtml = "http://www.w3.org/1999/xhtml";
			XNamespace epub = "http://www.idpf.org/2007/ops";

			return new XDocument(
				new XDeclaration("1.0", "utf-8", "yes"),
				new XElement(xhtml + "html",
					new XAttribute(XNamespace.Xmlns + "epub", epub),
					new XElement(xhtml + "head",
						new XElement(xhtml + "meta", new XAttribute("charset", "utf-8")),
						new XElement(xhtml + "title", "Cover")
					),
					new XElement(xhtml + "body",
						new XElement(xhtml + "img", new XAttribute("src", $"../images/cover{Path.GetExtension(story.CoverPath)}"),
							new XAttribute("alt", "Cover"))
					)
				)
			);
		}


		internal static XDocument GenerateNavXhtml(EpubStory story)
		{
			XNamespace xhtml = "http://www.w3.org/1999/xhtml";
			XNamespace epub = "http://www.idpf.org/2007/ops";

			return new XDocument(
				new XDeclaration("1.0", "utf-8", "yes"),
				new XElement(xhtml + "html",
					new XAttribute(XNamespace.Xmlns + "epub", epub),
					new XAttribute("lang", story.Language),
					new XAttribute(XNamespace.Xml + "lang", story.Language),

					new XElement(xhtml + "head",
						new XElement(xhtml + "meta", new XAttribute("charset", "utf-8")),
						new XElement(xhtml + "title", story.Title),
						new XElement(xhtml + "link",
							new XAttribute("rel", "stylesheet"),
							new XAttribute("type", "text/css"),
							new XAttribute("href", "styles/stylesheet1.css"))
					),

					new XElement(xhtml + "body",
						new XAttribute(epub + "type", "frontmatter"),

						new XElement(xhtml + "nav",
							new XAttribute(epub + "type", "toc"),
							new XAttribute("role", "doc-toc"),
							new XAttribute("id", "toc"),
							new XElement(xhtml + "h1",
								new XAttribute("id", "toc-title"),
								story.Title
							),
							new XElement(xhtml + "ol",
								new XAttribute("class", "toc"),
								GenerateNavLinks(story)
							)
						),

						new XElement(xhtml + "nav",
							new XAttribute(epub + "type", "landmarks"),
							new XAttribute("id", "landmarks"),
							new XAttribute("hidden", "hidden"),
							new XElement(xhtml + "ol",
								new XElement(xhtml + "li",
									new XElement(xhtml + "a",
										new XAttribute("href", "text/title_page.xhtml"),
										new XAttribute(epub + "type", "titlepage"),
										"Title Page"
									)
								),
								new XElement(xhtml + "li",
									new XElement(xhtml + "a",
										new XAttribute("href", "#toc"),
										new XAttribute(epub + "type", "toc"),
										"Table of Contents"
									)
								)
							)
						)
					)
				)
			);
		}

		internal static IEnumerable<XElement> GenerateNavLinks(EpubStory story)
		{
			XNamespace xhtml = "http://www.w3.org/1999/xhtml";

			for (int i = 0; i < story.Chapters.Count; i++)
			{
				string href = $"text/ch{i + 1:000}.xhtml#chapter-{i + 1:00}";
				string title = Path.GetFileNameWithoutExtension(story.Chapters[i]);

				yield return new XElement(xhtml + "li",
					new XAttribute("id", $"toc-li-{i + 1}"),
					new XElement(xhtml + "a",
						new XAttribute("href", href),
						title
					)
				);
			}
		}


		internal static XDocument GenerateContentOpf(EpubStory story)
		{
			string opfNamespace = "http://www.idpf.org/2007/opf";
			XNamespace dc = "http://purl.org/dc/elements/1.1/";

			List<XElement> metadata =
			[
				new(dc + "title", story.Title),
				new(dc + "language", story.Language),
				new(dc + "creator", story.Author),
				new(dc + "identifier", new XAttribute("id", "bookid"), $"urn:uuid:{story.Identifier}"),
				new(dc + "date", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"))
			];

			if (story.Series != null)
			{
				metadata.Add(new XElement(dc + "relation", $"{story.Series.Title} - Volume {story.Series.Volume}"));
			}

			if (!string.IsNullOrEmpty(story.CoverPath))
			{
				metadata.Add(new XElement("meta", new XAttribute("name", "cover"), new XAttribute("content", "cover-image")));
			}

			return new XDocument(
				new XElement(XName.Get("package", opfNamespace),
					new XAttribute("version", "3.0"),
					new XAttribute("unique-identifier", "bookid"),
					new XElement(XName.Get("metadata", opfNamespace), metadata),
					new XElement(XName.Get("manifest", opfNamespace), GenerateManifestItems(story, opfNamespace)),
					new XElement(XName.Get("spine", opfNamespace), GenerateSpineItems(story, opfNamespace)),
					new XElement(XName.Get("guide", opfNamespace),
						new XElement(XName.Get("reference", opfNamespace),
							new XAttribute("type", "cover"),
							new XAttribute("title", "Cover"),
							new XAttribute("href", "cover.xhtml")
						),
						new XElement(XName.Get("reference", opfNamespace),
							new XAttribute("type", "toc"),
							new XAttribute("title", "Table of Contents"),
							new XAttribute("href", "toc.ncx")
						)
					)
				)
			);
		}


		internal static XDocument GenerateTocNcx(EpubStory story)
		{
			string ncxNamespace = "http://www.daisy.org/z3986/2005/ncx/";

			return new XDocument(
				new XElement(XName.Get("ncx", ncxNamespace),
					new XAttribute("version", "2005-1"),
					new XElement(XName.Get("head", ncxNamespace),
						new XElement(XName.Get("meta", ncxNamespace),
							new XAttribute("name", "dtb:uid"),
							new XAttribute("content", $"urn:uuid:{story.Identifier}")),
						new XElement(XName.Get("meta", ncxNamespace),
							new XAttribute("name", "dtb:depth"),
							new XAttribute("content", "1")),
						new XElement(XName.Get("meta", ncxNamespace),
							new XAttribute("name", "dtb:totalPageCount"),
							new XAttribute("content", "0")),
						new XElement(XName.Get("meta", ncxNamespace),
							new XAttribute("name", "dtb:maxPageNumber"),
							new XAttribute("content", "0"))
					),
					new XElement(XName.Get("docTitle", ncxNamespace),
						new XElement(XName.Get("text", ncxNamespace), story.Title)
					),
					new XElement(XName.Get("navMap", ncxNamespace),
						GenerateNavPoints(story, ncxNamespace)
					)
				)
			);
		}

		internal static IEnumerable<XElement> GenerateManifestItems(EpubStory story, string opfNamespace)
		{
			yield return new XElement(XName.Get("item", opfNamespace),
				new XAttribute("id", "ncx"),
				new XAttribute("href", "toc.ncx"),
				new XAttribute("media-type", "application/x-dtbncx+xml")
			);

			yield return new XElement(XName.Get("item", opfNamespace),
				new XAttribute("id", "nav"),
				new XAttribute("href", "nav.xhtml"),
				new XAttribute("media-type", "application/xhtml+xml"),
				new XAttribute("properties", "nav")
			);

			yield return new XElement(XName.Get("item", opfNamespace),
				new XAttribute("id", "stylesheet1"),
				new XAttribute("href", "styles/stylesheet1.css"),
				new XAttribute("media-type", "text/css")
			);

			yield return new XElement(XName.Get("item", opfNamespace),
				new XAttribute("id", "title_page_xhtml"),
				new XAttribute("href", "text/title_page.xhtml"),
				new XAttribute("media-type", "application/xhtml+xml")
			);

			if (!string.IsNullOrEmpty(story.CoverPath))
			{
				yield return new XElement(XName.Get("item", opfNamespace),
					new XAttribute("id", "cover-image"),
					new XAttribute("href", "images/cover" + Path.GetExtension(story.CoverPath)),
					new XAttribute("media-type", "image/" + Path.GetExtension(story.CoverPath)!.TrimStart('.'))
				);
			}

			for (int i = 0; i < story.Chapters.Count; i++)
			{
				string id = $"ch{i + 1:000}_xhtml";
				string href = $"text/ch{i + 1:000}.xhtml";

				yield return new XElement(XName.Get("item", opfNamespace),
					new XAttribute("id", id),
					new XAttribute("href", href),
					new XAttribute("media-type", "application/xhtml+xml")
				);
			}
		}

		internal static IEnumerable<XElement> GenerateSpineItems(EpubStory story, string opfNamespace)
		{
			yield return new XElement(XName.Get("itemref", opfNamespace),
				new XAttribute("idref", "title_page_xhtml"),
				new XAttribute("linear", "yes")
			);

			yield return new XElement(XName.Get("itemref", opfNamespace),
				new XAttribute("idref", "nav")
			);

			for (int i = 0; i < story.Chapters.Count; i++)
			{
				string idref = $"ch{i + 1:000}_xhtml";
				yield return new XElement(XName.Get("itemref", opfNamespace),
					new XAttribute("idref", idref)
				);
			}
		}

		internal static IEnumerable<XElement> GenerateNavPoints(EpubStory story, string ncxNamespace)
		{
			yield return new XElement(XName.Get("navPoint", ncxNamespace),
				new XAttribute("id", "navPoint-0"),
				new XElement(XName.Get("navLabel", ncxNamespace),
					new XElement(XName.Get("text", ncxNamespace), story.Title)
				),
				new XElement(XName.Get("content", ncxNamespace),
					new XAttribute("src", "text/title.xhtml")
				)
			);

			for (int i = 0; i < story.Chapters.Count; i++)
			{
				yield return new XElement(XName.Get("navPoint", ncxNamespace),
					new XAttribute("id", $"navPoint-{i + 1}"),
					new XElement(XName.Get("navLabel", ncxNamespace),
						new XElement(XName.Get("text", ncxNamespace), Path.GetFileNameWithoutExtension(story.Chapters[i]))
					),
					new XElement(XName.Get("content", ncxNamespace),
						new XAttribute("src", $"text/chapter{i + 1}.xhtml")
					)
				);
			}
		}
	}
}
