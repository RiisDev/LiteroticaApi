# AuthClient

Namespace: LiteroticaApi.AuthClientData

Provides a centralized HTTP client used by the Literotica API SDK.
 This static client manages all outbound HTTP requests and supports both
 a default internal client and user-supplied custom clients.

```csharp
public class AuthClient
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AuthClient](./literoticaapi/authclientdata/authclient.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **Activity**

Provides access to the authenticated Stories API

```csharp
public Activity Activity { get; }
```

#### Property Value

[Activity](./literoticaapi/authclientdata/activity.md)<br>

### **User**

Provides access to the authenticated User API

```csharp
public User User { get; }
```

#### Property Value

[User](./literoticaapi/authclientdata/user.md)<br>

## Constructors

### **AuthClient()**

General AuthClient builder to access authenticated endpoints.

```csharp
public AuthClient()
```

## Methods

### **LoginAsync(String, String)**

Attempts to authenticate a user with the Literotica API using the provided credentials.

```csharp
public Task<bool> LoginAsync(string username, string password)
```

#### Parameters

`username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The Literotica account username.

`password` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The Literotica account password.

#### Returns

[Task&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean) indicating whether authentication was successful.

#### Exceptions

[LitEroticaApiException](./literoticaapi/literoticaapiexception.md)<br>
Thrown when the API returns an invalid or error response.

[LitEroticaInternalException](./literoticaapi/literoticainternalexception.md)<br>
Thrown when a network or internal error occurs.
