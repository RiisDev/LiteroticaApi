using System.Collections.Concurrent;
using System.Diagnostics;
// ReSharper disable CheckNamespace
#pragma warning disable IDE0130

namespace LiteroticaApi
{
	/// <summary>
	/// Provides a centralized HTTP client used by the Literotica API SDK.
	/// This static client manages all outbound HTTP requests and supports both
	/// a default internal client and user-supplied custom clients.
	/// </summary>
	public static class Client
	{
		private static readonly Lazy<HttpClient> LazyClient = new(() =>
		{
			HttpClient client = new()
			{
				Timeout = TimeSpan.FromSeconds(30)
			};
			client.DefaultRequestHeaders.Add("User-Agent", "IrisAgent LitEroticaApi/1.0");
			client.DefaultRequestHeaders.Add("Accept", "application/json");
			return client;
		});

		/// <summary>
		/// Gets or sets the active <see cref="HttpClient"/> instance used by all API operations.
		/// </summary>
		/// <remarks>
		/// By default, this property returns the internal shared client.
		/// If you wish to override it with your own client (for example, to
		/// add custom headers, proxy configurations, or handlers), simply set
		/// <see cref="HttpClientInstance"/> to your own <see cref="HttpClient"/>.
		/// </remarks>
		public static HttpClient HttpClientInstance
		{
			get => _customClient ?? LazyClient.Value;
			set => _customClient = value;
		}

		private static HttpClient? _customClient;

		private static readonly TimeSpan CacheDuration = TimeSpan.FromMinutes(30);

		internal static async Task<T> Get<T>(string endpoint, object? jsonContent = null)
		{
			if (endpoint[0] == '/')
				endpoint = endpoint[1..];

			string queryString = jsonContent is not null
				? "?params=" + Uri.EscapeDataString(JsonSerializer.Serialize(jsonContent))
				: string.Empty;

			string url = $"https://literotica.com/api/3/{endpoint}{queryString}";

			Debug.WriteLine(url);

			string cacheKey = $"{typeof(T).FullName}:{url}";

			if (Cache.TryGetValue(cacheKey, out T? cachedValue)) return cachedValue!;

			HttpRequestMessage request = new(HttpMethod.Get, url);
			HttpResponseMessage response = await HttpClientInstance.SendAsync(request).ConfigureAwait(false);

			if (!response.IsSuccessStatusCode)
			{
				string responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
				(bool success, Error? data) = TryDeserialize<Error>(responseText);

				if (success && data is not null)
					throw new LitEroticaInternalException(data.Message);

				throw new LitEroticaInternalException(
					$"Request to '{url}' failed with {(int)response.StatusCode} ({response.StatusCode}).\nResponse: {responseText}"
				);
			}

			string jsonResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

#if DEBUG
			Debug.WriteLine(jsonResponse);
#endif

			T result;

			if (typeof(T) == typeof(string))
			{
				result = (T)(object)jsonResponse;
			}
			else
			{
				T deserialized = JsonSerializer.Deserialize<T>(jsonResponse) ?? throw new LitEroticaApiException("Deserialization returned null.");
				result = deserialized;
			}

			Cache.Set(cacheKey, result, CacheDuration);

			return result;
		}

		internal static (bool, T?) TryDeserialize<T>(string jsonResponse)
		{
			try
			{
				return (true, JsonSerializer.Deserialize<T>(jsonResponse));
			}
			catch
			{
				return (false, default);
			}
		}
	}

	internal static class Cache
	{
		private static readonly ConcurrentDictionary<string, (DateTimeOffset Expiry, object Value)> CacheData = new();

		internal static bool TryGetValue<T>(string key, out T? value)
		{
			if (CacheData.TryGetValue(key, out (DateTimeOffset Expiry, object Value) entry))
			{
				if (DateTimeOffset.UtcNow < entry.Expiry)
				{
					value = (T)entry.Value;
					return true;
				}

				CacheData.TryRemove(key, out _);
			}

			value = default;

			if (value != null)
				Debug.WriteLine($"{key}: {JsonSerializer.Serialize(value)}");

			return false;
		}

		internal static void Set<T>(string key, T value, TimeSpan duration)
		{
			Debug.WriteLine($"{key}: {JsonSerializer.Serialize(value)}");

			DateTimeOffset expiry = DateTimeOffset.UtcNow.Add(duration);
			CacheData[key] = (expiry, value!);

			if (CacheData.Count % 500 != 0) return;

			foreach (KeyValuePair<string, (DateTimeOffset Expiry, object Value)> kvp in CacheData)
			{
				if (kvp.Value.Expiry <= DateTimeOffset.UtcNow)
					CacheData.TryRemove(kvp.Key, out _);
			}
		}
	}
}
