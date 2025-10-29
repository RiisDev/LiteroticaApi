# UsersApi

Namespace: LiteroticaApi.Api

Provides asynchronous methods for retrieving users-related data from the Literotica API.

```csharp
public static class UsersApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [UsersApi](./literoticaapi/api/usersapi.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Methods

### **GetFollowersAsync(String, Int32, Int32)**

Retrieves a paginated list of followers for a specified author.

```csharp
public static Task<Followers> GetFollowersAsync(string username, int page, int pageSize)
```

#### Parameters

`username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The username of the author.

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of followers per page. Defaults to 50, maximum 200.

#### Returns

[Task&lt;Followers&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. The task result contains a [Followers](./literoticaapi/dataobjects/followers.md) object.

### **GetListsAsync(String, Int32, Int32)**

Retrieves a paginated list of reading lists created by a specified author.

```csharp
public static Task<IReadOnlyList<BookList>> GetListsAsync(string username, int page, int pageSize)
```

#### Parameters

`username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The username of the author.

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of lists per page. Defaults to 50, maximum 200.

#### Returns

[Task&lt;IReadOnlyList&lt;BookList&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. The task result contains a list of [BookList](./literoticaapi/dataobjects/booklist.md) objects,
 or `null` if no lists were found.

### **GetFavoritesAsync(String, WorkTypes, Int32, Int32)**

Retrieves a paginated list of works that a specified user has marked as favourites.

```csharp
public static Task<FavouriteWork> GetFavoritesAsync(string username, WorkTypes workType, int page, int pageSize)
```

#### Parameters

`username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The username of the user whose favourite works are being retrieved.

`workType` [WorkTypes](./literoticaapi/types/worktypes.md)<br>
The type of work to retrieve. 
 This value is defined by  (e.g., story, series, poem, etc.).

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of results per page. Defaults to 50, maximum 200.

#### Returns

[Task&lt;FavouriteWork&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [FavouriteWork](./literoticaapi/dataobjects/favouritework.md) object that includes the user's favourite works.

### **GetFavoriteAuthorsAsync(String, Int32, Int32)**

Retrieves a paginated list of authors that a specified user has marked as favourites.

```csharp
public static Task<FavouriteAuthor> GetFavoriteAuthorsAsync(string username, int page, int pageSize)
```

#### Parameters

`username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The username of the user whose favourite authors are being retrieved.

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of results per page. Defaults to 50, maximum 200.

#### Returns

[Task&lt;FavouriteAuthor&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [FavouriteAuthor](./literoticaapi/dataobjects/favouriteauthor.md) object that includes the user's favourite authors.
