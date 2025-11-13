using System.Net;

// ReSharper disable CheckNamespace
#pragma warning disable IDE0130

namespace LiteroticaApi.AuthClientData
{
	/// <summary>
	/// Provides a centralized HTTP client used by the Literotica API SDK.
	/// This static client manages all outbound HTTP requests and supports both
	/// a default internal client and user-supplied custom clients.
	/// </summary>
	public class AuthClient
	{
		/// <summary>
		/// Provides access to the authenticated Stories API
		/// </summary>
		public Activity Activity { get; }

		/// <summary>
		/// Provides access to the authenticated User API
		/// </summary>
		public User User { get; }

		/// <summary>
		/// General AuthClient builder to access authenticated endpoints.
		/// </summary>
		public AuthClient()
		{
			Activity = new Activity(this);
			User = new User(this);
		}

		private bool _loggedIn;
		private string? _username; // Cache for if they need to ReAuth
		private string? _password; // Cache for if they need to ReAuth

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
				{"User-Agent", "IrisAgent Nuget_LitEroticaApi/1.0"}
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
		public async Task<bool> LoginAsync(string username, string password)
		{
			_username = username;
			_password = password;

			string? response = await PostAsync<string>("login", JsonContent.Create(new Dictionary<string, string>
			{
				{"login", username},
				{"password", password}
			})).ConfigureAwait(false);

			if (response is not "OK") throw new Exception($"Failed to login: {response}");

			await CreateRequest(HttpMethod.Get, $"check?timestamp={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}").ConfigureAwait(false);
			await CreateRequest(HttpMethod.Get, "users/session").ConfigureAwait(false);

			List<Cookie> cookies = CookieContainer.GetAllCookies();

			return cookies.Any(x => x.Name == "auth_token");
		}

		private async Task<string?> CreateRequest(HttpMethod httpMethod, string endPoint, HttpContent? content = null, object? paramContent = null)
		{
			if (endPoint != "login" && !_loggedIn)
				throw new Exception("Not logged in. Please login before making requests.");

			string baseUrl = "https://literotica.com/api/3/";

			if (endPoint == "login" || endPoint.Contains("check?timestamp"))
				baseUrl = "https://auth.literotica.com/";

			if (endPoint[0] == '/')
				endPoint = endPoint[1..];

			string queryString = paramContent is not null
				? "?params=" + Uri.EscapeDataString(JsonSerializer.Serialize(paramContent))
				: string.Empty;
			
			const int maxRetries = 3;
			int retryCount = 0;
			int backoffDelayMs = 5000;

			while (retryCount < maxRetries)
			{
				using HttpRequestMessage httpRequest = new();
				httpRequest.Method = MapHttpMethod(httpMethod);
				httpRequest.RequestUri = new Uri($"{baseUrl}{endPoint}{queryString}");
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
						await LoginAsync(_username!, _password!);
						break;
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

		internal async Task<T?> GetAsync<T>(string endPoint, object? paramContent = null)
			=> await SendAndConvertAsync<T>(HttpMethod.Get, endPoint, null, paramContent).ConfigureAwait(false);

		internal async Task<T?> PostAsync<T>(string endPoint, HttpContent? httpContent = null, object? paramContent = null)
			=> await SendAndConvertAsync<T>(HttpMethod.Post, endPoint, httpContent, paramContent).ConfigureAwait(false);

		internal async Task<T?> PutAsync<T>(string endPoint, HttpContent? httpContent = null, object? paramContent = null)
			=> await SendAndConvertAsync<T>(HttpMethod.Put, endPoint, httpContent, paramContent).ConfigureAwait(false);

		internal async Task<T?> DeleteAsync<T>(string endPoint, HttpContent? httpContent = null, object? paramContent = null)
			=> await SendAndConvertAsync<T>(HttpMethod.Delete, endPoint, httpContent, paramContent).ConfigureAwait(false);

		internal async Task<T?> OptionsAsync<T>(string endPoint, object? paramContent = null)
			=> await SendAndConvertAsync<T>(HttpMethod.Options, endPoint, null, paramContent).ConfigureAwait(false);

		internal async Task<T?> HeadAsync<T>(string endPoint, object? paramContent = null)
			=> await SendAndConvertAsync<T>(HttpMethod.Head, endPoint, null, paramContent).ConfigureAwait(false);

		internal async Task<T?> OptionsAsync<T>(string endPoint, HttpContent? httpContent, object? paramContent = null)
			=> await SendAndConvertAsync<T>(HttpMethod.Options, endPoint, null, httpContent).ConfigureAwait(false);
		
		private async Task<T?> SendAndConvertAsync<T>(HttpMethod method, string endPoint, HttpContent? httpContent = null, object? paramContent = null)
			=> ConvertResponse<T>(await CreateRequest(method, endPoint, httpContent, paramContent).ConfigureAwait(false));

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
