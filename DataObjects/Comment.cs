using System;
using System.Collections.Generic;
using System.Text;

namespace LiteroticaApi.DataObjects
{
	public record CommentHistoryMeta(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage,
		[property: JsonPropertyName("work")] Story Work
	);

	public record CommentHistoryDatum(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("date")] int? Date,
		[property: JsonPropertyName("rate")] int? Rate,
		[property: JsonPropertyName("type")] int? Type,
		[property: JsonPropertyName("text")] string Text,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("author")] Author Author
	);

	public record CommentHistory(
		[property: JsonPropertyName("meta")] CommentHistoryMeta Meta,
		[property: JsonPropertyName("data")] IReadOnlyList<CommentHistoryDatum> Data
	);

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

	public record TopCommentersDatum(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("name")] string Name,
		[property: JsonPropertyName("total_comments")] int? TotalComments
	);

	public record TopCommentersMeta(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage
	);

	public record TopCommenters(
		[property: JsonPropertyName("meta")] TopCommentersMeta Meta,
		[property: JsonPropertyName("data")] IReadOnlyList<TopCommentersDatum> Data
	);
}
