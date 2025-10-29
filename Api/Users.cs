using LiteroticaApi.DataObjects;

namespace LiteroticaApi.Api
{
	/// <summary>
	/// Provides asynchronous methods for retrieving users-related data from the Literotica API.
	/// </summary>
	public static class UsersApi
	{
		/// <summary>
		/// Retrieves a paginated list of followers for a specified author.
		/// </summary>
		/// <param name="username">The username of the author.</param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="pageSize">The number of followers per page. Defaults to 50, maximum 200.</param>
		/// <returns>
		/// A task representing the asynchronous operation. The task result contains a <see cref="Followers"/> object.
		/// </returns>
		public static async Task<Followers?> GetFollowersAsync(string username, int page = 1, int pageSize = 50)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "page", page.InternalClamp(1, int.MaxValue) },
				{ "pageSize", pageSize.InternalClamp(1, 200) },
			};

			return await Client.Get<Followers>($"users/{username}/followers", queryParams).ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves a paginated list of reading lists created by a specified author.
		/// </summary>
		/// <param name="username">The username of the author.</param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="pageSize">The number of lists per page. Defaults to 50, maximum 200.</param>
		/// <returns>
		/// A task representing the asynchronous operation. The task result contains a list of <see cref="BookList"/> objects,
		/// or <c>null</c> if no lists were found.
		/// </returns>
		public static async Task<IReadOnlyList<BookList>?> GetListsAsync(string username, int page = 1, int pageSize = 50)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "page", page.InternalClamp(1, int.MaxValue) },
				{ "pageSize", pageSize.InternalClamp(1, 200) },
			};

			return await Client.Get<IReadOnlyList<BookList>>($"users/{username}/lists", queryParams).ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves a paginated list of works that a specified user has marked as favourites.
		/// </summary>
		/// <param name="username">The username of the user whose favourite works are being retrieved.</param>
		/// <param name="workType">
		/// The type of work to retrieve.  
		/// This value is defined by <see cref="Types.WorkTypes"/> (e.g., story, series, poem, etc.).
		/// </param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="pageSize">The number of results per page. Defaults to 50, maximum 200.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="FavouriteWork"/> object that includes the user's favourite works.
		/// </returns>
		public static async Task<FavouriteWork> GetFavoritesAsync(string username, Types.WorkTypes workType, int page = 1, int pageSize = 50)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "page", page.InternalClamp(1, int.MaxValue) },
				{ "pageSize", pageSize.InternalClamp(1, 200) },
				{ "type", workType.ToString().ToLower() }
			};

			return await Client.Get<FavouriteWork> ($"users/{username}/favorite/works", queryParams).ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves a paginated list of authors that a specified user has marked as favourites.
		/// </summary>
		/// <param name="username">The username of the user whose favourite authors are being retrieved.</param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="pageSize">The number of results per page. Defaults to 50, maximum 200.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="FavouriteAuthor"/> object that includes the user's favourite authors.
		/// </returns>
		public static async Task<FavouriteAuthor> GetFavoriteAuthorsAsync(string username, int page = 1, int pageSize = 50)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "page", page.InternalClamp(1, int.MaxValue) },
				{ "pageSize", pageSize.InternalClamp(1, 200) }
			};
			return await Client.Get<FavouriteAuthor>($"users/{username}/favorite/authors", queryParams).ConfigureAwait(false);
		}
	}
}
