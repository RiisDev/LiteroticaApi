using EpubManager.ContentSources;
using LiteroticaApi.DataObjects;

namespace LiteroticaApi.Api
{
	/// <summary>
	/// Provides asynchronous methods for retrieving comment-related data from the Literotica API.
	/// </summary>
	public static class CommentsApi
	{
		/// <summary>
		/// Retrieves a paginated list of the top commenters for a specific work type and time period.
		/// </summary>
		/// <param name="type">
		/// The type of work to retrieve top commenters for.  
		/// This value is defined by <see cref="Types.WorkTypes"/> (e.g., story, series, poem, etc.).
		/// </param>
		/// <param name="period">
		/// The time period over which to calculate top commenters, defined by <see cref="Types.Period"/>.
		/// </param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="pageSize">The number of results per page. Defaults to 20.</param>
		/// <param name="language">The language.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="TopCommenters"/> object with information about the most active commenters.
		/// </returns>
		public static async Task<TopCommenters> GetTopCommenters(Types.WorkTypes type, Types.Period period, int page = 1, int pageSize = 20, Types.Languages language = Types.Languages.English)
		{
			Dictionary<string, object> parameters = new()
			{
				{ "language", (int)language },
				{ "type", type.ToString().ToLower() },
				{ "period", period.ToString().ToLower() },
				{ "page", page },
				{ "pageSize", pageSize }
			};

			return await Client.Get<TopCommenters>("comments/topcommenters", parameters).ConfigureAwait(false); 
		}

		/// <summary>
		/// Retrieves a list of the most recent comments for a specific work type.
		/// </summary>
		/// <param name="type">
		/// The type of work to retrieve recent comments for.  
		/// This value is defined by <see cref="Types.WorkTypes"/> (e.g., story, series, poem, etc.).
		/// </param>
		/// <param name="limit">
		/// The maximum number of comments to retrieve. Defaults to 35.
		/// </param>
		/// <param name="period">
		/// The time period filter for comments, defined by <see cref="Types.Period"/>.  
		/// Defaults to <see cref="Types.Period.All"/>.
		/// </param>
		/// <param name="language">The language.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a list of <see cref="RecentComment"/> objects representing the latest comments.
		/// </returns>
		public static async Task<IReadOnlyList<RecentComment>> GetRecentComments(Types.WorkTypes type, int limit = 35, Types.Period period = Types.Period.All, Types.Languages language = Types.Languages.English)
		{
			Dictionary<string, object> parameters = new()
			{
				{ "language", (int)language },
				{ "type", type.ToString().ToLower() },
				{ "limit", limit },
				{ "period", period.ToString().ToLower() }
			};

			return await Client.Get<IReadOnlyList<RecentComment>>("comments/recent", parameters).ConfigureAwait(false); 
		}

		/// <summary>
		/// Retrieves the full comment history for a specific story, including pagination and sorting.
		/// </summary>
		/// <param name="storyUrl">
		/// The URL or slug of the story whose comment history should be retrieved.
		/// </param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="limit">The number of comments per page. Defaults to 100.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="CommentHistory"/> object that includes comment details and metadata.
		/// </returns>
		/// <exception cref="Exception">
		/// Thrown when the story slug cannot be extracted from the provided <paramref name="storyUrl"/>.
		/// </exception>
		public static async Task<CommentHistory> GetStoryComments(string storyUrl, int page = 1, int limit = 100)
		{
			Dictionary<string, object> parameters = new()
			{
				{ "page", page },
				{ "limit", limit },
				{ "sort", "created-desc" }
			};

			string storySlug = await Literotica.UrlUtil.GetStorySlugAsync(storyUrl).ConfigureAwait(false);
			return await Client.Get<CommentHistory>($"stories/{storySlug}/comments/history", parameters).ConfigureAwait(false); 
		}

	}
}
