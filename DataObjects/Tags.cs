namespace LiteroticaApi.DataObjects
{
	/// <summary>
	/// Represents a tag entity used for categorizing stories, including its text and ban status.
	/// </summary>
	public record Tag(
		[property: JsonPropertyName("id")] long? Id,
		[property: JsonPropertyName("tag"), JsonConverter(typeof(StringOrIntConverter))] StringOrInt TagText,
		[property: JsonPropertyName("is_banned")] long? IsBanned
	);

	/// <summary>
	/// Represents detailed information about a category, including its name, descriptions, and submission count.
	/// </summary>
	public record CategoryReturn(
		[property: JsonPropertyName("id")] long? Id,
		[property: JsonPropertyName("language")] long? Language,
		[property: JsonPropertyName("ldesc")] string Ldesc,
		[property: JsonPropertyName("name")] string Name,
		[property: JsonPropertyName("pageUrl")] string PageUrl,
		[property: JsonPropertyName("sdesc")] string Sdesc,
		[property: JsonPropertyName("topUrl")] string TopUrl,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("submission_count")] long? SubmissionCount
	);

	/// <summary>
	/// Represents a tag that is related to another tag, including its ID, display text, and usage count.
	/// </summary>
	public record RelatedTag(
		[property: JsonPropertyName("id")] long? Id,
		[property: JsonPropertyName("tag"), JsonConverter(typeof(StringOrIntConverter))] StringOrInt Tag,
		[property: JsonPropertyName("cnt")] long? Cnt
	);

	/// <summary>
	/// Represents metadata that contains available period-based statistics.
	/// </summary>
	public record PeriodMeta(
		[property: JsonPropertyName("period_checks")] PeriodChecks PeriodChecks
	);

	/// <summary>
	/// Represents available statistical checks across multiple time periods such as week, month, and today.
	/// </summary>
	public record PeriodChecks(
		[property: JsonPropertyName("month")] long? Month,
		[property: JsonPropertyName("week")] long? Week,
		[property: JsonPropertyName("today")] long? Today,
		[property: JsonPropertyName("allperiod")] long? Allperiod
	);

	/// <summary>
	/// Represents a collection of top tags along with associated metadata for a specific period.
	/// </summary>
	public record TopTags(
		[property: JsonPropertyName("meta")] PeriodMeta Meta,
		[property: JsonPropertyName("tags")] IReadOnlyList<TagInfo> Tags
	);

	/// <summary>
	/// Represents detailed information about a specific tag, including category, language, and usage metrics.
	/// </summary>
	public record TagInfo(
		[property: JsonPropertyName("id")] long? Id,
		[property: JsonPropertyName("tag")] string Tag,
		[property: JsonPropertyName("language")] long? Language,
		[property: JsonPropertyName("tagid")] long? Tagid,
		[property: JsonPropertyName("category")] long? Category,
		[property: JsonPropertyName("cnt")] long? Cnt,
		[property: JsonPropertyName("is_banned")] long? IsBanned
	);
}
