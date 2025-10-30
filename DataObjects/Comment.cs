namespace LiteroticaApi.DataObjects
{
	/// <summary>
	/// Represents pagination and metadata information for a user's comment history on a specific story.
	/// </summary>
	public record CommentHistoryMeta(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage,
		[property: JsonPropertyName("work")] Story Work
	);

	/// <summary>
	/// Represents a single comment entry within a user's comment history.
	/// </summary>
	public record CommentHistoryDatum(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("date")] int? Date,
		[property: JsonPropertyName("rate")] int? Rate,
		[property: JsonPropertyName("type")] int? Type,
		[property: JsonPropertyName("text")] string Text,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("author")] Author Author
	);

	/// <summary>
	/// Represents a collection of comments and associated metadata for a given story or author.
	/// </summary>
	public record CommentHistory(
		[property: JsonPropertyName("meta")] CommentHistoryMeta Meta,
		[property: JsonPropertyName("data")] IReadOnlyList<CommentHistoryDatum> Data
	);

	/// <summary>
	/// Represents a recent comment made on a work, typically used in global or author-wide comment feeds.
	/// </summary>
	public record RecentComment(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("date")] int? Date,
		[property: JsonPropertyName("rate")] int? Rate,
		[property: JsonPropertyName("type")] int? Type,
		[property: JsonPropertyName("story")] Story Story,
		[property: JsonPropertyName("text")] string Text,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("author")] Author Author
	);

	/// <summary>
	/// Represents a single top commenter entry with basic identification and activity metrics.
	/// </summary>
	public record TopCommentersDatum(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("name")] string Name,
		[property: JsonPropertyName("total_comments")] int? TotalComments
	);

	/// <summary>
	/// Metadata and pagination structure for the top commenters API response.
	/// </summary>
	public record TopCommentersMeta(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage
	);

	/// <summary>
	/// Represents the response model containing a list of top commenters and pagination metadata.
	/// </summary>
	public record TopCommenters(
		[property: JsonPropertyName("meta")] TopCommentersMeta Meta,
		[property: JsonPropertyName("data")] IReadOnlyList<TopCommentersDatum> Data
	);
}
