namespace LiteroticaApi.DataObjects
{
	/// <summary>
	/// Represents a tag entity used for categorizing stories, including its text and ban status.
	/// </summary>
	public record Tag(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("tag"), JsonConverter(typeof(StringOrIntConverter))] StringOrInt TagText,
		[property: JsonPropertyName("is_banned")] int? IsBanned
	);

	/// <summary>
	/// Represents detailed information about a category, including its name, descriptions, and submission count.
	/// </summary>
	public record CategoryReturn(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("language")] int? Language,
		[property: JsonPropertyName("ldesc")] string Ldesc,
		[property: JsonPropertyName("name")] string Name,
		[property: JsonPropertyName("pageUrl")] string PageUrl,
		[property: JsonPropertyName("sdesc")] string Sdesc,
		[property: JsonPropertyName("topUrl")] string TopUrl,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("submission_count")] int? SubmissionCount
	);

	/// <summary>
	/// Represents a tag that is related to another tag, including its ID, display text, and usage count.
	/// </summary>
	public record RelatedTag(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("tag"), JsonConverter(typeof(StringOrIntConverter))] StringOrInt Tag,
		[property: JsonPropertyName("cnt")] int? Cnt
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
		[property: JsonPropertyName("month")] int? Month,
		[property: JsonPropertyName("week")] int? Week,
		[property: JsonPropertyName("today")] int? Today,
		[property: JsonPropertyName("allperiod")] int? Allperiod
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
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("tag")] string Tag,
		[property: JsonPropertyName("language")] int? Language,
		[property: JsonPropertyName("tagid")] int? Tagid,
		[property: JsonPropertyName("category")] int? Category,
		[property: JsonPropertyName("cnt")] int? Cnt,
		[property: JsonPropertyName("is_banned")] int? IsBanned
	);
}
