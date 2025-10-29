
#pragma warning disable IDE0130 // Disable namespace check
namespace LiteroticaApi
{
	public class LitEroticaInternalException(string message) : Exception(message);

	public class LitEroticaApiException(string message) : Exception(message);

	public record Error(
		[property: JsonPropertyName("success")] bool? Success,
		[property: JsonPropertyName("message")] string Message
	);

	public class Types
	{
		public enum SortType
		{
			Newest,
			Alphabetical
		}

		public enum Period
		{
			Week,
			Month,
			All
		}

		public enum WorkTypes
		{
			Story,
			Poem,
			Audio,
			SG
		}

		public enum Categories
		{
			EroticCouplings = 2,
			ReviewsEssays = 3,
			ExhibitionistVoyeur = 4,
			Fetish = 5,
			GayMale = 6,
			GroupSex = 7,
			HowTo = 8,
			TabooIncest = 9,
			InterracialLove = 10,
			LesbianSex = 11,
			LovingWives = 12,
			ReluctanceNonConsent = 13,
			NonHuman = 14,
			Romance = 15,
			ToysMasturbation = 16,
			EroticPoetry = 17,
			Mature = 26,
			FanFictionCelebrities = 27,
			ChainStories = 28,
			MindControl = 29,
			BDSM = 31,
			NonEnglish = 32,
			NovelsandNovellas = 33,
			HumorSatire = 34,
			NonErotic = 35,
			NonEroticPoetry = 36,
			Anal = 37,
			SciFiFantasy = 38,
			Audio = 39,
			FirstTime = 40,
			Illustrated = 45,
			PoetryWithAudio = 46,
			IllustratedPoetry = 47,
			Transgender = 48,
			EroticHorror = 51,
			LettersTranscripts = 53,
			EroticArt = 55,
			AdultComics = 56,
			Crossdressing = 58
		}
	}
}
