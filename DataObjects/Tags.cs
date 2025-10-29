namespace LiteroticaApi.DataObjects
{
	public record Tag(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("tag"), JsonConverter(typeof(StringOrIntConverter))] StringOrInt TagText,
		[property: JsonPropertyName("is_banned")] int? IsBanned
	);

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

	public record RelatedTag(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("tag"), JsonConverter(typeof(StringOrIntConverter))] StringOrInt Tag,
		[property: JsonPropertyName("cnt")] int? Cnt
	);

	public record PeriodMeta(
		[property: JsonPropertyName("period_checks")] PeriodChecks PeriodChecks
	);

	public record PeriodChecks(
		[property: JsonPropertyName("month")] int? Month,
		[property: JsonPropertyName("week")] int? Week,
		[property: JsonPropertyName("today")] int? Today,
		[property: JsonPropertyName("allperiod")] int? Allperiod
	);

	public record TopTags(
		[property: JsonPropertyName("meta")] PeriodMeta Meta,
		[property: JsonPropertyName("tags")] IReadOnlyList<TagInfo> Tags
	);

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
