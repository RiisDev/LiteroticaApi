# AuthorsApi

Namespace: LiteroticaApi.Api

Provides asynchronous methods for retrieving author-related data from the Literotica API.

```csharp
public static class AuthorsApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AuthorsApi](./literoticaapi/api/authorsapi.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Methods

### **GetAuthorByIdAsync(Int32)**

Retrieves an [Author](./literoticaapi/dataobjects/author.md) by their numeric author ID.

```csharp
public static Task<Author> GetAuthorByIdAsync(int authorId)
```

#### Parameters

`authorId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The unique identifier of the author.

#### Returns

[Task&lt;Author&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. The task result contains the [Author](./literoticaapi/dataobjects/author.md) object,
 or `null` if the author could not be found.

#### Exceptions

[LitEroticaApiException](./literoticaapi/literoticaapiexception.md)<br>
Thrown when the API response contains null or invalid data.

### **GetAuthorByUsernameAsync(String)**

Retrieves an [Author](./literoticaapi/dataobjects/author.md) by their username.

```csharp
public static Task<Author> GetAuthorByUsernameAsync(string username)
```

#### Parameters

`username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The username of the author.

#### Returns

[Task&lt;Author&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. The task result contains the [Author](./literoticaapi/dataobjects/author.md) object,
 or `null` if the author does not exist.

### **GetWorksAsync(String, Int32, Int32, SortType)**

Retrieves a paginated list of an author's works, such as stories and series.

```csharp
public static Task<WorksData> GetWorksAsync(string username, int page, int pageSize, SortType sortType)
```

#### Parameters

`username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The username of the author.

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of items per page. Defaults to 150, maximum 500.

`sortType` [SortType](./literoticaapi/types/sorttype.md)<br>
The sorting order (alphabetical or by newest). Defaults to alphabetical.

#### Returns

[Task&lt;WorksData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. The task result contains a [WorksData](./literoticaapi/dataobjects/worksdata.md) object
 with the author's works, or `null` if no data was found.

### **GetAllWorksAsync(String)**

Retrieves all works (stories and series) by an author across all pages.

```csharp
public static Task<IReadOnlyList<StoryDatum>> GetAllWorksAsync(string username)
```

#### Parameters

`username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The username of the author.

#### Returns

[Task&lt;IReadOnlyList&lt;StoryDatum&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. The task result contains a list of [StoryDatum](./literoticaapi/dataobjects/storydatum.md) objects.

### **GetSeriesAsync(String)**

Retrieves all series authored by the specified user.

```csharp
public static Task<IReadOnlyList<Series>> GetSeriesAsync(string username)
```

#### Parameters

`username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The username of the author.

#### Returns

[Task&lt;IReadOnlyList&lt;Series&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. The task result contains a list of [Series](./literoticaapi/dataobjects/series.md) objects,
 or `null` if no series were found.

### **GetStoriesAsync(String)**

Retrieves all standalone stories by the specified user (excluding series).

```csharp
public static Task<IReadOnlyList<Story>> GetStoriesAsync(string username)
```

#### Parameters

`username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The username of the author.

#### Returns

[Task&lt;IReadOnlyList&lt;Story&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. The task result contains a list of [Story](./literoticaapi/dataobjects/story.md) objects,
 or `null` if no stories were found.

### **GetNewAuthorsAsync(Int32)**

Retrieves a list of newly joined authors.

```csharp
public static Task<NewAuthors> GetNewAuthorsAsync(int limit)
```

#### Parameters

`limit` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of authors to retrieve. Defaults to 10, maximum 100.

#### Returns

[Task&lt;NewAuthors&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. The task result contains a [NewAuthors](./literoticaapi/dataobjects/newauthors.md) object.

### **GetMostFollowedAsync(Int32, Int32, Period)**

Retrieves a paginated list of the most-followed authors.

```csharp
public static Task<TopFollowedAuthor> GetMostFollowedAsync(int page, int pageSize, Period period)
```

#### Parameters

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of authors per page. Defaults to 50, maximum 200.

`period` [Period](./literoticaapi/types/period.md)<br>
The time period filter (e.g., day, week, month, all). Defaults to .

#### Returns

[Task&lt;TopFollowedAuthor&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. The task result contains a [TopFollowedAuthor](./literoticaapi/dataobjects/topfollowedauthor.md) object.

### **GetMostFavoritedAsync(Int32, Int32, Period, Languages)**

Retrieves a paginated list of the most-favourited authors.

```csharp
public static Task<TopFollowedAuthor> GetMostFavoritedAsync(int page, int pageSize, Period period, Languages language)
```

#### Parameters

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of authors per page. Defaults to 50, maximum 200.

`period` [Period](./literoticaapi/types/period.md)<br>
The time period filter (e.g., day, week, month, all). Defaults to .

`language` [Languages](./literoticaapi/types/languages.md)<br>
The language.

#### Returns

[Task&lt;TopFollowedAuthor&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. The task result contains a [TopFollowedAuthor](./literoticaapi/dataobjects/topfollowedauthor.md) object.
