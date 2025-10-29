
namespace LiteroticaApi.DataObjects
{
	internal record Data(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("user_id")] int? UserId,
		[property: JsonPropertyName("url")] object? Url,
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
		[property: JsonPropertyName("user")] Author User,
		[property: JsonPropertyName("work_count")] int? WorkCount,
		[property: JsonPropertyName("introduction")] object? Introduction
	);

	internal record InternalSeriesRoot(
		[property: JsonPropertyName("success")] bool? Success,
		[property: JsonPropertyName("data")] Data Data
	);

	public record Assets(
		[property: JsonPropertyName("mobile")] Mobile Mobile,
		[property: JsonPropertyName("desktop")] Desktop Desktop
	);

	public record Desktop(
		[property: JsonPropertyName("x1")] X1 X1,
		[property: JsonPropertyName("x2")] X2 X2,
		[property: JsonPropertyName("x3")] X3 X3
	);

	public record Mobile(
		[property: JsonPropertyName("x1")] X1 X1,
		[property: JsonPropertyName("x2")] X2 X2,
		[property: JsonPropertyName("x3")] X3 X3
	);

	public record Cover(
		[property: JsonPropertyName("success")] bool? Success,
		[property: JsonPropertyName("data")] Assets Data
	);

	public record X1(
		[property: JsonPropertyName("width")] int? Width,
		[property: JsonPropertyName("height")] int? Height,
		[property: JsonPropertyName("file_path")] string FilePath
	);

	public record X2(
		[property: JsonPropertyName("width")] int? Width,
		[property: JsonPropertyName("height")] int? Height,
		[property: JsonPropertyName("file_path")] string FilePath
	);

	public record X3(
		[property: JsonPropertyName("width")] int? Width,
		[property: JsonPropertyName("height")] int? Height,
		[property: JsonPropertyName("file_path")] string FilePath
	);

	public record Category(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("url")] string Url
	);

	public record Works(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("user_id")] int? UserId,
		[property: JsonPropertyName("url")] object Url,
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
		[property: JsonPropertyName("author_name")] string AuthorName,
		[property: JsonPropertyName("categories")] IReadOnlyList<Category> Categories,
		[property: JsonPropertyName("works")] IReadOnlyList<Work> WorksInfo
	);

	internal record TopInternalRoot(
		[property: JsonPropertyName("data")] IReadOnlyList<Works> Data
	);

	public record Work(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("url")] string Url
	);
}
