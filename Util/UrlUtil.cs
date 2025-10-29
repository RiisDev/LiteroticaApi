using LiteroticaApi.DataObjects;
using System.Text.RegularExpressions;

namespace LiteroticaApi.Util
{
	internal static class UrlUtil
	{
		internal static string GetStorySlug(string url)
		{
			string foundSlug = url;

			if (url.Contains("/s/"))
			{
				Match slugMatch = Regex.Match(url, "(?<=\\/s\\/)[^\\/]+", RegexOptions.Singleline | RegexOptions.Compiled);
				if (slugMatch.Success) 
					foundSlug = slugMatch.Value;
			}
			else if (url.Contains("/story/"))
			{
				Match slugMatch = Regex.Match(url, "(?<=\\/story\\/)[^\\/]+", RegexOptions.Singleline | RegexOptions.Compiled);
				if (slugMatch.Success)
					foundSlug = slugMatch.Value;
			}
			else if (url.Contains("/stories/"))
			{
				Match slugMatch = Regex.Match(url, "(?<=\\/stories\\/)[^\\/]+", RegexOptions.Singleline | RegexOptions.Compiled);
				if (slugMatch.Success) 
					foundSlug = slugMatch.Value;
			}

			foundSlug = foundSlug.Trim().Trim('/');

			if (string.IsNullOrEmpty(foundSlug) || !VerifySlug(foundSlug).Result)
				throw new Exception($"{foundSlug} is an invalid story.");

			return foundSlug;
		}

		internal static string GetSeriesId(string url)
		{
			string foundSlug = url;

			if (url.Contains("/se/"))
			{
				Match slugMatch = Regex.Match(url, "(?<=\\/se\\/)[^\\/]+", RegexOptions.Singleline | RegexOptions.Compiled);
				if (slugMatch.Success)
					foundSlug = slugMatch.Value;
			}

			foundSlug = foundSlug.Trim().Trim('/');

			if (!long.TryParse(foundSlug, out long _) || string.IsNullOrEmpty(foundSlug) || !VerifySeries(foundSlug).Result)
				throw new Exception($"{foundSlug} is an invalid series.");

			return foundSlug;
		}

		private static async Task<bool> VerifySlug(string? slug)
		{
			HttpResponseMessage? responseMessage = await Client.HttpClientInstance.SendAsync(new HttpRequestMessage(HttpMethod.Head, $"https://literotica.com/api/3/stories/{slug}"));
			return responseMessage.IsSuccessStatusCode;
		}

		private static async Task<bool> VerifySeries(string? slug)
		{
			HttpResponseMessage? responseMessage = await Client.HttpClientInstance.SendAsync(new HttpRequestMessage(HttpMethod.Head, $"https://literotica.com/api/3/series/{slug}"));
			return responseMessage.IsSuccessStatusCode;
		}

	}
}
