namespace LiteroticaApi.DataObjects
{
	/// <summary>
	/// Represents a single story item within a series or category, including metadata and type.
	/// </summary>
	public record Item(
		[property: JsonPropertyName("id")] long? Id,
		[property: JsonPropertyName("category_info")] CategoryInfo CategoryInfo,
		[property: JsonPropertyName("category")] long? Category,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("url")] string Url
	);

	/// <summary>
	/// Represents metadata information about a story, series, or submission, including pagination and ordering.
	/// </summary>
	public record Meta(
		[property: JsonPropertyName("pages_count")] long? PagesCount,
		[property: JsonPropertyName("id")] long? Id,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("url")] string Url,
		[property: JsonPropertyName("created_at")] string CreatedAt,
		[property: JsonPropertyName("updated_at")] string UpdatedAt,
		[property: JsonPropertyName("order")] IReadOnlyList<long?> Order
	);

	/// <summary>
	/// Represents a detailed submission (story) including author information, metadata, rating, and tags.
	/// </summary>
	public record Submission(
		[property: JsonPropertyName("allow_vote")] long? AllowVote,
		[property: JsonPropertyName("allow_download")] long? AllowDownload,
		[property: JsonPropertyName("author")] Author Author,
		[property: JsonPropertyName("authorname"), JsonConverter(typeof(StringOrIntConverter))] StringOrInt Authorname,
		[property: JsonPropertyName("category_info")] CategoryInfo CategoryInfo,
		[property: JsonPropertyName("category")] long? Category,
		[property: JsonPropertyName("comment_count")] long? CommentCount,
		[property: JsonPropertyName("contest_winner")] long? ContestWinner,
		[property: JsonPropertyName("date_approve")] string DateApprove,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("enable_comments")] long? EnableComments,
		[property: JsonPropertyName("favorite_count")] long? FavoriteCount,
		[property: JsonPropertyName("id")] long? Id,
		[property: JsonPropertyName("is_hot")] bool? IsHot,
		[property: JsonPropertyName("is_new")] bool? IsNew,
		[property: JsonPropertyName("language")] long? Language,
		[property: JsonPropertyName("newlanguage")] long? Newlanguage,
		[property: JsonPropertyName("rank")] object Rank,
		[property: JsonPropertyName("rate_all")] double? RateAll,
		[property: JsonPropertyName("reading_lists_count")] long? ReadingListsCount,
		[property: JsonPropertyName("tags")] IReadOnlyList<Tag> Tags,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("url")] string Url,
		[property: JsonPropertyName("view_count")] long? ViewCount,
		[property: JsonPropertyName("writers_pick")] bool? WritersPick,
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("followedAuthors")] IReadOnlyList<long?> FollowedAuthors,
		[property: JsonPropertyName("series"), JsonConverter(typeof(SeriesDatumConverter))] SeriesDatum? Series,
		[property: JsonPropertyName("reading_time")] long? ReadingTime,
		[property: JsonPropertyName("words_count")] long? WordsCount,
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
		[property: JsonPropertyName("category")] long? Category,
		[property: JsonPropertyName("description")] string Description,
		[property: JsonPropertyName("id")] long? Id,
		[property: JsonPropertyName("language")] long? Language,
		[property: JsonPropertyName("newlanguage")] long? Newlanguage,
		[property: JsonPropertyName("name")] string Name,
		[property: JsonPropertyName("storyid")] long? Storyid,
		[property: JsonPropertyName("tag")] string Tag,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("url")] string Url
	);

	/// <summary>
	/// Represents pagination metadata for search queries.
	/// </summary>
	public record SearchMeta(
		[property: JsonPropertyName("pageSize")] long? PageSize,
		[property: JsonPropertyName("total")] long? Total
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
		[property: JsonPropertyName("submissions_count")] long? SubmissionsCount,
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
		[property: JsonPropertyName("current_page")] long? CurrentPage,
		[property: JsonPropertyName("last_page")] long? LastPage,
		[property: JsonPropertyName("total")] long? Total,
		[property: JsonPropertyName("per_page")] long? PerPage,
		[property: JsonPropertyName("data")] IReadOnlyList<Submission> Data
	);

	/// <summary>
	/// Represents metadata for newly added submissions.
	/// </summary>
	public record NewMeta(
		[property: JsonPropertyName("submissions_count")] long? SubmissionsCount
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

	/// <summary>
	/// Custom JSON converter for handling <see cref="SeriesDatum"/> objects that may appear
	/// as either valid JSON objects, nulls, or unexpected arrays in the API response.
	/// </summary>
	public class SeriesDatumConverter : JsonConverter<SeriesDatum?>
	{
		/// <summary>
		/// Reads and deserializes a <see cref="SeriesDatum"/> instance from the JSON input.
		/// Handles inconsistent API responses where the property may be null, an array, or an object.
		/// </summary>
		/// <param name="reader">The JSON reader.</param>
		/// <param name="typeToConvert">The target type.</param>
		/// <param name="options">Serializer options.</param>
		/// <returns>A deserialized <see cref="SeriesDatum"/> instance or <c>null</c> if invalid.</returns>
		/// <exception cref="JsonException">Thrown when the JSON format is unexpected or invalid.</exception>
		public override SeriesDatum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			switch (reader.TokenType)
			{
				case JsonTokenType.Null:
					return null;
				case JsonTokenType.StartArray:
					reader.Skip();
					return null;
				case JsonTokenType.StartObject:
				{
					JsonDocument doc = JsonDocument.ParseValue(ref reader);
					return JsonSerializer.Deserialize<SeriesDatum>(doc.RootElement.GetRawText(), options);
				}
				case JsonTokenType.None:
				case JsonTokenType.EndObject:
				case JsonTokenType.EndArray:
				case JsonTokenType.PropertyName:
				case JsonTokenType.Comment:
				case JsonTokenType.String:
				case JsonTokenType.Number:
				case JsonTokenType.True:
				case JsonTokenType.False:
				default:
					throw new JsonException($"Unexpected token {reader.TokenType} when parsing SeriesDatum");
			}
		}

		/// <summary>
		/// Writes the <see cref="SeriesDatum"/> instance to JSON.
		/// </summary>
		/// <param name="writer">The JSON writer.</param>
		/// <param name="value">The <see cref="SeriesDatum"/> instance to serialize.</param>
		/// <param name="options">Serializer options.</param>
		public override void Write(Utf8JsonWriter writer, SeriesDatum? value, JsonSerializerOptions options)
		{
			if (value is null)
			{
				writer.WriteNullValue();
			}
			else
			{
				JsonSerializer.Serialize(writer, value, options);
			}
		}
	}
}
