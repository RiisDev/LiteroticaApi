using LiteroticaApi.DataObjects;
using static LiteroticaApi.Types;

namespace LiteroticaApi.Api
{
	/// <summary>
	/// Provides asynchronous methods for retrieving author-related data from the Literotica API.
	/// </summary>
	public static class AuthorsApi
	{
		/// <summary>
		/// Retrieves an <see cref="Author"/> by their numeric author ID.
		/// </summary>
		/// <param name="authorId">The unique identifier of the author.</param>
		/// <returns>
		/// A task representing the asynchronous operation. The task result contains the <see cref="Author"/> object,
		/// or <c>null</c> if the author could not be found.
		/// </returns>
		/// <exception cref="LitEroticaApiException">Thrown when the API response contains null or invalid data.</exception>
		public static async Task<Author?> GetAuthorByIdAsync(int authorId)
		{
			List<InternalAuthor>? authorData = await Client.Get<List<InternalAuthor>>($"authors/{authorId}").ConfigureAwait(false);
			
			if (authorData?.Count == 0 || string.IsNullOrEmpty(authorData?[0].Username))
				throw new LitEroticaApiException("Username data is null.");

			RootAuthor? rootAuthor = await Client.Get<RootAuthor>($"users/{authorData?[0].Username}").ConfigureAwait(false);
			return rootAuthor?.User;
		}

		/// <summary>
		/// Retrieves an <see cref="Author"/> by their username.
		/// </summary>
		/// <param name="username">The username of the author.</param>
		/// <returns>
		/// A task representing the asynchronous operation. The task result contains the <see cref="Author"/> object,
		/// or <c>null</c> if the author does not exist.
		/// </returns>
		public static async Task<Author?> GetAuthorByUsernameAsync(string username) =>
			(await Client.Get<RootAuthor>($"users/{username}").ConfigureAwait(false))?.User;

		/// <summary>
		/// Retrieves a paginated list of an author's works, such as stories and series.
		/// </summary>
		/// <param name="username">The username of the author.</param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="pageSize">The number of items per page. Defaults to 150, maximum 500.</param>
		/// <param name="sortType">The sorting order (alphabetical or by newest). Defaults to alphabetical.</param>
		/// <returns>
		/// A task representing the asynchronous operation. The task result contains a <see cref="WorksData"/> object
		/// with the author's works, or <c>null</c> if no data was found.
		/// </returns>
		public static async Task<WorksData?> GetWorksAsync(string username, int page = 1, int pageSize = 150, SortType sortType = SortType.Alphabetical)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "page", page.InternalClamp(1, int.MaxValue) },
				{ "pageSize", pageSize.InternalClamp(1, 500) },
				{ "listType", "expanded" }
			};

			switch (sortType)
			{
				case SortType.Newest:
					queryParams.Add("sort", "date");
					break;
				case SortType.Alphabetical:
					queryParams.Add("sort", "title");
					break;
			}

			WorksData? worksData = await Client.Get<WorksData>($"users/{username}/series_and_works", queryParams).ConfigureAwait(false);
			return worksData;
		}

		/// <summary>
		/// Retrieves all works (stories and series) by an author across all pages.
		/// </summary>
		/// <param name="username">The username of the author.</param>
		/// <returns>
		/// A task representing the asynchronous operation. The task result contains a list of <see cref="StoryDatum"/> objects.
		/// </returns>
		public static async Task<IReadOnlyList<StoryDatum>> GetAllWorksAsync(string username)
		{
			List<StoryDatum> storyData = [];
			WorksData? worksData = await GetWorksAsync(username, 1, 500).ConfigureAwait(false);

			if (worksData?.Data != null)
				storyData.AddRange(worksData.Data);

			if (worksData?.LastPage != 1)
			{
				for (int page = 2; page <= worksData?.LastPage; page++)
				{
					WorksData? pagedWorksData = await GetWorksAsync(username, page, 500).ConfigureAwait(false);
					if (pagedWorksData?.Data != null)
						storyData.AddRange(pagedWorksData.Data);
				}
			}

			return storyData;
		}

		/// <summary>
		/// Retrieves all series authored by the specified user.
		/// </summary>
		/// <param name="username">The username of the author.</param>
		/// <returns>
		/// A task representing the asynchronous operation. The task result contains a list of <see cref="Series"/> objects,
		/// or <c>null</c> if no series were found.
		/// </returns>
		public static async Task<IReadOnlyList<Series>?> GetSeriesAsync(string username)
		{
			IReadOnlyList<StoryDatum>? storyData = await GetAllWorksAsync(username).ConfigureAwait(false);

			IReadOnlyList<Series>? seriesData = storyData?
				.Where(datum => datum.Parts is not null && datum.Parts.Count >= 1)
				.Select(datum => new Series(
					Id: datum.Id,
					UserId: datum.UserId,
					Url: datum.Url,
					CreatedAt: datum.CreatedAt,
					ModifiedAt: datum.ModifiedAt,
					Title: datum.Title,
					Language: datum.Language,
					State: datum.State,
					Description: datum.Description,
					ViewCount: datum.ViewCount,
					CommentsCount: datum.CommentsCount,
					FavoritesCount: datum.FavoritesCount,
					ListsCount: datum.ListsCount,
					WorkCount: datum.WorkCount,
					Parts: datum.Parts!
				))
				.ToList();

			return seriesData;
		}

		/// <summary>
		/// Retrieves all standalone stories by the specified user (excluding series).
		/// </summary>
		/// <param name="username">The username of the author.</param>
		/// <returns>
		/// A task representing the asynchronous operation. The task result contains a list of <see cref="Story"/> objects,
		/// or <c>null</c> if no stories were found.
		/// </returns>
		public static async Task<IReadOnlyList<Story>?> GetStoriesAsync(string username)
		{
			IReadOnlyList<StoryDatum>? storyData = await GetAllWorksAsync(username).ConfigureAwait(false);

			IReadOnlyList<Story>? storiesData = storyData?
				.Where(datum => datum.Parts is null)
				.Select(datum => new Story(
					AllowVote: datum.AllowVote,
					AllowDownload: datum.AllowDownload,
					Author: datum.Author,
					Authorname: datum.Authorname,
					CategoryInfo: datum.CategoryInfo,
					Category: datum.Category,
					CommentCount: datum.CommentCount,
					ContestWinner: datum.ContestWinner,
					DateApprove: datum.DateApprove,
					Description: datum.Description,
					EnableComments: datum.EnableComments,
					FavoriteCount: datum.FavoriteCount,
					Id: datum.Id,
					IsHot: datum.IsHot,
					IsNew: datum.IsNew,
					Language: datum.Language,
					Newlanguage: datum.Newlanguage,
					Rank: datum.Rank,
					RateAll: datum.RateAll,
					ReadingListsCount: datum.ReadingListsCount,
					Tags: datum.Tags,
					Title: datum.Title,
					Type: datum.Type,
					Url: datum.Url,
					ViewCount: datum.ViewCount,
					WritersPick: datum.WritersPick,
					Status: datum.Status,
					SeriesCount: null
				))
				.ToList();

			return storiesData;
		}
		
		/// <summary>
		/// Retrieves a list of newly joined authors.
		/// </summary>
		/// <param name="limit">The number of authors to retrieve. Defaults to 10, maximum 100.</param>
		/// <returns>
		/// A task representing the asynchronous operation. The task result contains a <see cref="NewAuthors"/> object.
		/// </returns>
		public static async Task<NewAuthors?> GetNewAuthorsAsync(int limit = 10)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "limit", limit.InternalClamp(1, 100) }
			};
			return await Client.Get<NewAuthors>("authors/new", queryParams).ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves a paginated list of the most-followed authors.
		/// </summary>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="pageSize">The number of authors per page. Defaults to 50, maximum 200.</param>
		/// <param name="period">The time period filter (e.g., day, week, month, all). Defaults to <see cref="Period.All"/>.</param>
		/// <returns>
		/// A task representing the asynchronous operation. The task result contains a <see cref="TopFollowedAuthor"/> object.
		/// </returns>
		public static async Task<TopFollowedAuthor?> GetMostFollowedAsync(int page = 1, int pageSize = 50, Period period = Period.All)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "page", page.InternalClamp(1, int.MaxValue) },
				{ "pageSize", pageSize.InternalClamp(1, 200) },
				{ "period", period.ToString().ToLower() }
			};

			return await Client.Get<TopFollowedAuthor>("members/mostfollowed", queryParams).ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves a paginated list of the most-favourited authors.
		/// </summary>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <param name="pageSize">The number of authors per page. Defaults to 50, maximum 200.</param>
		/// <param name="period">The time period filter (e.g., day, week, month, all). Defaults to <see cref="Period.All"/>.</param>
		/// <param name="language">The language ID. Defaults to 1/>.</param>
		/// <returns>
		/// A task representing the asynchronous operation. The task result contains a <see cref="TopFollowedAuthor"/> object.
		/// </returns>
		public static async Task<TopFollowedAuthor?> GetMostFavoritedAsync(int page = 1, int pageSize = 50, Period period = Period.All, int language = 1)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "period", period.ToString().ToLower() },
				{ "language", language },
				{ "pageSize", pageSize.InternalClamp(1, 200) },
				{ "page", page.InternalClamp(1, int.MaxValue) }
			};

			TopFollowedAuthorsResponse? data = await Client.Get<TopFollowedAuthorsResponse>("authors/favorites-authors", queryParams).ConfigureAwait(false);
			return data.Data;
		}
	}
}
