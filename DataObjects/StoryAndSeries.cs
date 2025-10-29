namespace LiteroticaApi.DataObjects
{
	public record CategoryInfo(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("name")] string Name,
		[property: JsonPropertyName("ldesc")] string Ldesc,
		[property: JsonPropertyName("sdesc")] string Sdesc,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("pageUrl")] string PageUrl
	);

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

	public record WorksData(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage,
		[property: JsonPropertyName("has_series")] bool? HasSeries,
		[property: JsonPropertyName("data")] IReadOnlyList<StoryDatum> Data
	);

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
