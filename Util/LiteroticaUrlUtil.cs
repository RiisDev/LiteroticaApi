using System.Text.RegularExpressions;
using LiteroticaApi.DataObjects;

namespace LiteroticaApi
{
	/// <summary>
	/// Resolves and verifies Literotica story slugs and series ids from URLs.
	/// </summary>
	public static class LiteroticaUrlUtil
	{
		private static string Extract(string url, params string[] segments)
		{
			foreach (string segment in segments)
			{
				if (!url.Contains(segment)) continue;
				Match match = Regex.Match(url, $"(?<={Regex.Escape(segment)})[^/]+", RegexOptions.Singleline);
				return match.Success ? match.Value : url;
			}
			return url;
		}

		/// <summary>
		/// Extracts and verifies the story slug from a URL (<c>/s/</c>, <c>/story/</c> or <c>/stories/</c>) or a bare slug.
		/// </summary>
		/// <exception cref="Exception">Thrown when the slug does not resolve to a story.</exception>
		public static async Task<string> GetStorySlugAsync(string url)
		{
			string slug = Extract(url, "/s/", "/story/", "/stories/").Trim().Trim('/');

			if (string.IsNullOrEmpty(slug) || !await VerifySlugAsync(slug).ConfigureAwait(false))
				throw new Exception($"{slug} is an invalid story.");

			return slug;
		}

		/// <summary>
		/// Extracts and verifies the numeric series id from a URL (<c>/se/</c>), a series slug, or an id.
		/// </summary>
		/// <exception cref="Exception">Thrown when the value does not resolve to a series.</exception>
		public static async Task<string> GetSeriesIdAsync(string url)
		{
			string slug = Extract(url, "/se/").Trim().Trim('/');

			bool exists = !string.IsNullOrEmpty(slug) && await VerifySeriesIdAsync(slug).ConfigureAwait(false);
			bool isId = long.TryParse(slug, out long seriesId);

			if (exists && !isId)
			{
				InternalSeriesRoot root = await Client.Get<InternalSeriesRoot>($"series/{slug}").ConfigureAwait(false);
				seriesId = root.Data.Id ?? -1;
			}

			if (seriesId <= 0)
				throw new Exception($"{slug} is an invalid series.");

			return seriesId.ToString();
		}

		/// <summary>Checks whether a series id or slug exists.</summary>
		public static async Task<bool> VerifySeriesIdAsync(string? seriesId)
		{
			using HttpRequestMessage request = new(HttpMethod.Head, $"https://literotica.com/api/3/series/{seriesId}");
			HttpResponseMessage response = await Client.HttpClientInstance.SendAsync(request).ConfigureAwait(false);
			return response.IsSuccessStatusCode;
		}

		/// <summary>Checks whether a story slug exists.</summary>
		public static async Task<bool> VerifySlugAsync(string? slug)
		{
			using HttpRequestMessage request = new(HttpMethod.Head, $"https://literotica.com/api/3/stories/{slug}");
			HttpResponseMessage response = await Client.HttpClientInstance.SendAsync(request).ConfigureAwait(false);
			return response.IsSuccessStatusCode;
		}
	}
}
