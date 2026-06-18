# IStoryWriterUtil

Namespace: EpubManager.ContentSources

Provides utility methods for retrieving and validating story-related identifiers, such as slugs and series IDs,
 from external sources.

```csharp
public interface IStoryWriterUtil
```

Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md)

**Remarks:**

Implementations of this interface typically interact with remote services or data sources to
 extract or verify story information. Methods are asynchronous and may involve network operations. Callers should
 handle potential exceptions related to connectivity or invalid input as appropriate.

## Methods

### **GetStorySlugAsync(String)**

Asynchronously retrieves the story slug from the specified story URL.

```csharp
Task<string> GetStorySlugAsync(string url)
```

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL of the story from which to extract the slug. Cannot be null or empty.

#### Returns

[Task&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task that represents the asynchronous operation. The task result contains the slug string extracted from the
 story URL, or null if the slug cannot be determined.

### **GetSeriesIdAsync(String)**

Asynchronously retrieves the unique series identifier from the specified URL.

```csharp
Task<string> GetSeriesIdAsync(string url)
```

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL of the series page from which to extract the series identifier. Cannot be null or empty.

#### Returns

[Task&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task that represents the asynchronous operation. The task result contains the series identifier as a string, or
 null if the identifier cannot be found.

### **VerifySlugAsync(String)**

Asynchronously verifies whether the specified slug is valid and available for use.

```csharp
Task<bool> VerifySlugAsync(string slug)
```

#### Parameters

`slug` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The slug to validate. Can be null. If null or empty, the method returns .

#### Returns

[Task&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task that represents the asynchronous operation. The task result is  if the slug is valid
 and available; otherwise, .

### **VerifySeriesIdAsync(String)**

Asynchronously verifies whether the specified series identifier exists and is valid.

```csharp
Task<bool> VerifySeriesIdAsync(string seriesId)
```

#### Parameters

`seriesId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The series identifier to verify. Can be null or empty; if so, the method returns .

#### Returns

[Task&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task that represents the asynchronous operation. The task result is  if the series
 identifier is valid; otherwise, .
