using LiteroticaApi.DataObjects;

namespace LiteroticaApi.AuthClientData.DataObjects
{
	/// <summary>
	/// Represents a user's activity feed, including a list of recent activity data
	/// and the count of new unseen activities.
	/// </summary>
	public record Activity(
		[property: JsonPropertyName("data")] IReadOnlyList<ActivityData> Data,
		[property: JsonPropertyName("new_activity_count")] int? NewActivityCount
	);

	/// <summary>
	/// Represents an individual activity event, such as a story post, biography update,
	/// or user interaction on the platform.
	/// </summary>
	public record ActivityData(
		[property: JsonPropertyName("id")] string Id,
		[property: JsonPropertyName("action")] string Action,
		[property: JsonPropertyName("when")] int? When,
		[property: JsonPropertyName("who")] Who Who,
		[property: JsonPropertyName("what"), JsonConverter(typeof(WhatConverter))] What What,
		[property: JsonPropertyName("sequence")] int? Sequence,
		[property: JsonPropertyName("whom")] Who? Whom
	);

	/// <summary>
	/// Represents a user involved in an activity — either the actor or the target.
	/// </summary>
	public record Who(
		[property: JsonPropertyName("userid")] int? Userid,
		[property: JsonPropertyName("username")] string Username,
		[property: JsonPropertyName("userpic")] string Userpic
	);

	/// <summary>
	/// Represents the subject of an activity, which may be either a biography change or a story reference.
	/// </summary>
	public record What(
		IReadOnlyList<string>? Biography,
		Story? Story
	)
	{
		/// <summary>
		/// Indicates whether the activity involves a biography update.
		/// </summary>
		public bool IsBiography => Biography is not null;
		/// <summary>
		/// Indicates whether the activity involves a story.
		/// </summary>
		public bool IsStory => Story is not null;
	}

	/// <summary>
	/// Handles JSON deserialization for <see cref="What"/> objects that can contain
	/// either an array (biography) or an object (story).
	/// </summary>
	public class WhatConverter : JsonConverter<What>
	{
		/// <summary>
		/// Reads and converts JSON data into a <see cref="What"/> object.
		/// Determines if the data represents a biography or a story based on its structure.
		/// </summary>
		/// <param name="reader">The JSON reader instance.</param>
		/// <param name="typeToConvert">The target type to convert to.</param>
		/// <param name="options">Serializer options.</param>
		/// <returns>A deserialized <see cref="What"/> object, or null if parsing fails.</returns>

		public override What Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			using JsonDocument doc = JsonDocument.ParseValue(ref reader);

			switch (doc.RootElement.ValueKind)
			{
				case JsonValueKind.Array:
				{
					IReadOnlyList<string>? bio = JsonSerializer.Deserialize<IReadOnlyList<string>>(doc.RootElement.GetRawText(), options);
					return new What(bio, null);
				}
				case JsonValueKind.Object:
				{
					Story? story = JsonSerializer.Deserialize<Story>(doc.RootElement.GetRawText(), options);
					return new What(null, story);
				}
				case JsonValueKind.Undefined:
				case JsonValueKind.String:
				case JsonValueKind.Number:
				case JsonValueKind.True:
				case JsonValueKind.False:
				case JsonValueKind.Null:
				default:
					return new What(null, null);
			}
		}

		/// <summary>
		/// Writes a <see cref="What"/> object as JSON, handling both biography and story formats.
		/// </summary>
		/// <param name="writer">The JSON writer instance.</param>
		/// <param name="value">The <see cref="What"/> value to write.</param>
		/// <param name="options">Serializer options.</param>
		public override void Write(Utf8JsonWriter writer, What value, JsonSerializerOptions options)
		{
			if (value.Biography is not null)
			{
				JsonSerializer.Serialize(writer, value.Biography, options);
			}
			else if (value.Story is not null)
			{
				JsonSerializer.Serialize(writer, value.Story, options);
			}
			else
			{
				writer.WriteNullValue();
			}
		}
	}
}
