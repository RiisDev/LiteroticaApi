namespace LiteroticaApi.DataObjects
{
	/// <summary>
	/// Represents a single story item within a series or category, including metadata and type.
	/// </summary>
	public record Item(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("category_info")] CategoryInfo CategoryInfo,
		[property: JsonPropertyName("category")] int? Category,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("url")] string Url
	);

	/// <summary>
	/// Represents metadata information about a story, series, or submission, including pagination and ordering.
	/// </summary>
	public record Meta(
		[property: JsonPropertyName("pages_count")] int? PagesCount,
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("url")] string Url,
		[property: JsonPropertyName("created_at")] string CreatedAt,
		[property: JsonPropertyName("updated_at")] string UpdatedAt,
		[property: JsonPropertyName("order")] IReadOnlyList<int?> Order
	);

	/// <summary>
	/// Represents a detailed submission (story) including author information, metadata, rating, and tags.
	/// </summary>
	public record Submission(
		[property: JsonPropertyName("allow_vote")] int? AllowVote,
		[property: JsonPropertyName("allow_download")] int? AllowDownload,
		[property: JsonPropertyName("author")] Author Author,
		[property: JsonPropertyName("authorname"), JsonConverter(typeof(StringOrIntConverter))] StringOrInt Authorname,
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
		[property: JsonPropertyName("rank")] object Rank,
		[property: JsonPropertyName("rate_all")] double? RateAll,
		[property: JsonPropertyName("reading_lists_count")] int? ReadingListsCount,
		[property: JsonPropertyName("tags")] IReadOnlyList<Tag> Tags,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("url")] string Url,
		[property: JsonPropertyName("view_count")] int? ViewCount,
		[property: JsonPropertyName("writers_pick")] bool? WritersPick,
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("followedAuthors")] IReadOnlyList<int?> FollowedAuthors,
		[property: JsonPropertyName("series")] SeriesDatum Series,
		[property: JsonPropertyName("reading_time")] int? ReadingTime,
		[property: JsonPropertyName("words_count")] int? WordsCount,
		[property: JsonPropertyName("contests")] IReadOnlyList<object> Contests
	);

	/// <summary>
	/// Represents the root object for detailed story information including metadata and submission content.
	/// </summary>
	public record StoryInfo(
		[property: JsonPropertyName("meta")] Meta Meta,
		[property: JsonPropertyName("submission")] Submission Submission,
		[property: JsonPropertyName("pageText")] string PageText
	);

	/// <summary>
	/// Represents a series containing multiple story items and its related metadata.
	/// </summary>
	public record SeriesDatum(
		[property: JsonPropertyName("meta")] Meta Meta,
		[property: JsonPropertyName("items")] IReadOnlyList<Item> Items
	);

	/// <summary>
	/// Represents the details of an individual story, including metadata such as category, language, and URL.
	/// </summary>
	public record StoryDetails(
		[property: JsonPropertyName("category")] int? Category,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("language")] int? Language,
		[property: JsonPropertyName("newlanguage")] int? Newlanguage,
		[property: JsonPropertyName("name")] string Name,
		[property: JsonPropertyName("storyid")] int? Storyid,
		[property: JsonPropertyName("tag")] string Tag,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("url")] string Url
	);

	/// <summary>
	/// Represents pagination metadata for search queries.
	/// </summary>
	public record SearchMeta(
		[property: JsonPropertyName("pageSize")] int? PageSize,
		[property: JsonPropertyName("total")] int? Total
	);

	/// <summary>
	/// Represents a paginated list of search results, including the data and metadata.
	/// </summary>
	public record Search(
		[property: JsonPropertyName("data")] IReadOnlyList<Submission> Data,
		[property: JsonPropertyName("meta")] SearchMeta Meta
	);

	/// <summary>
	/// Represents metadata specific to tag-based search queries.
	/// </summary>
	public record SearchByTagMeta(
		[property: JsonPropertyName("submissions_count")] int? SubmissionsCount,
		[property: JsonPropertyName("period_checks")] PeriodChecks PeriodChecks
	);

	/// <summary>
	/// Represents a collection of stories found under a specific tag, along with related metadata.
	/// </summary>
	public record SearchByTag(
		[property: JsonPropertyName("meta")] SearchByTagMeta Meta,
		[property: JsonPropertyName("submissions")] IReadOnlyList<Submission> Submissions
	);

	/// <summary>
	/// Represents a paginated list of top-rated or most popular submissions.
	/// </summary>
	public record Top(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage,
		[property: JsonPropertyName("data")] IReadOnlyList<Submission> Data
	);

	/// <summary>
	/// Represents metadata for newly added submissions.
	/// </summary>
	public record NewMeta(
		[property: JsonPropertyName("submissions_count")] int? SubmissionsCount
	);

	/// <summary>
	/// Represents a list of newly published submissions, including metadata.
	/// </summary>
	public record GetNew(
		[property: JsonPropertyName("meta")] NewMeta Meta,
		[property: JsonPropertyName("submissions")] IReadOnlyList<Submission> Submissions
	);

	/// <summary>
	/// Represents a flexible data structure that can store either a string or an integer value.
	/// </summary>
	[JsonConverter(typeof(StringOrIntConverter))]
	public readonly struct StringOrInt
	{
		private readonly string _value;

		/// <summary>
		/// Internal usage only: converts the StringOrInt to a string.
		/// </summary>
		public StringOrInt(string value)
		{
			_value = value;
		}

		/// <summary>
		/// Internal usage only: converts the StringOrInt to a string.
		/// </summary>
		public StringOrInt(int value)
		{
			_value = value.ToString();
		}

		/// <summary>
		/// Internal usage only: converts the StringOrInt to a string.
		/// </summary>
		public override string ToString() => _value;

		/// <summary>
		/// Internal usage only: converts the StringOrInt to a string.
		/// </summary>
		public static implicit operator StringOrInt(string value) => new(value);
		/// <summary>
		/// Internal usage only: converts the StringOrInt to a string.
		/// </summary>
		public static implicit operator StringOrInt(int value) => new(value);
		/// <summary>
		/// Internal usage only: converts the StringOrInt to a string.
		/// </summary>
		public static implicit operator string(StringOrInt value) => value._value;
	}

	/// <summary>
	/// Custom JSON converter to handle string-or-integer conversions during serialization and deserialization.
	/// </summary>
	public class StringOrIntConverter : JsonConverter<StringOrInt>
	{
		/// <inheritdoc />
		public override StringOrInt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.TokenType switch
			{
				JsonTokenType.String => new StringOrInt(reader.GetString()!),
				JsonTokenType.Number => new StringOrInt(reader.GetInt32()),
				_ => throw new JsonException("Expected string or number for StringOrInt")
			};
		}

		/// <inheritdoc />
		public override void Write(Utf8JsonWriter writer, StringOrInt value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToString());
		}
	}
}
