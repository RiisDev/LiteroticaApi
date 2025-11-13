
// ReSharper disable CheckNamespace
#pragma warning disable IDE0130 // Disable namespace check
namespace LiteroticaApi
{
	/// <summary>
	/// Represents an internal error that occurs within the Literotica API client library itself,
	/// not due to an external HTTP or API response issue.
	/// </summary>
	public class LitEroticaInternalException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LitEroticaInternalException"/> class.
		/// </summary>
		/// <param name="message">A message describing the internal error.</param>
		public LitEroticaInternalException(string message) : base(message) { }
	}

	/// <summary>
	/// Represents an error that occurs due to an invalid response or issue returned from the Literotica API.
	/// </summary>
	public class LitEroticaApiException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LitEroticaApiException"/> class.
		/// </summary>
		/// <param name="message">A message describing the API error.</param>
		public LitEroticaApiException(string message) : base(message) { }
	}

	/// <summary>
	/// Represents an error response returned by the Literotica API.
	/// </summary>
	public record Error(
		[property: JsonPropertyName("success")] bool? Success,
		[property: JsonPropertyName("message")] string Message
	);

	/// <summary>
	/// Contains common Literotica API enumerations and type definitions.
	/// </summary>
	public static class Types
	{
		/// <summary>
		/// Defines the sort order for API queries.
		/// </summary>
		public enum SortType
		{
			/// <summary>
			/// Sorts items by their newest submission date.
			/// </summary>
			Newest,

			/// <summary>
			/// Sorts items alphabetically by title.
			/// </summary>
			Alphabetical
		}

		/// <summary>
		/// Defines the time period used for ranking or filtering top content.
		/// </summary>
		public enum Period
		{
			/// <summary>
			/// Weekly period.
			/// </summary>
			Week,

			/// <summary>
			/// Monthly period.
			/// </summary>
			Month,

			/// <summary>
			/// All-time period.
			/// </summary>
			All
		}

		/// <summary>
		/// Defines the supported Literotica work types.
		/// </summary>
		public enum WorkTypes
		{
			/// <summary>
			/// Standard written story.
			/// </summary>
			Story,

			/// <summary>
			/// Poem content type.
			/// </summary>
			Poem,

			/// <summary>
			/// Audio-based content.
			/// </summary>
			Audio,

			/// <summary>
			/// Story game or interactive content.
			/// </summary>
			SG
		}

		/// <summary>
		/// Represents the various content categories available on Literotica.
		/// </summary>
		public enum Categories
		{
			/// <summary>
			/// Stories focused on romantic and sexual relationships between couples.
			/// </summary>
			EroticCouplings = 2,

			/// <summary>
			/// Essays, reviews, and opinion-based erotic or non-erotic writings.
			/// </summary>
			ReviewsEssays = 3,

			/// <summary>
			/// Exhibitionism and voyeurism themed content.
			/// </summary>
			ExhibitionistVoyeur = 4,

			/// <summary>
			/// Stories exploring fetish-based themes.
			/// </summary>
			Fetish = 5,

			/// <summary>
			/// Gay male oriented erotic stories.
			/// </summary>
			GayMale = 6,

			/// <summary>
			/// Stories involving multiple partners or group sex scenarios.
			/// </summary>
			GroupSex = 7,

			/// <summary>
			/// Informative or instructional erotic content.
			/// </summary>
			HowTo = 8,

			/// <summary>
			/// Taboo or incest-related themes.
			/// </summary>
			TabooIncest = 9,

			/// <summary>
			/// Interracial relationships and romance stories.
			/// </summary>
			InterracialLove = 10,

			/// <summary>
			/// Lesbian-themed erotic stories.
			/// </summary>
			LesbianSex = 11,

			/// <summary>
			/// Stories centered around married life and infidelity.
			/// </summary>
			LovingWives = 12,

			/// <summary>
			/// Themes of reluctance, non-consent, or forced situations.
			/// </summary>
			ReluctanceNonConsent = 13,

			/// <summary>
			/// Stories involving non-human or fantasy creatures.
			/// </summary>
			NonHuman = 14,

			/// <summary>
			/// Romance-focused erotic or emotional stories.
			/// </summary>
			Romance = 15,

			/// <summary>
			/// Masturbation or sex toy themed stories.
			/// </summary>
			ToysMasturbation = 16,

			/// <summary>
			/// Erotic poetry and sensual verse.
			/// </summary>
			EroticPoetry = 17,

			/// <summary>
			/// Stories intended for mature readers or covering mature topics.
			/// </summary>
			Mature = 26,

			/// <summary>
			/// Fan fiction or celebrity-inspired erotic stories.
			/// </summary>
			FanFictionCelebrities = 27,

			/// <summary>
			/// Collaborative or multi-author chain stories.
			/// </summary>
			ChainStories = 28,

			/// <summary>
			/// Stories centered on mind control or domination themes.
			/// </summary>
			MindControl = 29,

			/// <summary>
			/// BDSM and power exchange themed stories.
			/// </summary>
			BDSM = 31,

			/// <summary>
			/// Non-English language content.
			/// </summary>
			NonEnglish = 32,

			/// <summary>
			/// Long-form stories, novellas, or serialized works.
			/// </summary>
			NovelsandNovellas = 33,

			/// <summary>
			/// Humorous or satirical erotic stories.
			/// </summary>
			HumorSatire = 34,

			/// <summary>
			/// General fiction or non-erotic works.
			/// </summary>
			NonErotic = 35,

			/// <summary>
			/// Poetry that is non-erotic or reflective.
			/// </summary>
			NonEroticPoetry = 36,

			/// <summary>
			/// Anal sex themed stories.
			/// </summary>
			Anal = 37,

			/// <summary>
			/// Science fiction and fantasy themed erotic works.
			/// </summary>
			SciFiFantasy = 38,

			/// <summary>
			/// Audio-based erotic stories.
			/// </summary>
			Audio = 39,

			/// <summary>
			/// Stories focused on first-time sexual experiences.
			/// </summary>
			FirstTime = 40,

			/// <summary>
			/// Illustrated erotic content or artwork.
			/// </summary>
			Illustrated = 45,

			/// <summary>
			/// Poetry that includes accompanying audio.
			/// </summary>
			PoetryWithAudio = 46,

			/// <summary>
			/// Illustrated poetry combining art and verse.
			/// </summary>
			IllustratedPoetry = 47,

			/// <summary>
			/// Transgender or gender transition themed stories.
			/// </summary>
			Transgender = 48,

			/// <summary>
			/// Erotic horror, suspense, or dark-themed stories.
			/// </summary>
			EroticHorror = 51,

			/// <summary>
			/// Stories written as letters or transcripts.
			/// </summary>
			LettersTranscripts = 53,

			/// <summary>
			/// Artistic works and visual erotic content.
			/// </summary>
			EroticArt = 55,

			/// <summary>
			/// Adult comic stories or illustrated narratives.
			/// </summary>
			AdultComics = 56,

			/// <summary>
			/// Crossdressing or gender-bending themed stories.
			/// </summary>
			Crossdressing = 58
		}

		/// <summary>
		/// Supported story languages on Literotica.
		/// </summary>
		public enum Languages
		{
			/// <summary>
			/// English Language
			/// </summary>
			English = 1,

			/// <summary>
			/// Spanish Language
			/// </summary>
			/// <summary>
			/// Spanish Language.
			/// </summary>
			Spanish = 2,
			/// <summary>
			/// German Language.
			/// </summary>
			German = 3,
			/// <summary>
			/// Dutch Language.
			/// </summary>
			Dutch = 5,
			/// <summary>
			/// Italian Language.
			/// </summary>
			Italian = 6,
			/// <summary>
			/// French Language.
			/// </summary>
			French = 4,
			/// <summary>
			/// Afrikaans Language.
			/// </summary>
			Afrikaans = 9,
			/// <summary>
			/// Portuguese Language.
			/// </summary>
			Portuguese = 8,
			/// <summary>
			/// Bengali Language.
			/// </summary>
			Bengali = 10,
			/// <summary>
			/// Chinese Language.
			/// </summary>
			Chinese = 11,
			/// <summary>
			/// Danish Language.
			/// </summary>
			Danish = 12,
			/// <summary>
			/// Esperanto Language.
			/// </summary>
			Esperanto = 13,
			/// <summary>
			/// Finnish Language.
			/// </summary>
			Finnish = 14,
			/// <summary>
			/// Swedish Language.
			/// </summary>
			Swedish = 20,
			/// <summary>
			/// Malayalam Language.
			/// </summary>
			Malayalam = 23,
			/// <summary>
			/// Urdu Language.
			/// </summary>
			Urdu = 22,
			/// <summary>
			/// Hindi Language.
			/// </summary>
			Hindi = 24,
			/// <summary>
			/// Turkish Language.
			/// </summary>
			Turkish = 21,
			/// <summary>
			/// Tamil Language.
			/// </summary>
			Tamil = 26,
			/// <summary>
			/// Telugu Language.
			/// </summary>
			Telugu = 27,
			/// <summary>
			/// Serbian Language.
			/// </summary>
			Serbian = 19,
			/// <summary>
			/// Russian Language.
			/// </summary>
			Russian = 18,
			/// <summary>
			/// Norwegian Language.
			/// </summary>
			Norwegian = 16,
			/// <summary>
			/// Japanese Language.
			/// </summary>
			Japanese = 15,
			/// <summary>
			/// Polish Language.
			/// </summary>
			Polish = 17,
			/// <summary>
			/// Other Language.
			/// </summary>
			Other = 999,
			/// <summary>
			/// Marathi Language.
			/// </summary>
			Marathi = 25,
			/// <summary>
			/// Romanian Language.
			/// </summary>
			Romanian = 7,
		}

		/// <summary>
		/// Sorting options for favorite stories.
		/// </summary>
		public enum FavoriteStorySort
		{
			/// <summary>
			/// Date the story was added to favorites.
			/// </summary>
			DateAdd,

			/// <summary>
			///	Title Name of the story.
			/// </summary>
			Title,

			/// <summary>
			///	Date the story was published.
			/// </summary>
			DatePublish
		}

		/// <summary>
		/// Sorting options for editor listings.
		/// </summary>
		public enum EditorSort
		{
			/// <summary>
			/// Last activity ID of the editor.
			/// </summary>
			Last_Activity_Id,

			/// <summary>
			/// Name of the editor.
			/// </summary>
			Name,

			/// <summary>
			/// Follower count of the editor.
			/// </summary>
			Followers,

			/// <summary>
			/// Work count of the editor.
			/// </summary>
			Works
		}

		/// <summary>
		/// File formats supported by the editor.
		/// Multiple formats can be combined using bitwise flags.
		/// </summary>
		[Flags]
		public enum EditorFormats
		{
			/// <summary>
			/// Rich Text File format.
			/// </summary>
			RichTextFile,

			/// <summary>
			/// Email format.
			/// </summary>
			Email,

			/// <summary>
			/// Text File format.
			/// </summary>	
			TextFile,

			/// <summary>
			/// Word Document format.
			/// </summary>
			WordDocument
		}

		internal static int[] GetLanguageIds(Languages[]? languages)
		{
			if (languages is null || languages.Length == 0) { return [1]; }
			int[] languageIds = languages.Select(lang => (int)lang).ToArray();
			return languageIds;
		}

		internal static int[] GetCategoryIds(Categories[]? categories)
		{
			if (categories is null || categories.Length == 0) { return [1]; }
			int[] categoryIds = categories.Select(cat => (int)cat).ToArray();
			return categoryIds;
		}
	}
}
