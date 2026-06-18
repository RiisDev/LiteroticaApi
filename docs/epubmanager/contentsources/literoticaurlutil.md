# LiteroticaUrlUtil

Namespace: EpubManager.ContentSources

Adds base util to Literotica story writer.

```csharp
public class LiteroticaUrlUtil : IStoryWriterUtil
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [LiteroticaUrlUtil](./epubmanager/contentsources/literoticaurlutil.md)<br>
Implements [IStoryWriterUtil](./epubmanager/contentsources/istorywriterutil.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Constructors

### **LiteroticaUrlUtil()**

```csharp
public LiteroticaUrlUtil()
```

## Methods

### **GetStorySlugAsync(String)**

Extracts the story slug from a Literotica story URL.

```csharp
public Task<string> GetStorySlugAsync(string url)
```

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The full URL of the story (e.g., `https://www.literotica.com/s/example-story`).

#### Returns

[Task&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
The story slug extracted from the URL (e.g., `example-story`).

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
Thrown when the URL does not contain a valid or verifiable story slug.

**Remarks:**

This method supports multiple URL formats:

- - `/s/{slug}`
- - `/story/{slug}`
- - `/stories/{slug}`

The slug is validated using [LiteroticaUrlUtil.VerifySlugAsync(String)](./epubmanager/contentsources/literoticaurlutil.md#verifyslugasyncstring).

### **GetSeriesIdAsync(String)**

Extracts the numeric series ID from a Literotica series URL.

```csharp
public Task<string> GetSeriesIdAsync(string url)
```

#### Parameters

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The full URL of the series (e.g., `https://www.literotica.com/se/12345`).

#### Returns

[Task&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
The series ID extracted from the URL.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
Thrown when the URL does not contain a valid or verifiable series ID.

**Remarks:**

The series ID is validated using [LiteroticaUrlUtil.VerifySeriesIdAsync(String)](./epubmanager/contentsources/literoticaurlutil.md#verifyseriesidasyncstring).

### **VerifySeriesIdAsync(String)**

Asynchronously verifies whether the specified series ID exists on Literotica by sending a HEAD request to the API.

```csharp
public Task<bool> VerifySeriesIdAsync(string seriesId)
```

#### Parameters

`seriesId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The unique identifier of the series to verify. Can be null or empty, but such values will result in a failed
 verification.

#### Returns

[Task&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task that represents the asynchronous operation. The task result is  if the series ID
 exists; otherwise, .

**Remarks:**

This method does not throw an exception for non-existent series IDs; it returns  if the series is not found or if the request fails. Network errors or invalid IDs may also
 result in a  return value.

### **VerifySlugAsync(String)**

Checks whether a story slug exists on Literotica by sending a HEAD request to the API.

```csharp
public Task<bool> VerifySlugAsync(string slug)
```

#### Parameters

`slug` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The slug identifier of the story to verify. Can be null or empty; if so, the method will return false.

#### Returns

[Task&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task that represents the asynchronous operation. The task result is  if the slug exists;
 otherwise, .

**Remarks:**

This method performs a network request to Literotica's API. The operation may fail or return
 false if the slug is invalid, does not exist, or if there are network issues.
