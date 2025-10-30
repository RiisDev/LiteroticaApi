# StoryApi

Namespace: LiteroticaApi.Api

Provides asynchronous methods for retrieving stories-related data from the Literotica API.

```csharp
public static class StoryApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [StoryApi](./literoticaapi/api/storyapi.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Methods

### **GetStoryContentAsync(String)**

Retrieves the full text content of a story by its URL, including all pages.

```csharp
public static Task<String[]> GetStoryContentAsync(string storyUrl)
```

#### Parameters

`storyUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The full URL of the story to retrieve. 
 Example: `https://www.literotica.com/s/story-title`.

#### Returns

[Task&lt;String[]&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains an array of strings, where each entry represents the text content of one page.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
Thrown if the story cannot be parsed or retrieved from the API.

### **GetStoryInfoAsync(String)**

Retrieves detailed information about a specific story by its URL.

```csharp
public static Task<StoryInfo> GetStoryInfoAsync(string storyUrl)
```

#### Parameters

`storyUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL of the story to retrieve information for.

#### Returns

[Task&lt;StoryInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [StoryInfo](./literoticaapi/dataobjects/storyinfo.md) object with metadata about the story, or `null` if not found.

### **GetTopFavoritedAsync(Period, WorkTypes, Int32, Int32)**

Retrieves the top favorited stories within a specified period and work type.

```csharp
public static Task<Top> GetTopFavoritedAsync(Period period, WorkTypes type, int page, int pageSize)
```

#### Parameters

`period` [Period](./literoticaapi/types/period.md)<br>
The time period to filter results by, defined in .

`type` [WorkTypes](./literoticaapi/types/worktypes.md)<br>
The work type to filter by, defined in .

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of results per page. Defaults to 35.

#### Returns

[Task&lt;Top&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [Top](./literoticaapi/dataobjects/top.md) object with the top favorited stories.

### **GetNewAsync(Period, WorkTypes, Int32, Int32)**

Retrieves a paginated list of the newest stories for the specified period and type.

```csharp
public static Task<GetNew> GetNewAsync(Period period, WorkTypes type, int page, int pageSize)
```

#### Parameters

`period` [Period](./literoticaapi/types/period.md)<br>
The time period to filter by, defined in .

`type` [WorkTypes](./literoticaapi/types/worktypes.md)<br>
The work type to filter by, defined in .

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of results per page. Defaults to 75.

#### Returns

[Task&lt;GetNew&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [GetNew](./literoticaapi/dataobjects/getnew.md) object with the list of newest stories.

### **GetTopCommentedAsync(Period, WorkTypes, Int32, Int32)**

Retrieves the top commented stories for a specific period and type.

```csharp
public static Task<Top> GetTopCommentedAsync(Period period, WorkTypes type, int page, int pageSize)
```

#### Parameters

`period` [Period](./literoticaapi/types/period.md)<br>
The time period to filter by, defined in .

`type` [WorkTypes](./literoticaapi/types/worktypes.md)<br>
The work type to filter by, defined in .

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of results per page. Defaults to 15.

#### Returns

[Task&lt;Top&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [Top](./literoticaapi/dataobjects/top.md) object with the top commented stories.

### **GetRecommendedAsync(WorkTypes, Int32)**

Retrieves a list of recommended stories for a given work type.

```csharp
public static Task<List<Submission>> GetRecommendedAsync(WorkTypes type, int limit)
```

#### Parameters

`type` [WorkTypes](./literoticaapi/types/worktypes.md)<br>
The type of work to retrieve recommendations for, defined in .

`limit` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The maximum number of recommended stories to retrieve. Defaults to 10.

#### Returns

[Task&lt;List&lt;Submission&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a list of [Submission](./literoticaapi/dataobjects/submission.md) objects representing recommended stories.

### **SearchForStoriesAsync(String, Categories[], Int32, Nullable&lt;WorkTypes&gt;, Boolean, Boolean, Boolean, Int32[])**

Searches for stories by keyword, with optional filters for categories, type, and other attributes.

```csharp
public static Task<Search> SearchForStoriesAsync(string query, Categories[] categories, int page, Nullable<WorkTypes> type, bool editorsChoice, bool popular, bool winner, Int32[] languages)
```

#### Parameters

`query` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The search query string.

`categories` [Categories[]](./literoticaapi/types/categories.md)<br>
An array of categories to filter results by.

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`type` [Nullable&lt;WorkTypes&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Optional work type filter, defined in .

`editorsChoice` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If true, limits results to editor's choice stories.

`popular` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If true, limits results to popular stories.

`winner` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If true, limits results to contest-winning stories.

`languages` [Int32[]](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
Optional array of language IDs. Defaults to English (1).

#### Returns

[Task&lt;Search&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [Search](./literoticaapi/dataobjects/search.md) object with paginated search results.

### **SearchForStoriesByTagsAsync(Int32[], Int32, Int32, Period, Boolean)**

Searches for stories that match one or more specified tag IDs.

```csharp
public static Task<SearchByTag> SearchForStoriesByTagsAsync(Int32[] tagIds, int page, int pageSize, Period period, bool periodCheck)
```

#### Parameters

`tagIds` [Int32[]](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
An array of tag IDs to filter by.

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`pageSize` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of results per page. Defaults to 100.

`period` [Period](./literoticaapi/types/period.md)<br>
The time period to filter results by, defined in .

`periodCheck` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Determines whether to apply period filtering. Defaults to true.

#### Returns

[Task&lt;SearchByTag&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [SearchByTag](./literoticaapi/dataobjects/searchbytag.md) object with matching stories.

### **GetRandomStoriesAsync()**

Retrieves a random selection of stories from the server.

```csharp
public static Task<List<StoryDetails>> GetRandomStoriesAsync()
```

#### Returns

[Task&lt;List&lt;StoryDetails&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a list of [StoryDetails](./literoticaapi/dataobjects/storydetails.md) objects representing random stories.
