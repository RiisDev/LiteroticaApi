# Client

Namespace: LiteroticaApi

Provides a centralized HTTP client used by the Literotica API SDK.
 This static client manages all outbound HTTP requests and supports both
 a default internal client and user-supplied custom clients.

```csharp
public static class Client
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Client](./literoticaapi/client.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **HttpClientInstance**

Gets or sets the active  instance used by all API operations.

```csharp
public static HttpClient HttpClientInstance { get; set; }
```

#### Property Value

HttpClient<br>

**Remarks:**

By default, this property returns the internal shared client.
 If you wish to override it with your own client (for example, to
 add custom headers, proxy configurations, or handlers), simply set
 [Client.HttpClientInstance](./literoticaapi/client.md#httpclientinstance) to your own .
