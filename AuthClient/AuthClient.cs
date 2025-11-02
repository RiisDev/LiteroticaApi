using System.Net;

// ReSharper disable CheckNamespace
#pragma warning disable IDE0130

namespace LiteroticaApi
{
	/// <summary>
	/// Provides a centralized HTTP client used by the Literotica API SDK.
	/// This static client manages all outbound HTTP requests and supports both
	/// a default internal client and user-supplied custom clients.
	/// </summary>
	public class AuthClient
	{
		private bool _loggedIn;

		private static readonly CookieContainer CookieContainer = new();
		private readonly HttpClient _client = new( new HttpClientHandler
		{
			AllowAutoRedirect = true,
			AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip,
			CookieContainer = CookieContainer,
			UseCookies = true
		})
		{
			DefaultRequestHeaders =
			{
				{"User-Agent", "IrisAgent LitEroticaApi/1.0"}
			}
		};

		private static System.Net.Http.HttpMethod MapHttpMethod(HttpMethod method) => method switch
		{
			HttpMethod.Get => System.Net.Http.HttpMethod.Get,
			HttpMethod.Post => System.Net.Http.HttpMethod.Post,
			HttpMethod.Put => System.Net.Http.HttpMethod.Put,
			HttpMethod.Delete => System.Net.Http.HttpMethod.Delete,
			HttpMethod.Options => System.Net.Http.HttpMethod.Options,
			HttpMethod.Head => System.Net.Http.HttpMethod.Head,
			_ => throw new ArgumentOutOfRangeException(nameof(method), method, null)
		};

		private enum HttpMethod
		{
			Get,
			Post,
			Put,
			Delete,
			Options,
			Head
		}

		/// <summary>
		/// Attempts to authenticate a user with the Literotica API using the provided credentials.
		/// </summary>
		/// <param name="username">The Literotica account username.</param>
		/// <param name="password">The Literotica account password.</param>
		/// <returns>
		/// A <see cref="bool"/> indicating whether authentication was successful.
		/// </returns>
		/// <exception cref="LitEroticaApiException">Thrown when the API returns an invalid or error response.</exception>
		/// <exception cref="LitEroticaInternalException">Thrown when a network or internal error occurs.</exception>
		public async Task<bool> Login(string username, string password)
		{
			string? response = await PostAsync<string>("https://auth.literotica.com/", "login", JsonContent.Create(new Dictionary<string, string>
			{
				{"login", username},
				{"password", password}
			}));

			if (response is not "OK") throw new Exception($"Failed to login: {response}");

			await GetAsync("https://auth.literotica.com/", $"check?timestamp={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}");

			await GetAsync("https://literotica.com/", "api/3/users/session");

			List<Cookie> cookies = CookieContainer.GetAllCookies();

			return cookies.Any(x => x.Name == "auth_token");
		}

		private async Task<string?> CreateRequest(HttpMethod httpMethod, string baseUrl, string endPoint, HttpContent? content = null)
		{
			if (endPoint != "login" && !_loggedIn)
				throw new Exception("Not logged in. Please login before making requests.");

			if (string.IsNullOrEmpty(baseUrl)) return string.Empty;

			if (!string.IsNullOrEmpty(endPoint))
			{
				if (baseUrl[^1] == '/' && endPoint[0] == '/') endPoint = endPoint[1..]; // Make sure the slash isn't duplicated
				if (baseUrl[^1] != '/' && endPoint[0] != '/') baseUrl += "/"; // Make sure it actually contains a slash
			}

			const int maxRetries = 3;
			int retryCount = 0;
			int backoffDelayMs = 5000;

			while (retryCount < maxRetries)
			{
				// Set authentication headers
				using HttpRequestMessage httpRequest = new();
				httpRequest.Method = MapHttpMethod(httpMethod);
				httpRequest.RequestUri = new Uri($"{baseUrl}{endPoint}");
				httpRequest.Content = content;

				using HttpResponseMessage responseMessage = await _client.SendAsync(httpRequest, HttpCompletionOption.ResponseContentRead).ConfigureAwait(false);
				string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

				HttpStatusCode statusCode = responseMessage.StatusCode;

				switch ((int)statusCode)
				{
					case 200:
						if (endPoint == "login")
							_loggedIn = true;
						return responseContent;
					case 401:
					case 403:
						if (endPoint == "login") throw new LitEroticaApiException(responseContent);
						throw new Exception("Authorization invalid or expired.");
					case 429:
						await Task.Delay(backoffDelayMs).ConfigureAwait(false);
						backoffDelayMs *= 2;
						break;
					case 404:
						return null;
					default:
						throw new Exception($"\n[Log] Uri:{baseUrl}{endPoint}\n[Log] Request Headers:{JsonSerializer.Serialize(_client.DefaultRequestHeaders)}\n[Log] Request Content: {JsonSerializer.Serialize(content)}\n[Log] Response Content:{responseContent}\n[Log] Response Data: {responseMessage}");
				}

				retryCount++;

				if (backoffDelayMs == 5000)
					return responseContent;
			}

			throw new Exception($"[Log] Failed after {maxRetries} retries. Uri:{baseUrl}{endPoint}");
		}

		internal async Task<T?> GetAsync<T>(string baseUrl, string endPoint)
			=> await SendAndConvertAsync<T>(HttpMethod.Get, baseUrl, endPoint).ConfigureAwait(false);

		internal async Task<T?> PostAsync<T>(string baseUrl, string endPoint, HttpContent? httpContent = null)
			=> await SendAndConvertAsync<T>(HttpMethod.Post, baseUrl, endPoint, httpContent).ConfigureAwait(false);

		internal async Task<T?> PutAsync<T>(string baseUrl, string endPoint, HttpContent? httpContent = null)
			=> await SendAndConvertAsync<T>(HttpMethod.Put, baseUrl, endPoint, httpContent).ConfigureAwait(false);

		internal async Task<T?> DeleteAsync<T>(string baseUrl, string endPoint, HttpContent? httpContent = null)
			=> await SendAndConvertAsync<T>(HttpMethod.Delete, baseUrl, endPoint, httpContent).ConfigureAwait(false);

		internal async Task<T?> OptionsAsync<T>(string baseUrl, string endPoint)
			=> await SendAndConvertAsync<T>(HttpMethod.Options, baseUrl, endPoint).ConfigureAwait(false);

		internal async Task<T?> HeadAsync<T>(string baseUrl, string endPoint)
			=> await SendAndConvertAsync<T>(HttpMethod.Head, baseUrl, endPoint).ConfigureAwait(false);

		internal async Task<T?> OptionsAsync<T>(string baseUrl, string endPoint, HttpContent? httpContent)
			=> await SendAndConvertAsync<T>(HttpMethod.Options, baseUrl, endPoint, httpContent).ConfigureAwait(false);

		internal async Task GetAsync(string baseUrl, string endPoint)
			=> await CreateRequest(HttpMethod.Get, baseUrl, endPoint).ConfigureAwait(false);

		internal async Task PostAsync(string baseUrl, string endPoint, HttpContent? httpContent = null)
			=> await CreateRequest(HttpMethod.Post, baseUrl, endPoint, httpContent).ConfigureAwait(false);

		internal async Task PutAsync(string baseUrl, string endPoint, HttpContent? httpContent = null)
			=> await CreateRequest(HttpMethod.Put, baseUrl, endPoint, httpContent).ConfigureAwait(false);

		internal async Task DeleteAsync(string baseUrl, string endPoint, HttpContent? httpContent = null)
			=> await CreateRequest(HttpMethod.Delete, baseUrl, endPoint, httpContent).ConfigureAwait(false);

		internal async Task OptionsAsync(string baseUrl, string endPoint)
			=> await CreateRequest(HttpMethod.Options, baseUrl, endPoint).ConfigureAwait(false);

		internal async Task HeadAsync(string baseUrl, string endPoint)
			=> await CreateRequest(HttpMethod.Head, baseUrl, endPoint).ConfigureAwait(false);

		internal async Task OptionsAsync(string baseUrl, string endPoint, HttpContent? httpContent)
			=> await CreateRequest(HttpMethod.Options, baseUrl, endPoint, httpContent).ConfigureAwait(false);

		private async Task<T?> SendAndConvertAsync<T>(HttpMethod method, string baseUrl, string endPoint, HttpContent? httpContent = null)
			=> ConvertResponse<T>(await CreateRequest(method, baseUrl, endPoint, httpContent).ConfigureAwait(false));

#pragma warning disable IDE0046 // Convert if possible
		private static T? ConvertResponse<T>(string? jsonData)
		{
			try
			{
				if (string.IsNullOrEmpty(jsonData) || string.Equals(jsonData!.Trim(), "null", StringComparison.OrdinalIgnoreCase))
					return default;

				Type targetType = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);

				if (targetType == typeof(string))
					return (T)(object)jsonData;

				if (targetType == typeof(int) && int.TryParse(jsonData, out int intValue))
					return (T)Convert.ChangeType(intValue, targetType);

				if (targetType == typeof(long) && long.TryParse(jsonData, out long longValue))
					return (T)Convert.ChangeType(longValue, targetType);

				if (targetType == typeof(bool) && bool.TryParse(jsonData, out bool boolValue))
					return (T)Convert.ChangeType(boolValue, targetType);

				if (targetType == typeof(double) && double.TryParse(jsonData, out double doubleValue))
					return (T)Convert.ChangeType(doubleValue, targetType);

				if (targetType == typeof(decimal) && decimal.TryParse(jsonData, out decimal decimalValue))
					return (T)Convert.ChangeType(decimalValue, targetType);

				if (targetType == typeof(float) && float.TryParse(jsonData, out float floatValue))
					return (T)Convert.ChangeType(floatValue, targetType);

				if (targetType == typeof(DateTime) && DateTime.TryParse(jsonData, out DateTime dateValue))
					return (T)Convert.ChangeType(dateValue, targetType);

				if (targetType == typeof(Guid) && Guid.TryParse(jsonData, out Guid guidValue))
					return (T)Convert.ChangeType(guidValue, targetType);
				
				return JsonSerializer.Deserialize<T>(jsonData);
			}
			catch
			{
				throw new Exception($"Failed to parse datatype: {typeof(T)}, given data: {jsonData}");
			}
		}
	}

}
