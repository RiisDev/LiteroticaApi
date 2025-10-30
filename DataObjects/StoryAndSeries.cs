namespace LiteroticaApi.DataObjects
{
	/// <summary>
	/// Represents information about a story category, including its name, description, and type.
	/// </summary>
	public record CategoryInfo(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("name")] string Name,
		[property: JsonPropertyName("ldesc")] string Ldesc,
		[property: JsonPropertyName("sdesc")] string Sdesc,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("pageUrl")] string PageUrl
	);

	/// <summary>
	/// Represents detailed metadata and content information for a story or work, including author and category data.
	/// </summary>
	public record StoryDatum(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("user_id")] int? UserId,
		[property: JsonPropertyName("url")] string Url,
		[property: JsonPropertyName("created_at")] DateTime? CreatedAt,
		[property: JsonPropertyName("modified_at")] DateTime? ModifiedAt,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("language")] int? Language,
		[property: JsonPropertyName("state")] string State,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("view_count")] int? ViewCount,
		[property: JsonPropertyName("comments_count")] int? CommentsCount,
		[property: JsonPropertyName("favorites_count")] int? FavoritesCount,
		[property: JsonPropertyName("lists_count")] int? ListsCount,
		[property: JsonPropertyName("work_count")] int? WorkCount,
		[property: JsonPropertyName("parts")] IReadOnlyList<Part>? Parts,
		[property: JsonPropertyName("allow_vote")] int? AllowVote,
		[property: JsonPropertyName("allow_download")] int? AllowDownload,
		[property: JsonPropertyName("author")] Author Author,
		[property: JsonPropertyName("authorname")] string Authorname,
		[property: JsonPropertyName("category_info")] CategoryInfo CategoryInfo,
		[property: JsonPropertyName("category")] int? Category,
		[property: JsonPropertyName("comment_count")] int? CommentCount,
		[property: JsonPropertyName("contest_winner")] int? ContestWinner,
		[property: JsonPropertyName("date_approve")] string DateApprove,
		[property: JsonPropertyName("enable_comments")] int? EnableComments,
		[property: JsonPropertyName("favorite_count")] int? FavoriteCount,
		[property: JsonPropertyName("is_hot")] bool? IsHot,
		[property: JsonPropertyName("is_new")] bool? IsNew,
		[property: JsonPropertyName("newlanguage")] int? Newlanguage,
		[property: JsonPropertyName("rank")] string? Rank,
		[property: JsonPropertyName("rate_all")] double? RateAll,
		[property: JsonPropertyName("reading_lists_count")] int? ReadingListsCount,
		[property: JsonPropertyName("tags")] IReadOnlyList<Tag>? Tags,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("writers_pick")] bool? WritersPick,
		[property: JsonPropertyName("status")] string Status
	);

	/// <summary>
	/// Represents an individual part or chapter of a story, including metadata such as title, category, and view count.
	/// </summary>
	public record Part(
		[property: JsonPropertyName("allow_vote")] int? AllowVote,
		[property: JsonPropertyName("allow_download")] int? AllowDownload,
		[property: JsonPropertyName("authorname")] string Authorname,
		[property: JsonPropertyName("category_info")] CategoryInfo CategoryInfo,
		[property: JsonPropertyName("category")] int? Category,
		[property: JsonPropertyName("contest_winner")] int? ContestWinner,
		[property: JsonPropertyName("date_approve")] string DateApprove,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("enable_comments")] int? EnableComments,
		[property: JsonPropertyName("favorite_count")] int? FavoriteCount,
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("is_hot")] bool? IsHot,
		[property: JsonPropertyName("is_new")] bool? IsNew,
		[property: JsonPropertyName("language")] int? Language,
		[property: JsonPropertyName("rate_all")] double? RateAll,
		[property: JsonPropertyName("reading_lists_count")] int? ReadingListsCount,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("url")] string Url,
		[property: JsonPropertyName("view_count")] int? ViewCount,
		[property: JsonPropertyName("writers_pick")] bool? WritersPick,
		[property: JsonPropertyName("comment_count")] int? CommentCount
	);

	/// <summary>
	/// Represents paginated data containing multiple stories or works, including series indicators and metadata.
	/// </summary>
	public record WorksData(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage,
		[property: JsonPropertyName("has_series")] bool? HasSeries,
		[property: JsonPropertyName("data")] IReadOnlyList<StoryDatum> Data
	);

	/// <summary>
	/// Represents a series of related stories or works, including parts, metadata, and creation details.
	/// </summary>
	public record Series(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("user_id")] int? UserId,
		[property: JsonPropertyName("url")] string Url,
		[property: JsonPropertyName("created_at")] DateTime? CreatedAt,
		[property: JsonPropertyName("modified_at")] DateTime? ModifiedAt,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("language")] int? Language,
		[property: JsonPropertyName("state")] string State,
		[property: JsonPropertyName("description")] object Description,
		[property: JsonPropertyName("view_count")] int? ViewCount,
		[property: JsonPropertyName("comments_count")] int? CommentsCount,
		[property: JsonPropertyName("favorites_count")] int? FavoritesCount,
		[property: JsonPropertyName("lists_count")] int? ListsCount,
		[property: JsonPropertyName("work_count")] int? WorkCount,
		[property: JsonPropertyName("parts")] IReadOnlyList<Part> Parts
	);

	/// <summary>
	/// Represents a full story entity, including author data, metadata, and its relation to series or collections.
	/// </summary>
	public record Story(
		[property: JsonPropertyName("allow_vote")] int? AllowVote,
		[property: JsonPropertyName("allow_download")] int? AllowDownload,
		[property: JsonPropertyName("author")] Author Author,
		[property: JsonPropertyName("authorname")] string Authorname,
		[property: JsonPropertyName("category_info")] CategoryInfo CategoryInfo,
		[property: JsonPropertyName("category")] int? Category,
		[property: JsonPropertyName("comment_count")] int? CommentCount,
		[property: JsonPropertyName("contest_winner")] int? ContestWinner,
		[property: JsonPropertyName("date_approve")] string DateApprove,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("enable_comments")] int? EnableComments,
		[property: JsonPropertyName("favorite_count")] int? FavoriteCount,
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("is_hot")] bool? IsHot,
		[property: JsonPropertyName("is_new")] bool? IsNew,
		[property: JsonPropertyName("language")] int? Language,
		[property: JsonPropertyName("newlanguage")] int? Newlanguage,
		[property: JsonPropertyName("rank")] string? Rank,
		[property: JsonPropertyName("rate_all")] double? RateAll,
		[property: JsonPropertyName("reading_lists_count")] int? ReadingListsCount,
		[property: JsonPropertyName("tags")] IReadOnlyList<Tag>? Tags,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("url")] string Url,
		[property: JsonPropertyName("view_count")] int? ViewCount,
		[property: JsonPropertyName("writers_pick")] bool? WritersPick,
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("series_count")] int? SeriesCount
	);
}
