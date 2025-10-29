using LiteroticaApi.DataObjects;
using LiteroticaApi.Util;

namespace LiteroticaApi.Api
{
	/// <summary>
	/// Provides asynchronous methods for retrieving series-related data from the Literotica API.
	/// </summary>
	public static class SeriesApi
	{
		/// <summary>
		/// Retrieves detailed information about a specific series from its URL.
		/// </summary>
		/// <param name="seriesUrl">The URL of the series to retrieve information for.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="Series"/> object with full series metadata,
		/// or <c>null</c> if the series could not be found.
		/// </returns>
		/// <exception cref="Exception">
		/// Thrown if the series URL is invalid, the author data cannot be retrieved,
		/// or the author username cannot be determined.
		/// </exception>
		public static async Task<Series?> GetSeriesInfoAsync(string seriesUrl)
		{
			string seriesId = UrlUtil.GetSeriesId(seriesUrl);
			
			InternalSeriesRoot internalSeries = await Client.Get<InternalSeriesRoot>($"series/{seriesId}").ConfigureAwait(false);

			if (internalSeries.Data.UserId == null)
				throw new Exception("Author ID is null.");

			Author? author = await AuthorsApi.GetAuthorByIdAsync(internalSeries.Data.UserId.Value).ConfigureAwait(false);
			
			if (author is null || string.IsNullOrEmpty(author.Username))
				throw new Exception("Failed to get author username from series");

			IReadOnlyList<Series>? allSeries = await AuthorsApi.GetSeriesAsync(author.Username).ConfigureAwait(false);

			return (allSeries ?? []).FirstOrDefault(series => series.Id.ToString() == seriesId);
		}

		/// <summary>
		/// Retrieves the cover image metadata for a specific series.
		/// </summary>
		/// <param name="seriesUrl">The URL of the series whose cover should be retrieved.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="Cover"/> object with the cover image details.
		/// </returns>
		/// <exception cref="Exception">Thrown if the provided <paramref name="seriesUrl"/> is invalid.</exception>
		public static async Task<Cover> GetSeriesCoverAsync(string seriesUrl)
		{
			string seriesId = UrlUtil.GetSeriesId(seriesUrl);

			return await Client.Get<Cover>($"series/{seriesId}/cover").ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves all individual works (stories) associated with a given series.
		/// </summary>
		/// <param name="seriesUrl">The URL of the series to retrieve works from.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a read-only list of <see cref="Story"/> objects
		/// that belong to the specified series.
		/// </returns>
		/// <exception cref="Exception">Thrown if the provided <paramref name="seriesUrl"/> is invalid.</exception>
		public static async Task<IReadOnlyList<Story>?> GetSeriesWorksAsync(string seriesUrl)
		{
			string seriesId = UrlUtil.GetSeriesId(seriesUrl);

			return await Client.Get<IReadOnlyList<Story>?>($"series/{seriesId}/works").ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves a list of recently updated series within the specified category.
		/// </summary>
		/// <param name="categories">The category to filter series by, defined in <see cref="Types.Categories"/>.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a read-only list of <see cref="Works"/> objects representing updated series.
		/// </returns>
		public static async Task<IReadOnlyList<Works>> GetRecentlyUpdatedAsync(Types.Categories categories)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "category_id", (int)categories }
			};

			TopInternalRoot topInternal = await Client.Get<TopInternalRoot>("series/recently-updated", queryParams).ConfigureAwait(false);
			return topInternal.Data;
		}

		/// <summary>
		/// Retrieves a list of the most discussed series within a specified category.
		/// </summary>
		/// <param name="categories">The category to filter series by, defined in <see cref="Types.Categories"/>.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a read-only list of <see cref="Works"/> objects representing active discussion series.
		/// </returns>
		public static async Task<IReadOnlyList<Works>> GetMostDiscussedAsync(Types.Categories categories)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "category_id", (int)categories }
			};

			TopInternalRoot topInternal = await Client.Get<TopInternalRoot>("series/most-discussed", queryParams).ConfigureAwait(false);
			return topInternal.Data;
		}

		/// <summary>
		/// Retrieves a list of the most favorited series within the specified category.
		/// </summary>
		/// <param name="categories">The category to filter series by, defined in <see cref="Types.Categories"/>.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a read-only list of <see cref="Works"/> objects representing favorited series.
		/// </returns>
		public static async Task<IReadOnlyList<Works>> GetMostFavoritedAsync(Types.Categories categories)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "category_id", (int)categories }
			};

			TopInternalRoot topInternal = await Client.Get<TopInternalRoot>("series/most-favorited", queryParams).ConfigureAwait(false);
			return topInternal.Data;
		}

		/// <summary>
		/// Retrieves a list of the most recently started series within the specified category.
		/// </summary>
		/// <param name="categories">The category to filter series by, defined in <see cref="Types.Categories"/>.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a read-only list of <see cref="Works"/> objects representing newly started series.
		/// </returns>
		public static async Task<IReadOnlyList<Works>> GetRecentlyStartedAsync(Types.Categories categories)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "category_id", (int)categories }
			};

			TopInternalRoot topInternal = await Client.Get<TopInternalRoot>("series/recently-started", queryParams).ConfigureAwait(false);
			return topInternal.Data;
		}

		/// <summary>
		/// Retrieves a list of the longest-running series within the specified category.
		/// </summary>
		/// <param name="categories">The category to filter series by, defined in <see cref="Types.Categories"/>.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a read-only list of <see cref="Works"/> objects representing long-running series.
		/// </returns>
		public static async Task<IReadOnlyList<Works>> GetLongestRunningAsync(Types.Categories categories)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "category_id", (int)categories }
			};

			TopInternalRoot topInternal = await Client.Get<TopInternalRoot>("series/longest-running", queryParams).ConfigureAwait(false);
			return topInternal.Data;
		}

		/// <summary>
		/// Retrieves a random selection of series within the specified category.
		/// </summary>
		/// <param name="category">The category to filter series by, defined in <see cref="Types.Categories"/>.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a read-only list of randomly selected <see cref="Works"/> objects.
		/// </returns>
		public static async Task<IReadOnlyList<Works>> GetRandomAsync(Types.Categories category)
		{
			Dictionary<string, object> queryParams = new()
			{
				{ "category_id", (int)category }
			};

			TopInternalRoot topInternal = await Client.Get<TopInternalRoot>("series/random", queryParams).ConfigureAwait(false);
			return topInternal.Data;
		}

		/// <summary>
		/// Retrieves a paginated list of series in a category sorted alphabetically by a specified starting letter.
		/// </summary>
		/// <param name="category">The category to filter series by, defined in <see cref="Types.Categories"/>.</param>
		/// <param name="letter">The first letter of the series titles to retrieve (A–Z).</param>
		/// <param name="page">The page number to retrieve. Defaults to 1.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a read-only list of <see cref="Works"/> objects that match the specified criteria.
		/// </returns>
		public static async Task<IReadOnlyList<Works>> GetSeriesBySort(Types.Categories category, char letter, int page = 1, int language = 1)
		{
			if (!char.IsLetter(letter))
				throw new ArgumentException("Letter must be between A-Z", nameof(letter));

			Dictionary<string, object> queryParams = new()
			{
				{ "category_id", (int)category },
				{ "language", language },
				{ "letter", char.ToLowerInvariant(letter) },
				{ "page", page }
			};

			TopInternalRoot topInternal = await Client.Get<TopInternalRoot>("series/alpha/series", queryParams).ConfigureAwait(false);
			return topInternal.Data;
		}

	}
}
