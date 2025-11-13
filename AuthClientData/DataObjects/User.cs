using LiteroticaApi.DataObjects;

namespace LiteroticaApi.AuthClientData.DataObjects
{
	/// <summary>
	/// Represents a user's favorited story entry, including metadata such as author, category, and engagement statistics.
	/// </summary>
	public record FavoriteStoriesDatum(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("author")] Author Author,
		[property: JsonPropertyName("category")] int? Category,
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("rate_all")] double? RateAll,
		[property: JsonPropertyName("writers_pick")] bool? WritersPick,
		[property: JsonPropertyName("view_count")] int? ViewCount,
		[property: JsonPropertyName("contest_winner")] int? ContestWinner,
		[property: JsonPropertyName("allow_vote")] int? AllowVote,
		[property: JsonPropertyName("date_approve")] string DateApprove,
		[property: JsonPropertyName("language")] int? Language,
		[property: JsonPropertyName("enable_comments")] int? EnableComments,
		[property: JsonPropertyName("allow_download")] int? AllowDownload,
		[property: JsonPropertyName("comment_count")] int? CommentCount,
		[property: JsonPropertyName("favorite_count")] int? FavoriteCount,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("authorname")] string Authorname,
		[property: JsonPropertyName("url")] string Url,
		[property: JsonPropertyName("reading_lists_count")] int? ReadingListsCount,
		[property: JsonPropertyName("is_hot")] bool? IsHot,
		[property: JsonPropertyName("is_new")] bool? IsNew,
		[property: JsonPropertyName("category_info")] CategoryInfo CategoryInfo,
		[property: JsonPropertyName("date_added")] object DateAdded,
		[property: JsonPropertyName("in_list")] bool? InList
	);

	/// <summary>
	/// Represents a hyperlink reference with display label and active state.
	/// </summary>
	public record Link(
		[property: JsonPropertyName("url")] string Url,
		[property: JsonPropertyName("label")] string Label,
		[property: JsonPropertyName("active")] bool? Active
	);

	/// <summary>
	/// Contains pagination and metadata details for paginated API responses.
	/// </summary>
	public record Meta(
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("from")] int? From,
		[property: JsonPropertyName("to")] int? To,
		[property: JsonPropertyName("per_page")] int? PerPage
	);

	/// <summary>
	/// Represents a user's collection of favorite stories and related list metadata.
	/// </summary>
	public record FavoriteStories(
		[property: JsonPropertyName("list")] List List,
		[property: JsonPropertyName("works")] Works Works
	);
	
	/// <summary>
	/// Represents a paginated collection of favorite story entries.
	/// </summary>
	public record Works(
		[property: JsonPropertyName("data")] IReadOnlyList<FavoriteStoriesDatum> Data,
		[property: JsonPropertyName("links")] IReadOnlyList<Link> Links,
		[property: JsonPropertyName("meta")] Meta Meta
	);

	/// <summary>
	/// Represents beta feature flags for user account features.
	/// </summary>
	public record Beta(
		[property: JsonPropertyName("story")] bool? Story
	);

	/// <summary>
	/// Represents an individual profile fact such as height, weight, or preferences.
	/// </summary>
	public record Fact(
		[property: JsonPropertyName("field")] string Field,
		[property: JsonPropertyName("value")] string Value,
		[property: JsonPropertyName("updated_at")] string UpdatedAt,
		[property: JsonPropertyName("privacy_level")] int? PrivacyLevel
	);

	/// <summary>
	/// Represents a user's custom reading list with metadata such as title, description, and privacy settings.
	/// </summary>
	public record List(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("stories_count")] int? StoriesCount,
		[property: JsonPropertyName("submission_type")] string SubmissionType,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("urlname")] string Urlname,
		[property: JsonPropertyName("user_id")] int? UserId,
		[property: JsonPropertyName("created_at")] object CreatedAt,
		[property: JsonPropertyName("updated_at")] DateTime? UpdatedAt,
		[property: JsonPropertyName("is_private")] int? IsPrivate,
		[property: JsonPropertyName("is_deletable")] int? IsDeletable
	);

	/// <summary>
	/// Contains detailed information about the currently authenticated user session.
	/// </summary>
	public record SessionInfo(
		[property: JsonPropertyName("aim")] string Aim,
		[property: JsonPropertyName("bio")] string Bio,
		[property: JsonPropertyName("biography")] object Biography,
		[property: JsonPropertyName("comments_count")] int? CommentsCount,
		[property: JsonPropertyName("customtitle")] int? Customtitle,
		[property: JsonPropertyName("drink")] string Drink,
		[property: JsonPropertyName("editor_status")] string EditorStatus,
		[property: JsonPropertyName("followed_stories_count")] int? FollowedStoriesCount,
		[property: JsonPropertyName("followers_count")] int? FollowersCount,
		[property: JsonPropertyName("followings_count")] int? FollowingsCount,
		[property: JsonPropertyName("has_photo")] int? HasPhoto,
		[property: JsonPropertyName("homepage")] string Homepage,
		[property: JsonPropertyName("icq")] string Icq,
		[property: JsonPropertyName("joindate")] string Joindate,
		[property: JsonPropertyName("location")] object Location,
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("options")] int? Options,
		[property: JsonPropertyName("pets")] string Pets,
		[property: JsonPropertyName("smoke")] string Smoke,
		[property: JsonPropertyName("stories_count")] int? StoriesCount,
		[property: JsonPropertyName("poems_count")] int? PoemsCount,
		[property: JsonPropertyName("illustrations_count")] int? IllustrationsCount,
		[property: JsonPropertyName("audios_count")] int? AudiosCount,
		[property: JsonPropertyName("sgs_count")] int? SgsCount,
		[property: JsonPropertyName("series_count")] int? SeriesCount,
		[property: JsonPropertyName("stories_and_series_count")] int? StoriesAndSeriesCount,
		[property: JsonPropertyName("audios_and_series_count")] int? AudiosAndSeriesCount,
		[property: JsonPropertyName("poems_and_series_count")] int? PoemsAndSeriesCount,
		[property: JsonPropertyName("illustras_and_series_count")] int? IllustrasAndSeriesCount,
		[property: JsonPropertyName("sgs_and_series_count")] int? SgsAndSeriesCount,
		[property: JsonPropertyName("fav_stories_count")] int? FavStoriesCount,
		[property: JsonPropertyName("fav_poems_count")] int? FavPoemsCount,
		[property: JsonPropertyName("fav_sgs_count")] int? FavSgsCount,
		[property: JsonPropertyName("fav_artworks_count")] int? FavArtworksCount,
		[property: JsonPropertyName("fav_audios_count")] int? FavAudiosCount,
		[property: JsonPropertyName("fav_authors_count")] int? FavAuthorsCount,
		[property: JsonPropertyName("submissions_count")] int? SubmissionsCount,
		[property: JsonPropertyName("userid")] int? Userid,
		[property: JsonPropertyName("username")] string Username,
		[property: JsonPropertyName("userpic")] string Userpic,
		[property: JsonPropertyName("usertitle")] string Usertitle,
		[property: JsonPropertyName("favorites_count")] object FavoritesCount,
		[property: JsonPropertyName("last_update")] string LastUpdate,
		[property: JsonPropertyName("joindate_approx")] string JoindateApprox,
		[property: JsonPropertyName("last_update_approx")] string LastUpdateApprox,
		[property: JsonPropertyName("favorite_stories_count")] int? FavoriteStoriesCount,
		[property: JsonPropertyName("allowfeedback")] int? Allowfeedback,
		[property: JsonPropertyName("disable_all_feedback")] int? DisableAllFeedback,
		[property: JsonPropertyName("lists")] IReadOnlyList<List> Lists,
		[property: JsonPropertyName("listscontent")] IReadOnlyDictionary<string, int?>? Listscontent,
		[property: JsonPropertyName("email")] string Email,
		[property: JsonPropertyName("parentemail")] string Parentemail,
		[property: JsonPropertyName("following_ids")] IReadOnlyList<int?> FollowingIds,
		[property: JsonPropertyName("userpic_status")] string UserpicStatus,
		[property: JsonPropertyName("facts")] IReadOnlyList<Fact> Facts,
		[property: JsonPropertyName("sex")] string Sex,
		[property: JsonPropertyName("orientation")] string Orientation,
		[property: JsonPropertyName("weight")] string Weight,
		[property: JsonPropertyName("height")] string Height,
		[property: JsonPropertyName("timezoneoffset")] int? Timezoneoffset,
		[property: JsonPropertyName("lastvisit")] string Lastvisit,
		[property: JsonPropertyName("beta")] Beta Beta,
		[property: JsonPropertyName("enable_classic")] bool? EnableClassic,
		[property: JsonPropertyName("view_settings")] ViewSettings ViewSettings,
		[property: JsonPropertyName("action_executed_at")] object ActionExecutedAt
	);

	/// <summary>
	/// Represents user-specific content viewing preferences such as font, spacing, and playback rate.
	/// </summary>
	public record ViewSettings(
		[property: JsonPropertyName("font_name")] string FontName,
		[property: JsonPropertyName("font_spacing")] string FontSpacing,
		[property: JsonPropertyName("font_size")] string FontSize,
		[property: JsonPropertyName("user_theme")] string UserTheme,
		[property: JsonPropertyName("autodetect")] bool? Autodetect,
		[property: JsonPropertyName("playback_rate")] int? PlaybackRate
	);

	/// <summary>
	/// Represents an editor's capabilities, assigned languages, and related user information.
	/// </summary>
	public record EditorDatum(
		[property: JsonPropertyName("uid")] int? Uid,
		[property: JsonPropertyName("can_pasted")] int? CanPasted,
		[property: JsonPropertyName("can_txt")] int? CanTxt,
		[property: JsonPropertyName("can_rtf")] int? CanRtf,
		[property: JsonPropertyName("can_doc")] int? CanDoc,
		[property: JsonPropertyName("created")] int? Created,
		[property: JsonPropertyName("updated")] int? Updated,
		[property: JsonPropertyName("rating")] int? Rating,
		[property: JsonPropertyName("stories_editted")] int? StoriesEditted,
		[property: JsonPropertyName("categories")] IReadOnlyList<int?> Categories,
		[property: JsonPropertyName("languages")] IReadOnlyList<int?> Languages,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("other_languages")] object OtherLanguages,
		[property: JsonPropertyName("user")] User User
	);

	/// <summary>
	/// Represents a paginated list of available editors.
	/// </summary>
	public record Editors(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage,
		[property: JsonPropertyName("data")] IReadOnlyList<EditorDatum> Data
	);

	/// <summary>
	/// Represents a Literotica user with profile details, activity counts, and statistics.
	/// </summary>
	public record User(
		[property: JsonPropertyName("aim")] string Aim,
		[property: JsonPropertyName("bio")] string Bio,
		[property: JsonPropertyName("biography")] string Biography,
		[property: JsonPropertyName("comments_count")] int? CommentsCount,
		[property: JsonPropertyName("customtitle")] int? Customtitle,
		[property: JsonPropertyName("drink")] string Drink,
		[property: JsonPropertyName("editor_status")] string EditorStatus,
		[property: JsonPropertyName("followed_stories_count")] int? FollowedStoriesCount,
		[property: JsonPropertyName("followers_count")] int? FollowersCount,
		[property: JsonPropertyName("followings_count")] int? FollowingsCount,
		[property: JsonPropertyName("has_photo")] int? HasPhoto,
		[property: JsonPropertyName("homepage")] string Homepage,
		[property: JsonPropertyName("icq")] string Icq,
		[property: JsonPropertyName("joindate")] string Joindate,
		[property: JsonPropertyName("location")] string Location,
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("options")] int? Options,
		[property: JsonPropertyName("pets")] string Pets,
		[property: JsonPropertyName("smoke")] string Smoke,
		[property: JsonPropertyName("stories_count")] int? StoriesCount,
		[property: JsonPropertyName("poems_count")] int? PoemsCount,
		[property: JsonPropertyName("illustrations_count")] int? IllustrationsCount,
		[property: JsonPropertyName("audios_count")] int? AudiosCount,
		[property: JsonPropertyName("sgs_count")] int? SgsCount,
		[property: JsonPropertyName("series_count")] int? SeriesCount,
		[property: JsonPropertyName("stories_and_series_count")] int? StoriesAndSeriesCount,
		[property: JsonPropertyName("audios_and_series_count")] int? AudiosAndSeriesCount,
		[property: JsonPropertyName("poems_and_series_count")] int? PoemsAndSeriesCount,
		[property: JsonPropertyName("illustras_and_series_count")] int? IllustrasAndSeriesCount,
		[property: JsonPropertyName("sgs_and_series_count")] int? SgsAndSeriesCount,
		[property: JsonPropertyName("fav_stories_count")] int? FavStoriesCount,
		[property: JsonPropertyName("fav_poems_count")] int? FavPoemsCount,
		[property: JsonPropertyName("fav_sgs_count")] int? FavSgsCount,
		[property: JsonPropertyName("fav_artworks_count")] int? FavArtworksCount,
		[property: JsonPropertyName("fav_audios_count")] int? FavAudiosCount,
		[property: JsonPropertyName("fav_authors_count")] int? FavAuthorsCount,
		[property: JsonPropertyName("submissions_count")] int? SubmissionsCount,
		[property: JsonPropertyName("userid")] int? Userid,
		[property: JsonPropertyName("username")] string Username,
		[property: JsonPropertyName("userpic")] string Userpic,
		[property: JsonPropertyName("usertitle")] string Usertitle,
		[property: JsonPropertyName("favorites_count")] object FavoritesCount,
		[property: JsonPropertyName("last_update")] DateTime? LastUpdate,
		[property: JsonPropertyName("joindate_approx")] string JoindateApprox,
		[property: JsonPropertyName("last_update_approx")] string LastUpdateApprox,
		[property: JsonPropertyName("favorite_stories_count")] int? FavoriteStoriesCount
	);
}
