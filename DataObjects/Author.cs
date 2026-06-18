namespace LiteroticaApi.DataObjects
{
	/// <summary>
	/// Represents a user-created list of books or stories on Literotica, containing metadata such as title, description, and creation date.
	/// </summary>
	/// <remarks>
	/// Book lists are user-curated collections of works (stories, poems, series, etc.) that can be used for categorization, reading lists, or favorites.
	/// </remarks>
	public record BookList(
		[property: JsonPropertyName("id")] long? Id,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("stories_count")] long? StoriesCount,
		[property: JsonPropertyName("submission_type")] string SubmissionType,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("urlname")] string Urlname,
		[property: JsonPropertyName("user_id")] long? UserId,
		[property: JsonPropertyName("created_at")] string? CreatedAt,
		[property: JsonPropertyName("updated_at")] DateTime? UpdatedAt
	);

	/// <summary>
	/// Represents the root response for an author data request.
	/// </summary>
	/// <remarks>
	/// This model wraps the author object along with success status, as returned by Literotica's API.
	/// </remarks>
	public record RootAuthor(
		[property: JsonPropertyName("success")] bool? Success,
		[property: JsonPropertyName("user")] Author User
	);

	/// <summary>
	/// Represents an author profile on Literotica, including biography, statistics, and personal attributes.
	/// </summary>
	/// <remarks>
	/// Contains detailed metadata such as follower counts, story counts, favorite works, and optional personal information
	/// like location, orientation, and interests.
	/// </remarks>
	public record Author(
		[property: JsonPropertyName("aim")] string Aim,
		[property: JsonPropertyName("bio")] string Bio,
		[property: JsonPropertyName("biography")] string? Biography,
		[property: JsonPropertyName("comments_count")] long? CommentsCount,
		[property: JsonPropertyName("customtitle")] long? Customtitle,
		[property: JsonPropertyName("drink")] string Drink,
		[property: JsonPropertyName("editor_status")] string EditorStatus,
		[property: JsonPropertyName("followed_stories_count")] long? FollowedStoriesCount,
		[property: JsonPropertyName("followers_count")] long? FollowersCount,
		[property: JsonPropertyName("followings_count")] long? FollowingsCount,
		[property: JsonPropertyName("has_photo")] long? HasPhoto,
		[property: JsonPropertyName("homepage")] string Homepage,
		[property: JsonPropertyName("icq")] dynamic Icq,
		[property: JsonPropertyName("joindate")] string Joindate,
		[property: JsonPropertyName("location")] string Location,
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("options")] long? Options,
		[property: JsonPropertyName("pets")] string Pets,
		[property: JsonPropertyName("smoke")] string Smoke,
		[property: JsonPropertyName("stories_count")] long? StoriesCount,
		[property: JsonPropertyName("poems_count")] long? PoemsCount,
		[property: JsonPropertyName("illustrations_count")] long? IllustrationsCount,
		[property: JsonPropertyName("audios_count")] long? AudiosCount,
		[property: JsonPropertyName("sgs_count")] long? SgsCount,
		[property: JsonPropertyName("series_count")] long? SeriesCount,
		[property: JsonPropertyName("stories_and_series_count")] long? StoriesAndSeriesCount,
		[property: JsonPropertyName("audios_and_series_count")] long? AudiosAndSeriesCount,
		[property: JsonPropertyName("poems_and_series_count")] long? PoemsAndSeriesCount,
		[property: JsonPropertyName("illustras_and_series_count")] long? IllustrasAndSeriesCount,
		[property: JsonPropertyName("sgs_and_series_count")] long? SgsAndSeriesCount,
		[property: JsonPropertyName("fav_stories_count")] long? FavStoriesCount,
		[property: JsonPropertyName("fav_poems_count")] long? FavPoemsCount,
		[property: JsonPropertyName("fav_sgs_count")] long? FavSgsCount,
		[property: JsonPropertyName("fav_artworks_count")] long? FavArtworksCount,
		[property: JsonPropertyName("fav_audios_count")] long? FavAudiosCount,
		[property: JsonPropertyName("fav_authors_count")] long? FavAuthorsCount,
		[property: JsonPropertyName("submissions_count")] long? SubmissionsCount,
		[property: JsonPropertyName("userid")] long? Userid,
		[property: JsonPropertyName("username"), JsonConverter(typeof(StringOrIntConverter))] StringOrInt Username,
		[property: JsonPropertyName("userpic")] string Userpic,
		[property: JsonPropertyName("usertitle")] string Usertitle,
		[property: JsonPropertyName("favorites_count")] long? FavoritesCount,
		[property: JsonPropertyName("last_update")] DateTime? LastUpdate,
		[property: JsonPropertyName("joindate_approx")] string JoindateApprox,
		[property: JsonPropertyName("last_update_approx")] string LastUpdateApprox,
		[property: JsonPropertyName("favorite_stories_count")] long? FavoriteStoriesCount,
		[property: JsonPropertyName("sex")] string? Sex,
		[property: JsonPropertyName("weight")] string? Weight,
		[property: JsonPropertyName("height")] string? Height,
		[property: JsonPropertyName("orientation")] string? Orientation,
		[property: JsonPropertyName("interests")] string? Interests,
		[property: JsonPropertyName("fetishes")] string? Fetishes,
		[property: JsonPropertyName("datingstat")] string? Datingstat,
		[property: JsonPropertyName("allowfeedback")] long? Allowfeedback,
		[property: JsonPropertyName("disable_all_feedback")] long? DisableAllFeedback,
		[property: JsonPropertyName("lists")] IReadOnlyList<BookList>? Lists,
		[property: JsonPropertyName("listscontent")] object? ListsContent,
		[property: JsonPropertyName("support_me_service")] string? SupportMeService,
		[property: JsonPropertyName("support_me_link")] string? SupportMeLink
	);

	/// <summary>
	/// Represents a paginated collection of users who follow a specific author.
	/// </summary>
	public record Followers(
		[property: JsonPropertyName("current_page")] long? CurrentPage,
		[property: JsonPropertyName("last_page")] long? LastPage,
		[property: JsonPropertyName("total")] long? Total,
		[property: JsonPropertyName("per_page")] long? PerPage,
		[property: JsonPropertyName("data")] IReadOnlyList<Author> Data
	);

	/// <summary>
	/// Represents a paginated list of authors marked as favorites by a user.
	/// </summary>
	public record FavouriteAuthor(
		[property: JsonPropertyName("current_page")] long? CurrentPage,
		[property: JsonPropertyName("last_page")] long? LastPage,
		[property: JsonPropertyName("total")] long? Total,
		[property: JsonPropertyName("per_page")] long? PerPage,
		[property: JsonPropertyName("data")] IReadOnlyList<Author> Data
	);

	/// <summary>
	/// Represents a paginated list of favorite works, such as stories, poems, or series.
	/// </summary>
	public record FavouriteWork(
		[property: JsonPropertyName("current_page")] long? CurrentPage,
		[property: JsonPropertyName("last_page")] long? LastPage,
		[property: JsonPropertyName("total")] long? Total,
		[property: JsonPropertyName("per_page")] long? PerPage,
		[property: JsonPropertyName("data")] IReadOnlyList<Story> Data
	);

	/// <summary>
	/// Represents the response for a top-followed authors request.
	/// </summary>
	public record TopFollowedAuthorsResponse(
		[property: JsonPropertyName("data")] TopFollowedAuthor Data
	);

	/// <summary>
	/// Represents a paginated list of the most-followed authors on Literotica.
	/// </summary>
	public record TopFollowedAuthor(
		[property: JsonPropertyName("current_page")] long? CurrentPage,
		[property: JsonPropertyName("last_page")] long? LastPage,
		[property: JsonPropertyName("total")] long? Total,
		[property: JsonPropertyName("per_page")] long? PerPage,
		[property: JsonPropertyName("data")] IReadOnlyList<Author> Data
	);

	/// <summary>
	/// Represents a collection of newly registered or recently active authors.
	/// </summary>
	public record NewAuthors(
		[property: JsonPropertyName("data")] IReadOnlyList<Author> Data
	);
}
