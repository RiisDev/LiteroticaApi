
namespace LiteroticaApi.AuthClientData
{
	/// <summary>
	/// Provides access to various user activity endpoints, allowing retrieval of global, local, and author-related activities.
	/// </summary>
	/// <param name="client">The authenticated <see cref="AuthClient"/> instance used to make API requests.</param>
	public class Activity(AuthClient client)
	{
		/// <summary>
		/// Retrieves all available activity events for the authenticated user.
		/// </summary>
		/// <param name="limit">The maximum number of activity records to retrieve.</param>
		/// <returns>
		/// A <see cref="DataObjects.Activity"/> object containing a list of activity events; 
		/// </returns>
		public async Task<DataObjects.Activity?> GetAllActivityAsync(int limit = 10)
		{
			return await client.GetAsync<DataObjects.Activity>("activity/wall", new Dictionary<string, int>
			{
				{"chunked", 1},
				{"limit", limit}
			});
		}

		/// <summary>
		/// Retrieves the authenticated user's local activity (such as submissions, comments, and favorites).
		/// </summary>
		/// <param name="limit">The maximum number of activity records to retrieve.</param>
		/// <returns>
		/// A <see cref="DataObjects.Activity"/> object containing local user activity data; 
		/// </returns>
		public async Task<DataObjects.Activity?> GetLocalActivityAsync(int limit = 10)
		{
			return await client.GetAsync<DataObjects.Activity>("activity/my", new Dictionary<string, int>
			{
				{ "chunked", 1 },
				{ "limit", limit }
			});
		}

		/// <summary>
		/// Retrieves activity related to works (stories, poems, etc.) for the authenticated user.
		/// </summary>
		/// <param name="limit">The maximum number of activity records to retrieve.</param>
		/// <returns>
		/// An <see cref="object"/> representing raw work activity data from the API; 
		/// returns <see langword="null"/> if no works activity is found.
		/// </returns>
		private async Task<object?> GetWorksActivityAsync(int limit = 10) // Made private as no DataObject is defined for this endpoint yet
		{
			return await client.GetAsync<object>("activity/works", new Dictionary<string, int>
			{
				{ "chunked", 1 },
				{ "limit", limit }
			});
		}

		/// <summary>
		/// Retrieves comment-related activity for the authenticated user.
		/// </summary>
		/// <param name="limit">The maximum number of comment activity records to retrieve.</param>
		/// <returns>
		/// An <see cref="object"/> representing raw comment activity data; 
		/// </returns>
		private async Task<object?> GetCommentsActivityAsync(int limit = 10) // Made private as no DataObject is defined for this endpoint yet
		{
			return await client.GetAsync<object>("activity/comments", new Dictionary<string, int>
			{
				{ "chunked", 1 },
				{ "limit", limit }
			});
		}

		/// <summary>
		/// Retrieves activity from authors that the authenticated user follows.
		/// </summary>
		/// <param name="limit">The maximum number of followed author activity records to retrieve.</param>
		/// <returns>
		/// A <see cref="DataObjects.Activity"/> object containing activity data from followed authors; 
		/// </returns>
		public async Task<DataObjects.Activity?> GetFollowedAuthorsActivityAsync(int limit = 10)
		{
			return await client.GetAsync<DataObjects.Activity?>("activity/authors", new Dictionary<string, int>
			{
				{ "chunked", 1 },
				{ "limit", limit }
			});
		}
	}
}
