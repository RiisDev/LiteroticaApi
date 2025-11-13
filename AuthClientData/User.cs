using LiteroticaApi.AuthClientData.DataObjects;
using LiteroticaApi.DataObjects;
using static LiteroticaApi.Types;

namespace LiteroticaApi.AuthClientData
{
	/// <summary>
	/// Provides methods to interact with user-specific endpoints of the Literotica API.
	/// </summary>
	public class User(AuthClient client)
	{
		private readonly Dictionary<EditorFormats, string> _editorFormatMappings = new()
		{
			{ EditorFormats.RichTextFile, "can_rtf" },
			{ EditorFormats.Email, "can_pasted" },
			{ EditorFormats.TextFile, "can_txt" },
			{ EditorFormats.WordDocument, "can_doc" }
		};

		/// <summary>
		/// Retrieves the current session information for the authenticated user.
		/// </summary>
		/// <returns>
		/// A <see cref="SessionInfo"/> object containing user session data if available; otherwise, <see langword="null"/>.
		/// </returns>
		public async Task<SessionInfo?> GetSessionAsync() => await client.GetAsync<SessionInfo>("users/session");

		/// <summary>
		/// Retrieves all lists associated with the authenticated user.
		/// </summary>
		/// <returns>
		/// A read-only list of <see cref="List"/> objects representing the user’s story collections or lists; 
		/// </returns>
		public async Task<IReadOnlyList<List>?> GetListsAsync() => await client.GetAsync<IReadOnlyList<List>>("my/lists");

		/// <summary>
		/// Retrieves a list of authors that the authenticated user is following.
		/// </summary>
		/// <returns>
		/// A read-only list of <see cref="Author"/> objects representing followed authors; 
		/// </returns>
		public async Task<IReadOnlyList<Author>?> GetFollowingAsync() => await client.GetAsync<IReadOnlyList<Author>>("my/favorite/authors");

		/// <summary>
		/// Retrieves a list of users following the authenticated user.
		/// </summary>
		/// <returns>
		/// A read-only list of <see cref="Author"/> objects representing followers; 
		/// </returns>
		public async Task<IReadOnlyList<Author>?> GetFollowersAsync() => await client.GetAsync<IReadOnlyList<Author>>("my/followers");

		/// <summary>
		/// Retrieves the authenticated user's favorite stories, optionally filtered by page and sort order.
		/// </summary>
		/// <param name="page">The page number to retrieve (default is 1).</param>
		/// <param name="sortBy">The sorting method to use (default is <see cref="FavoriteStorySort.DateAdd"/>).</param>
		/// <returns>
		/// A <see cref="FavoriteStories"/> object containing paginated story data; 
		/// </returns>
		public async Task<FavoriteStories?> GetFavoriteStoriesAsync(int page = 1, FavoriteStorySort sortBy = FavoriteStorySort.DateAdd) 
			=> await client.GetAsync<FavoriteStories>("my/lists/favorite-stories", new Dictionary<string, object>
		{
			{"page", page},
			{"sort", sortBy.ToString().ToLowerInvariant()}
		});

		/// <summary>
		/// Retrieves a paginated list of available editors with optional sorting and filtering criteria.
		/// </summary>
		/// <param name="page">The page number to retrieve (default is 1).</param>
		/// <param name="sort">Optional sorting method for editor results (e.g. <see cref="EditorSort.Followers"/>).</param>
		/// <param name="categories">Optional category filters based on <see cref="Categories"/> values.</param>
		/// <param name="languages">Optional language filters based on <see cref="Languages"/> values.</param>
		/// <param name="formats">Optional filter for supported editor formats, using <see cref="EditorFormats"/> flags.</param>
		/// <returns>
		/// An <see cref="Editors"/> object containing paginated editor results; 
		/// </returns>
		public async Task<Editors?> GetAvailableEditorsAsync(int page = 1, EditorSort? sort = null, Categories[]? categories = null, Languages[]? languages = null, EditorFormats? formats = null)
		{
			Dictionary<string, object> paramsData = new ()
			{
				{ "page", page },
				{ "sort", sort is null ? "last_activity_id" : sort.ToString().ToLowerInvariant() }
			};

			if (categories is not null && categories.Length > 0) paramsData.Add("categories", GetCategoryIds(categories));
			if (languages is not null && languages.Length > 0) paramsData.Add("languages", GetLanguageIds(languages));

			if (formats is not null)
			{
				List<string> formatParams = [];
				formatParams.AddRange(from EditorFormats format in Enum.GetValues(typeof(EditorFormats)) where formats.Value.HasFlag(format) && _editorFormatMappings.ContainsKey(format) select _editorFormatMappings[format]);
				if (formatParams.Count > 0)
				{
					paramsData.Add("formats", formatParams);
				}
			}

			return await client.GetAsync<Editors>("editors", paramsData);
		}
	}
}
