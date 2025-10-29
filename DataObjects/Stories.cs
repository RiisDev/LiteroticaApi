using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LiteroticaApi.DataObjects
{
	public record Item(
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("category_info")] CategoryInfo CategoryInfo,
		[property: JsonPropertyName("category")] int? Category,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("url")] string Url
	);

	public record Meta(
		[property: JsonPropertyName("pages_count")] int? PagesCount,
		[property: JsonPropertyName("id")] int? Id,
		[property: JsonPropertyName("title")] string Title,
		[property: JsonPropertyName("url")] string Url,
		[property: JsonPropertyName("created_at")] string CreatedAt,
		[property: JsonPropertyName("updated_at")] string UpdatedAt,
		[property: JsonPropertyName("order")] IReadOnlyList<int?> Order
	); 
	
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

	public record StoryInfo(
		[property: JsonPropertyName("meta")] Meta Meta,
		[property: JsonPropertyName("submission")] Submission Submission,
		[property: JsonPropertyName("pageText")] string PageText
	);

	public record SeriesDatum(
		[property: JsonPropertyName("meta")] Meta Meta,
		[property: JsonPropertyName("items")] IReadOnlyList<Item> Items
	);

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

	public record SearchMeta(
		[property: JsonPropertyName("pageSize")] int? PageSize,
		[property: JsonPropertyName("total")] int? Total
	);

	public record Search(
		[property: JsonPropertyName("data")] IReadOnlyList<Submission> Data,
		[property: JsonPropertyName("meta")] SearchMeta Meta
	);

	public record SearchByTagMeta(
		[property: JsonPropertyName("submissions_count")] int? SubmissionsCount,
		[property: JsonPropertyName("period_checks")] PeriodChecks PeriodChecks
	);

	public record SearchByTag(
		[property: JsonPropertyName("meta")] SearchByTagMeta Meta,
		[property: JsonPropertyName("submissions")] IReadOnlyList<Submission> Submissions
	);

	public record Top(
		[property: JsonPropertyName("current_page")] int? CurrentPage,
		[property: JsonPropertyName("last_page")] int? LastPage,
		[property: JsonPropertyName("total")] int? Total,
		[property: JsonPropertyName("per_page")] int? PerPage,
		[property: JsonPropertyName("data")] IReadOnlyList<Submission> Data
	);

	public record NewMeta(
		[property: JsonPropertyName("submissions_count")] int? SubmissionsCount
	);

	public record GetNew(
		[property: JsonPropertyName("meta")] NewMeta Meta,
		[property: JsonPropertyName("submissions")] IReadOnlyList<Submission> Submissions
	);

	[JsonConverter(typeof(StringOrIntConverter))]
	public readonly struct StringOrInt
	{
		private readonly string _value;

		public StringOrInt(string value)
		{
			_value = value;
		}

		public StringOrInt(int value)
		{
			_value = value.ToString();
		}

		public override string ToString() => _value;

		public static implicit operator StringOrInt(string value) => new(value);
		public static implicit operator StringOrInt(int value) => new(value);
		public static implicit operator string(StringOrInt value) => value._value;
	}

	public class StringOrIntConverter : JsonConverter<StringOrInt>
	{
		public override StringOrInt Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.TokenType switch
			{
				JsonTokenType.String => new StringOrInt(reader.GetString()!),
				JsonTokenType.Number => new StringOrInt(reader.GetInt32()),
				_ => throw new JsonException("Expected string or number for StringOrInt")
			};
		}

		public override void Write(Utf8JsonWriter writer, StringOrInt value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToString());
		}
	}
}
