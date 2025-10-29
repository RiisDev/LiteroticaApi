using LiteroticaApi.DataObjects;
using LiteroticaApi.Util;

namespace LiteroticaApi.Api
{
	/// <summary>
	/// Provides asynchronous methods for retrieving stories-related data from the Literotica API.
	/// </summary>
	public static class StoryApi
	{
		internal record StoryRoot([property: JsonPropertyName("meta")] Meta Meta, [property: JsonPropertyName("submission")] object Submission, [property: JsonPropertyName("pageText")] string PageText);

		internal record Meta([property: JsonPropertyName("pages_count")] int PageCount);

		/// <summary>
		/// Retrieves the full text content of a story by its URL, including all pages.
		/// </summary>
		/// <param name="storyUrl">
		/// The full URL of the story to retrieve.  
		/// Example: <c>https://www.literotica.com/s/story-title</c>.
		/// </param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains an array of strings, where each entry represents the text content of one page.
		/// </returns>
		/// <exception cref="Exception">
		/// Thrown if the story cannot be parsed or retrieved from the API.
		/// </exception>
		public static async Task<string[]> GetStoryContentAsync(string storyUrl)
		{
			string storySlug = UrlUtil.GetStorySlug(storyUrl);
			List<string> pages = [];

			StoryRoot? storyData = await Client.Get<StoryRoot>($"stories/{storySlug}",
				new Dictionary<string, object> { { "contentPage", 1 } }).ConfigureAwait(false);
			if (storyData == null)
				throw new Exception("Failed to parse story data");

			pages.Add(storyData.PageText);

			if (storyData.Meta.PageCount <= 1)
				return pages.ToArray();

			for (int page = 2; page <= storyData.Meta.PageCount; page++)
			{
				StoryRoot? pageData = await Client.Get<StoryRoot>($"stories/{storySlug}",
					new Dictionary<string, object> { { "contentPage", page } }).ConfigureAwait(false);

				if (pageData == null)
					throw new Exception($"Failed to parse story data for page {page}");

				pages.Add(pageData.PageText);
			}

			return pages.ToArray();
		}

		/// <summary>
		/// Retrieves detailed information about a specific story by its URL.
		/// </summary>
		/// <param name="seriesUrl">
		/// The URL of the story to retrieve information for.
		/// </param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="StoryInfo"/> object with metadata about the story, or <c>null</c> if not found.
		/// </returns>
		public static async Task<StoryInfo?> GetStoryInfoAsync(string seriesUrl)
		{
			string seriesSlug = UrlUtil.GetStorySlug(seriesUrl);
			return await Client.Get<StoryInfo>($"stories/{seriesSlug}").ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves the top favorited stories within a specified period and work type.
		/// </summary>
		/// <param name="period">The time period to filter results by, defined in <see cref="Types.Period"/>.</param>
		/// <param name="type">The work type to filter by, defined in <see cref="Types.WorkTypes"/>.</param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="pageSize">The number of results per page. Defaults to 35.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="Top"/> object with the top favorited stories.
		/// </returns>
		public static async Task<Top> GetTopFavoritedAsync(Types.Period period, Types.WorkTypes type, int page = 1, int pageSize = 35)
		{
			return await Client.Get<Top>("stories/topfavorited", new Dictionary<string, object>
			{
				{ "period", period.ToString().ToLowerInvariant() },
				{ "type", type.ToString().ToLowerInvariant() },
				{ "page", page },
				{ "pageSize", pageSize }
			}).ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves a paginated list of the newest stories for the specified period and type.
		/// </summary>
		/// <param name="period">The time period to filter by, defined in <see cref="Types.Period"/>.</param>
		/// <param name="type">The work type to filter by, defined in <see cref="Types.WorkTypes"/>.</param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="pageSize">The number of results per page. Defaults to 75.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="GetNew"/> object with the list of newest stories.
		/// </returns>
		public static async Task<GetNew> GetNewAsync(Types.Period period, Types.WorkTypes type, int page = 1, int pageSize = 75)
		{
			return await Client.Get<GetNew>("stories/new", new Dictionary<string, object>
			{
				{ "period", period.ToString().ToLowerInvariant() },
				{ "type", type.ToString().ToLowerInvariant() },
				{ "page", page },
				{ "pageSize", pageSize }
			}).ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves the top commented stories for a specific period and type.
		/// </summary>
		/// <param name="period">The time period to filter by, defined in <see cref="Types.Period"/>.</param>
		/// <param name="type">The work type to filter by, defined in <see cref="Types.WorkTypes"/>.</param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="pageSize">The number of results per page. Defaults to 15.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="Top"/> object with the top commented stories.
		/// </returns>
		public static async Task<Top> GetTopCommentedAsync(Types.Period period, Types.WorkTypes type, int page = 1, int pageSize = 15)
		{
			return await Client.Get<Top>("stories/topcommentednew", new Dictionary<string, object>
			{
				{ "period", period.ToString().ToLowerInvariant() },
				{ "type", type.ToString().ToLowerInvariant() },
				{ "page", page },
				{ "pageSize", pageSize }
			}).ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves a list of recommended stories for a given work type.
		/// </summary>
		/// <param name="type">The type of work to retrieve recommendations for, defined in <see cref="Types.WorkTypes"/>.</param>
		/// <param name="limit">The maximum number of recommended stories to retrieve. Defaults to 10.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a list of <see cref="Submission"/> objects representing recommended stories.
		/// </returns>
		public static async Task<List<Submission>> GetRecommendedAsync(Types.WorkTypes type, int limit = 10)
		{
			return await Client.Get<List<Submission>>("stories/recommended", new Dictionary<string, object>
			{
				{ "type", type.ToString().ToLowerInvariant() },
				{ "limit", limit }
			}).ConfigureAwait(false);
		}

		/// <summary>
		/// Searches for stories by keyword, with optional filters for categories, type, and other attributes.
		/// </summary>
		/// <param name="query">The search query string.</param>
		/// <param name="categories">An array of categories to filter results by.</param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="type">Optional work type filter, defined in <see cref="Types.WorkTypes"/>.</param>
		/// <param name="editorsChoice">If true, limits results to editor's choice stories.</param>
		/// <param name="popular">If true, limits results to popular stories.</param>
		/// <param name="winner">If true, limits results to contest-winning stories.</param>
		/// <param name="languages">Optional array of language IDs. Defaults to English (1).</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="Search"/> object with paginated search results.
		/// </returns>
		public static async Task<Search> SearchForStoriesAsync(string query, Types.Categories[] categories, int page = 1, Types.WorkTypes? type = null, bool editorsChoice = false, bool popular = false, bool winner = false, int[]? languages = null)
		{
			return await Client.Get<Search>("search/stories", new Dictionary<string, object?>
			{
				{ "q", query },
				{ "page", page },
				{ "categories", categories.Select(c => (int)c).ToArray() },
				{ "editorsChoice", editorsChoice },
				{ "popular", popular },
				{ "winner", winner },
				{ "languages", languages ?? [1] },
				{ "type", type?.ToString().ToLowerInvariant() }
			}).ConfigureAwait(false);
		}

		/// <summary>
		/// Searches for stories that match one or more specified tag IDs.
		/// </summary>
		/// <param name="tagIds">An array of tag IDs to filter by.</param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="pageSize">The number of results per page. Defaults to 100.</param>
		/// <param name="period">The time period to filter results by, defined in <see cref="Types.Period"/>.</param>
		/// <param name="periodCheck">Determines whether to apply period filtering. Defaults to true.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="SearchByTag"/> object with matching stories.
		/// </returns>
		public static async Task<SearchByTag> SearchForStoriesByTagsAsync(int[] tagIds, int page = 1, int pageSize = 100, Types.Period period = Types.Period.All, bool periodCheck = true)
		{
			return await Client.Get<SearchByTag>("tagsportal/stories", new Dictionary<string, object>
			{
				{ "tags", tagIds },
				{ "page", page },
				{ "pageSize", pageSize },
				{ "period", period.ToString().ToLowerInvariant() },
				{ "periodCheck", periodCheck }
			}).ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves a random selection of stories from the server.
		/// </summary>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a list of <see cref="StoryDetails"/> objects representing random stories.
		/// </returns>
		public static async Task<List<StoryDetails>> GetRandomStoriesAsync()
		{
			return await Client.Get<List<StoryDetails>>("tagsportal/single_submission/random", new Dictionary<string, object>
			{
				{ "limit", 10 } // Hard clamped on server end.
			}).ConfigureAwait(false);
		}

	}
}
