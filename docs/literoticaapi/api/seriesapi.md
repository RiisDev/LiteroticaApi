# SeriesApi

Namespace: LiteroticaApi.Api

Provides asynchronous methods for retrieving series-related data from the Literotica API.

```csharp
public static class SeriesApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SeriesApi](./literoticaapi/api/seriesapi.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Methods

### **GetSeriesInfoAsync(String)**

Retrieves detailed information about a specific series from its URL.

```csharp
public static Task<Series> GetSeriesInfoAsync(string seriesUrl)
```

#### Parameters

`seriesUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL of the series to retrieve information for.

#### Returns

[Task&lt;Series&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [Series](./literoticaapi/dataobjects/series.md) object with full series metadata,
 or `null` if the series could not be found.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
Thrown if the series URL is invalid, the author data cannot be retrieved,
 or the author username cannot be determined.

### **GetSeriesCoverAsync(String)**

Retrieves the cover image metadata for a specific series.

```csharp
public static Task<Cover> GetSeriesCoverAsync(string seriesUrl)
```

#### Parameters

`seriesUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL of the series whose cover should be retrieved.

#### Returns

[Task&lt;Cover&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [Cover](./literoticaapi/dataobjects/cover.md) object with the cover image details.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
Thrown if the provided `seriesUrl` is invalid.

### **GetSeriesWorksAsync(String)**

Retrieves all individual works (stories) associated with a given series.

```csharp
public static Task<IReadOnlyList<Story>> GetSeriesWorksAsync(string seriesUrl)
```

#### Parameters

`seriesUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL of the series to retrieve works from.

#### Returns

[Task&lt;IReadOnlyList&lt;Story&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a read-only list of [Story](./literoticaapi/dataobjects/story.md) objects
 that belong to the specified series.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
Thrown if the provided `seriesUrl` is invalid.

### **GetRecentlyUpdatedAsync(Categories)**

Retrieves a list of recently updated series within the specified category.

```csharp
public static Task<IReadOnlyList<Works>> GetRecentlyUpdatedAsync(Categories categories)
```

#### Parameters

`categories` [Categories](./literoticaapi/types/categories.md)<br>
The category to filter series by, defined in .

#### Returns

[Task&lt;IReadOnlyList&lt;Works&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a read-only list of [Works](./literoticaapi/dataobjects/works.md) objects representing updated series.

### **GetMostDiscussedAsync(Categories)**

Retrieves a list of the most discussed series within a specified category.

```csharp
public static Task<IReadOnlyList<Works>> GetMostDiscussedAsync(Categories categories)
```

#### Parameters

`categories` [Categories](./literoticaapi/types/categories.md)<br>
The category to filter series by, defined in .

#### Returns

[Task&lt;IReadOnlyList&lt;Works&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a read-only list of [Works](./literoticaapi/dataobjects/works.md) objects representing active discussion series.

### **GetMostFavoritedAsync(Categories)**

Retrieves a list of the most favorited series within the specified category.

```csharp
public static Task<IReadOnlyList<Works>> GetMostFavoritedAsync(Categories categories)
```

#### Parameters

`categories` [Categories](./literoticaapi/types/categories.md)<br>
The category to filter series by, defined in .

#### Returns

[Task&lt;IReadOnlyList&lt;Works&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a read-only list of [Works](./literoticaapi/dataobjects/works.md) objects representing favorited series.

### **GetRecentlyStartedAsync(Categories)**

Retrieves a list of the most recently started series within the specified category.

```csharp
public static Task<IReadOnlyList<Works>> GetRecentlyStartedAsync(Categories categories)
```

#### Parameters

`categories` [Categories](./literoticaapi/types/categories.md)<br>
The category to filter series by, defined in .

#### Returns

[Task&lt;IReadOnlyList&lt;Works&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a read-only list of [Works](./literoticaapi/dataobjects/works.md) objects representing newly started series.

### **GetLongestRunningAsync(Categories)**

Retrieves a list of the longest-running series within the specified category.

```csharp
public static Task<IReadOnlyList<Works>> GetLongestRunningAsync(Categories categories)
```

#### Parameters

`categories` [Categories](./literoticaapi/types/categories.md)<br>
The category to filter series by, defined in .

#### Returns

[Task&lt;IReadOnlyList&lt;Works&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a read-only list of [Works](./literoticaapi/dataobjects/works.md) objects representing long-running series.

### **GetRandomAsync(Categories)**

Retrieves a random selection of series within the specified category.

```csharp
public static Task<IReadOnlyList<Works>> GetRandomAsync(Categories category)
```

#### Parameters

`category` [Categories](./literoticaapi/types/categories.md)<br>
The category to filter series by, defined in .

#### Returns

[Task&lt;IReadOnlyList&lt;Works&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a read-only list of randomly selected [Works](./literoticaapi/dataobjects/works.md) objects.

### **GetSeriesBySort(Categories, Char, Int32, Languages)**

Retrieves a paginated list of series in a category sorted alphabetically by a specified starting letter.

```csharp
public static Task<IReadOnlyList<Works>> GetSeriesBySort(Categories category, char letter, int page, Languages language)
```

#### Parameters

`category` [Categories](./literoticaapi/types/categories.md)<br>
The category to filter series by, defined in .

`letter` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The first letter of the series titles to retrieve (A–Z).

`page` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page number to retrieve. Defaults to 1.

`language` [Languages](./literoticaapi/types/languages.md)<br>
The language.

#### Returns

[Task&lt;IReadOnlyList&lt;Works&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a read-only list of [Works](./literoticaapi/dataobjects/works.md) objects that match the specified criteria.
