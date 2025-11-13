# CommentsApi

Namespace: LiteroticaApi.Api

Provides asynchronous methods for retrieving comment-related data from the Literotica API.

```csharp
public static class CommentsApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CommentsApi](./literoticaapi/api/commentsapi.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Methods

### **GetTopCommenters(WorkTypes, Period, Int32, Int32, Languages)**

Retrieves a paginated list of the top commenters for a specific work type and time period.

```csharp
public static Task<TopCommenters> GetTopCommenters(WorkTypes type, Period period, int page, int pageSize, Languages language)
```

#### Parameters

`type` [WorkTypes](./literoticaapi/types/worktypes.md)<br>
The type of work to retrieve top commenters for. 
 This value is defined by  (e.g., story, series, poem, etc.).

`period` [Period](./literoticaapi/types/period.md)<br>
The time period over which to calculate top commenters, defined by .

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of results per page. Defaults to 20.

`language` [Languages](./literoticaapi/types/languages.md)<br>
The language.

#### Returns

[Task&lt;TopCommenters&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [TopCommenters](./literoticaapi/dataobjects/topcommenters.md) object with information about the most active commenters.

### **GetRecentComments(WorkTypes, Int32, Period, Languages)**

Retrieves a list of the most recent comments for a specific work type.

```csharp
public static Task<IReadOnlyList<RecentComment>> GetRecentComments(WorkTypes type, int limit, Period period, Languages language)
```

#### Parameters

`type` [WorkTypes](./literoticaapi/types/worktypes.md)<br>
The type of work to retrieve recent comments for. 
 This value is defined by  (e.g., story, series, poem, etc.).

`limit` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The maximum number of comments to retrieve. Defaults to 35.

`period` [Period](./literoticaapi/types/period.md)<br>
The time period filter for comments, defined by . 
 Defaults to .

`language` [Languages](./literoticaapi/types/languages.md)<br>
The language.

#### Returns

[Task&lt;IReadOnlyList&lt;RecentComment&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a list of [RecentComment](./literoticaapi/dataobjects/recentcomment.md) objects representing the latest comments.

### **GetStoryComments(String, Int32, Int32)**

Retrieves the full comment history for a specific story, including pagination and sorting.

```csharp
public static Task<CommentHistory> GetStoryComments(string storyUrl, int page, int limit)
```

#### Parameters

`storyUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL or slug of the story whose comment history should be retrieved.

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`limit` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of comments per page. Defaults to 100.

#### Returns

[Task&lt;CommentHistory&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [CommentHistory](./literoticaapi/dataobjects/commenthistory.md) object that includes comment details and metadata.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
Thrown when the story slug cannot be extracted from the provided `storyUrl`.

**Remarks:**

This method uses [UrlUtil.GetStorySlug(String)](./literoticaapi/util/urlutil.md#getstoryslugstring) to resolve the story slug before performing the API request.
