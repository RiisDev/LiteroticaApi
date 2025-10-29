global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Net.Http.Json;

namespace LiteroticaApi
{
	internal static class IntModification
	{
		internal static int? InternalClamp(this int? value, int min, int max) => value == null ? min : value < min ? min : value > max ? max : value;
		internal static int InternalClamp(this int value, int min, int max) => value < min ? min : value > max ? max : value;

		internal static bool IsTrue(this bool? value) => value != null && value == true;
	}
}
