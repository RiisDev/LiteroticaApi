namespace LiteroticaApi.DataObjects
{
	internal record InternalAuthorList(
		[property: JsonPropertyName("id")] long? Id,
		[property: JsonPropertyName("user_id")] long? UserId,
		[property: JsonPropertyName("urlname")] string Urlname,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("submission_type")] string SubmissionType,
		[property: JsonPropertyName("stories_count")] long? StoriesCount
	);

	internal record InternalAuthor(
		[property: JsonPropertyName("userid")] long? Userid,
		[property: JsonPropertyName("username")] string Username,
		[property: JsonPropertyName("homepage")] string Homepage,
		[property: JsonPropertyName("icq")] string Icq,
		[property: JsonPropertyName("aim")] string Aim,
		[property: JsonPropertyName("usertitle")] string Usertitle,
		[property: JsonPropertyName("customtitle")] long? Customtitle,
		[property: JsonPropertyName("joindate")] string Joindate,
		[property: JsonPropertyName("location")] string? Location,
		[property: JsonPropertyName("smoke")] string Smoke,
		[property: JsonPropertyName("drink")] string Drink,
		[property: JsonPropertyName("pets")] string Pets,
		[property: JsonPropertyName("submissions_count")] long? SubmissionsCount,
		[property: JsonPropertyName("has_photo")] long? HasPhoto,
		[property: JsonPropertyName("options")] long? Options,
		[property: JsonPropertyName("biography")] string Biography,
		[property: JsonPropertyName("userpic")] string Userpic,
		[property: JsonPropertyName("comments_count")] long? CommentsCount,
		[property: JsonPropertyName("followers_count")] long? FollowersCount,
		[property: JsonPropertyName("followings_count")] long? FollowingsCount,
		[property: JsonPropertyName("favorite_stories_count")] long? FavoriteStoriesCount,
		[property: JsonPropertyName("messanger_name")] string MessangerName,
		[property: JsonPropertyName("editor_status")] string EditorStatus,
		[property: JsonPropertyName("lists")] IReadOnlyList<InternalAuthorList> Lists
	);
}
