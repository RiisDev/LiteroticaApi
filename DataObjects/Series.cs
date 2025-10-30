namespace LiteroticaApi.DataObjects
{
	/// <summary>
	/// Represents internal data about a specific series, including metadata, user, and content details.
	/// </summary>
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

	/// <summary>
	/// Represents the root container for a serialized series response from the Literotica API.
	/// </summary>
	internal record InternalSeriesRoot(
		[property: JsonPropertyName("success")] bool? Success,
		[property: JsonPropertyName("data")] Data Data
	);

	/// <summary>
	/// Represents all available media assets (e.g., cover images) for both mobile and desktop displays.
	/// </summary>
	public record Assets(
		[property: JsonPropertyName("mobile")] Mobile Mobile,
		[property: JsonPropertyName("desktop")] Desktop Desktop
	);

	/// <summary>
	/// Represents desktop-specific asset resolutions (x1, x2, x3).
	/// </summary>
	public record Desktop(
		[property: JsonPropertyName("x1")] X1 X1,
		[property: JsonPropertyName("x2")] X2 X2,
		[property: JsonPropertyName("x3")] X3 X3
	);

	/// <summary>
	/// Represents mobile-specific asset resolutions (x1, x2, x3).
	/// </summary>
	public record Mobile(
		[property: JsonPropertyName("x1")] X1 X1,
		[property: JsonPropertyName("x2")] X2 X2,
		[property: JsonPropertyName("x3")] X3 X3
	);

	/// <summary>
	/// Represents a cover image response, containing resolution-specific asset metadata.
	/// </summary>
	public record Cover(
		[property: JsonPropertyName("success")] bool? Success,
		[property: JsonPropertyName("data")] Assets Data
	);

	/// <summary>
	/// Represents a standard image resolution entry (x1 scale).
	/// </summary>
	public record X1(
		[property: JsonPropertyName("width")] int? Width,
		[property: JsonPropertyName("height")] int? Height,
		[property: JsonPropertyName("file_path")] string FilePath
	);

	/// <summary>
	/// Represents a medium-resolution image asset (x2 scale).
	/// </summary>
	public record X2(
		[property: JsonPropertyName("width")] int? Width,
		[property: JsonPropertyName("height")] int? Height,
		[property: JsonPropertyName("file_path")] string FilePath
	);

	/// <summary>
	/// Represents a high-resolution image asset (x3 scale).
	/// </summary>
	public record X3(
		[property: JsonPropertyName("width")] int? Width,
		[property: JsonPropertyName("height")] int? Height,
		[property: JsonPropertyName("file_path")] string FilePath
	);

	/// <summary>
	/// Represents a story or work category, including its unique identifier and URL.
	/// </summary>
	public record Category(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("url")] string Url
	);

	/// <summary>
	/// Represents an individual work, including metadata, author details, and associated categories.
	/// </summary>
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

	/// <summary>
	/// Represents the root container for a list of works, used for top works or featured series endpoints.
	/// </summary>
	internal record TopInternalRoot(
		[property: JsonPropertyName("data")] IReadOnlyList<Works> Data
	);

	/// <summary>
	/// Represents a minimal reference to a work, containing its ID and URL.
	/// </summary>
	public record Work(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("url")] string Url
	);
}
