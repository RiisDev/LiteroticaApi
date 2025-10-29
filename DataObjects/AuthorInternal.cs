namespace LiteroticaApi.DataObjects
{
	internal record InternalAuthorList(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("user_id")] int? UserId,
		[property: JsonPropertyName("urlname")] string Urlname,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("submission_type")] string SubmissionType,
		[property: JsonPropertyName("stories_count")] int? StoriesCount
	);

	internal record InternalAuthor(
		[property: JsonPropertyName("userid")] int? Userid,
		[property: JsonPropertyName("username")] string Username,
		[property: JsonPropertyName("homepage")] string Homepage,
		[property: JsonPropertyName("icq")] string Icq,
		[property: JsonPropertyName("aim")] string Aim,
		[property: JsonPropertyName("usertitle")] string Usertitle,
		[property: JsonPropertyName("customtitle")] int? Customtitle,
		[property: JsonPropertyName("joindate")] string Joindate,
		[property: JsonPropertyName("location")] string? Location,
		[property: JsonPropertyName("smoke")] string Smoke,
		[property: JsonPropertyName("drink")] string Drink,
		[property: JsonPropertyName("pets")] string Pets,
		[property: JsonPropertyName("submissions_count")] int? SubmissionsCount,
		[property: JsonPropertyName("has_photo")] int? HasPhoto,
		[property: JsonPropertyName("options")] int? Options,
		[property: JsonPropertyName("biography")] string Biography,
		[property: JsonPropertyName("userpic")] string Userpic,
		[property: JsonPropertyName("comments_count")] int? CommentsCount,
		[property: JsonPropertyName("followers_count")] int? FollowersCount,
		[property: JsonPropertyName("followings_count")] int? FollowingsCount,
		[property: JsonPropertyName("favorite_stories_count")] int? FavoriteStoriesCount,
		[property: JsonPropertyName("messanger_name")] string MessangerName,
		[property: JsonPropertyName("editor_status")] string EditorStatus,
		[property: JsonPropertyName("lists")] IReadOnlyList<InternalAuthorList> Lists
	);
}
