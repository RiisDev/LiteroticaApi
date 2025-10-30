using LiteroticaApi.DataObjects;
using System.Text.RegularExpressions;

namespace LiteroticaApi.Util
{
	/// <summary>
	/// Provides utility methods for parsing Literotica story and series URLs
	/// and extracting identifying information such as slugs or IDs.
	/// </summary>
	public static class UrlUtil
	{
		/// <summary>
		/// Extracts the story slug from a Literotica story URL.
		/// </summary>
		/// <param name="url">The full URL of the story (e.g., <c>https://www.literotica.com/s/example-story</c>).</param>
		/// <returns>The story slug extracted from the URL (e.g., <c>example-story</c>).</returns>
		/// <exception cref="Exception">Thrown when the URL does not contain a valid or verifiable story slug.</exception>
		/// <remarks>
		/// This method supports multiple URL formats:
		/// <list type="bullet">
		///   <item><description><c>/s/{slug}</c></description></item>
		///   <item><description><c>/story/{slug}</c></description></item>
		///   <item><description><c>/stories/{slug}</c></description></item>
		/// </list>
		/// The slug is validated using <see cref="VerifySlug(string)"/>.
		/// </remarks>
		public static async Task<string> GetStorySlug(string url)
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

			if (string.IsNullOrEmpty(foundSlug) || !await VerifySlug(foundSlug).ConfigureAwait(false))
				throw new Exception($"{foundSlug} is an invalid story.");

			return foundSlug;
		}

		/// <summary>
		/// Extracts the numeric series ID from a Literotica series URL.
		/// </summary>
		/// <param name="url">The full URL of the series (e.g., <c>https://www.literotica.com/se/12345</c>).</param>
		/// <returns>The series ID extracted from the URL.</returns>
		/// <exception cref="Exception">Thrown when the URL does not contain a valid or verifiable series ID.</exception>
		/// <remarks>
		/// The series ID is validated using <see cref="VerifySeries(string)"/>.
		/// </remarks>
		public static async Task<string> GetSeriesId(string url)
		{
			string foundSlug = url;

			if (url.Contains("/se/"))
			{
				Match slugMatch = Regex.Match(url, "(?<=\\/se\\/)[^\\/]+", RegexOptions.Singleline | RegexOptions.Compiled);
				if (slugMatch.Success)
					foundSlug = slugMatch.Value;
			}

			foundSlug = foundSlug.Trim().Trim('/');

			int seriesId = 0;
			bool seriesExist = !string.IsNullOrEmpty(foundSlug) && await VerifySeries(foundSlug);
			bool validId = !string.IsNullOrEmpty(foundSlug) && int.TryParse(foundSlug, out seriesId);

			if (seriesExist && !validId)
			{
				InternalSeriesRoot internalSeries = await Client.Get<InternalSeriesRoot>($"series/{foundSlug}");
				seriesId = internalSeries.Data.Id ?? -1;
			}

			if (seriesId <= 0)
				throw new Exception($"{foundSlug} is an invalid series.");

			foundSlug = seriesId.ToString();

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
