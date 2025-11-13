
using LiteroticaApi.DataObjects;

namespace LiteroticaApi.Api
{
	/// <summary>
	/// Provides asynchronous methods for retrieving tags-related data from the Literotica API.
	/// </summary>
	public static class TagsApi
	{
		/// <summary>
		/// Retrieves a list of tags that are related to the specified tag IDs.
		/// </summary>
		/// <param name="tagIds">An array of tag IDs for which to retrieve related tags.</param>
		/// <param name="period">
		/// The time period to filter by, defined in <see cref="Types.Period"/>.  
		/// Defaults to <see cref="Types.Period.All"/>.
		/// </param>
		/// <param name="language">The language.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a list of <see cref="RelatedTag"/> objects
		/// that are related to the specified tags.
		/// </returns>
		public static async Task<List<RelatedTag>> GetRelatedTagsAsync(int[] tagIds, Types.Period period = Types.Period.All, Types.Languages language = Types.Languages.English)
		{
			return await Client.Get<List<RelatedTag>>("tagsportal/related", new Dictionary<string, object>
			{
				{ "tags", tagIds },
				{ "period", period.ToString().ToLowerInvariant() },
				{ "language", (int)language }
			}).ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves the most popular (top) tags within a specified category.
		/// </summary>
		/// <param name="category">
		/// The category to filter results by, defined in <see cref="Types.Categories"/>.
		/// </param>
		/// <param name="limit">
		/// The maximum number of tags to retrieve.  
		/// Defaults to <c>500</c>.
		/// </param>
		/// <param name="periodCheck">
		/// A value indicating whether the tag ranking should be period-sensitive.  
		/// Defaults to <c>true</c>.
		/// </param>
		/// <param name="period">
		/// The time period to evaluate, defined in <see cref="Types.Period"/>.  
		/// Defaults to <see cref="Types.Period.All"/>.
		/// </param>
		/// <param name="language">The language.</param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a <see cref="TopTags"/> object with metadata about the most popular tags.
		/// </returns>
		public static async Task<TopTags> GetTopTagsAsync(Types.Categories category, int limit = 500, bool periodCheck = true, Types.Period period = Types.Period.All, Types.Languages language = Types.Languages.English)
		{
			return await Client.Get<TopTags>("tagsportal/top", new Dictionary<string, object>
			{
				{ "limit", limit },
				{ "periodCheck", periodCheck },
				{ "category", (int)category },
				{ "period", period.ToString().ToLowerInvariant() },
				{ "language", (int)language }
			}).ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves tag metadata based on an array of tag names.
		/// </summary>
		/// <param name="tags">
		/// An array of tag names for which to retrieve tag ID and metadata.
		/// </param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a list of <see cref="Tag"/> objects corresponding to the specified tag names.
		/// </returns>
		public static async Task<List<Tag>> GetTagIdFromNameAsync(string[] tags)
		{
			return await Client.Get<List<Tag>>("tagsportal/by-name", new Dictionary<string, object>
			{
				{ "tags", tags }
			}).ConfigureAwait(false);
		}

		/// <summary>
		/// Retrieves all available story categories for the specified time period.
		/// </summary>
		/// <param name="period">
		/// The time period to filter by, defined in <see cref="Types.Period"/>.
		/// </param>
		/// <returns>
		/// A task representing the asynchronous operation.  
		/// The task result contains a list of <see cref="CategoryReturn"/> objects representing story categories.
		/// </returns>
		public static async Task<List<CategoryReturn>> GetCategoriesAsync(Types.Period period)
		{
			return await Client.Get<List<CategoryReturn>>("stories/categories", new Dictionary<string, object>
			{
				{ "period", period.ToString().ToLowerInvariant() },
				{ "include_pd", true }
			}).ConfigureAwait(false);
		}

	}
}
