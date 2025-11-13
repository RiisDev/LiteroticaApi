# User

Namespace: LiteroticaApi.AuthClientData

Provides methods to interact with user-specific endpoints of the Literotica API.

```csharp
public class User
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [User](./literoticaapi/authclientdata/user.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Constructors

### **User(AuthClient)**

Provides methods to interact with user-specific endpoints of the Literotica API.

```csharp
public User(AuthClient client)
```

#### Parameters

`client` [AuthClient](./literoticaapi/authclientdata/authclient.md)<br>

## Methods

### **GetSessionAsync()**

Retrieves the current session information for the authenticated user.

```csharp
public Task<SessionInfo> GetSessionAsync()
```

#### Returns

[Task&lt;SessionInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A [SessionInfo](./literoticaapi/authclientdata/dataobjects/sessioninfo.md) object containing user session data if available; otherwise, .

### **GetListsAsync()**

Retrieves all lists associated with the authenticated user.

```csharp
public Task<IReadOnlyList<List>> GetListsAsync()
```

#### Returns

[Task&lt;IReadOnlyList&lt;List&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A read-only list of [List](./literoticaapi/authclientdata/dataobjects/list.md) objects representing the user’s story collections or lists;

### **GetFollowingAsync()**

Retrieves a list of authors that the authenticated user is following.

```csharp
public Task<IReadOnlyList<Author>> GetFollowingAsync()
```

#### Returns

[Task&lt;IReadOnlyList&lt;Author&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A read-only list of [Author](./literoticaapi/dataobjects/author.md) objects representing followed authors;

### **GetFollowersAsync()**

Retrieves a list of users following the authenticated user.

```csharp
public Task<IReadOnlyList<Author>> GetFollowersAsync()
```

#### Returns

[Task&lt;IReadOnlyList&lt;Author&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A read-only list of [Author](./literoticaapi/dataobjects/author.md) objects representing followers;

### **GetFavoriteStoriesAsync(Int32, FavoriteStorySort)**

Retrieves the authenticated user's favorite stories, optionally filtered by page and sort order.

```csharp
public Task<FavoriteStories> GetFavoriteStoriesAsync(int page, FavoriteStorySort sortBy)
```

#### Parameters

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve (default is 1).

`sortBy` [FavoriteStorySort](./literoticaapi/types/favoritestorysort.md)<br>
The sorting method to use (default is ).

#### Returns

[Task&lt;FavoriteStories&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A [FavoriteStories](./literoticaapi/authclientdata/dataobjects/favoritestories.md) object containing paginated story data;

### **GetAvailableEditorsAsync(Int32, Nullable&lt;EditorSort&gt;, Categories[], Languages[], Nullable&lt;EditorFormats&gt;)**

Retrieves a paginated list of available editors with optional sorting and filtering criteria.

```csharp
public Task<Editors> GetAvailableEditorsAsync(int page, Nullable<EditorSort> sort, Categories[] categories, Languages[] languages, Nullable<EditorFormats> formats)
```

#### Parameters

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve (default is 1).

`sort` [Nullable&lt;EditorSort&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Optional sorting method for editor results (e.g. ).

`categories` [Categories[]](./literoticaapi/types/categories.md)<br>
Optional category filters based on  values.

`languages` [Languages[]](./literoticaapi/types/languages.md)<br>
Optional language filters based on  values.

`formats` [Nullable&lt;EditorFormats&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Optional filter for supported editor formats, using  flags.

#### Returns

[Task&lt;Editors&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
An [Editors](./literoticaapi/authclientdata/dataobjects/editors.md) object containing paginated editor results;
