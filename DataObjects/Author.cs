namespace LiteroticaApi.DataObjects
{
	public record BookList(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("stories_count")] int? StoriesCount,
		[property: JsonPropertyName("submission_type")] string SubmissionType,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("urlname")] string Urlname,
		[property: JsonPropertyName("user_id")] int? UserId,
		[property: JsonPropertyName("created_at")] string? CreatedAt,
		[property: JsonPropertyName("updated_at")] DateTime? UpdatedAt
	);

	public record RootAuthor(
		[property: JsonPropertyName("success")] bool? Success,
		[property: JsonPropertyName("user")] Author User
	);

	public record Author(
		[property: JsonPropertyName("aim")] string Aim,
		[property: JsonPropertyName("bio")] string Bio,
		[property: JsonPropertyName("biography")] string? Biography,
		[property: JsonPropertyName("comments_count")] int? CommentsCount,
		[property: JsonPropertyName("customtitle")] int? Customtitle,
		[property: JsonPropertyName("drink")] string Drink,
		[property: JsonPropertyName("editor_status")] string EditorStatus,
		[property: JsonPropertyName("followed_stories_count")] int? FollowedStoriesCount,
		[property: JsonPropertyName("followers_count")] int? FollowersCount,
		[property: JsonPropertyName("followings_count")] int? FollowingsCount,
		[property: JsonPropertyName("has_photo")] int? HasPhoto,
		[property: JsonPropertyName("homepage")] string Homepage,
		[property: JsonPropertyName("icq")] dynamic Icq,
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
		[property: JsonPropertyName("username"), JsonConverter(typeof(StringOrIntConverter))] StringOrInt Username,
		[property: JsonPropertyName("userpic")] string Userpic,
		[property: JsonPropertyName("usertitle")] string Usertitle,
		[property: JsonPropertyName("favorites_count")] int? FavoritesCount,
		[property: JsonPropertyName("last_update")] DateTime? LastUpdate,
		[property: JsonPropertyName("joindate_approx")] string JoindateApprox,
		[property: JsonPropertyName("last_update_approx")] string LastUpdateApprox,
		[property: JsonPropertyName("favorite_stories_count")] int? FavoriteStoriesCount,
		[property: JsonPropertyName("sex")] string? Sex,
		[property: JsonPropertyName("weight")] string? Weight,
		[property: JsonPropertyName("height")] string? Height,
		[property: JsonPropertyName("orientation")] string? Orientation,
		[property: JsonPropertyName("interests")] string? Interests,
		[property: JsonPropertyName("fetishes")] string? Fetishes,
		[property: JsonPropertyName("datingstat")] string? Datingstat,
		[property: JsonPropertyName("allowfeedback")] int? Allowfeedback,
		[property: JsonPropertyName("disable_all_feedback")] int? DisableAllFeedback,
		[property: JsonPropertyName("lists")] IReadOnlyList<BookList>? Lists,
		[property: JsonPropertyName("listscontent")] object? ListsContent,
		[property: JsonPropertyName("support_me_service")] string? SupportMeService,
		[property: JsonPropertyName("support_me_link")] string? SupportMeLink
	);

	public record Followers(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage,
		[property: JsonPropertyName("data")] IReadOnlyList<Author> Data
	);

	public record FavouriteAuthor(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage,
		[property: JsonPropertyName("data")] IReadOnlyList<Author> Data
	);

	public record FavouriteWork(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage,
		[property: JsonPropertyName("data")] IReadOnlyList<Story> Data
	);
	public record TopFollowedAuthorsResponse(
		[property: JsonPropertyName("data")] TopFollowedAuthor Data
	);

	public record TopFollowedAuthor(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage,
		[property: JsonPropertyName("data")] IReadOnlyList<Author> Data
	);

	public record NewAuthors(
		[property: JsonPropertyName("data")] IReadOnlyList<Author> Data
	);
}
