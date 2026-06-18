# IStoryWriter

Namespace: EpubManager.ContentSources

Defines methods for logging messages and generating EPUB files from online story or series sources.

```csharp
public interface IStoryWriter
```

Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md)

**Remarks:**

Implementations of this interface provide functionality to create EPUB files from specified story
 or series URLs, with options for customizing output and logging progress or errors. Methods are asynchronous and
 may perform network and file system operations.

## Methods

### **Log(String)**

Writes the specified message to the log output.

```csharp
void Log(string message)
```

#### Parameters

`message` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The message to be logged. Cannot be null.

### **CreateEpubFromSeriesAsync(String, String, String, Boolean, Int32, Int32)**

Asynchronously creates an EPUB file from the specified series URL and saves it to the given output directory.

```csharp
Task CreateEpubFromSeriesAsync(string seriesUrl, string outputDirectory, string coverOverwrite, bool raw, int startIndex, int endIndex)
```

#### Parameters

`seriesUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL of the series to download and convert to EPUB. Must be a valid, accessible series URL.

`outputDirectory` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The directory where the generated EPUB file will be saved. Must be a valid path with write permissions.

`coverOverwrite` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The file path to a custom cover image to use for the EPUB. If empty, the default series cover is used.

`raw` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If , downloads the raw, unprocessed content; otherwise, applies formatting and processing.

`startIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The zero-based index of the first chapter to include. Must be greater than or equal to zero.

`endIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The zero-based index of the last chapter to include. If zero, all chapters from `startIndex`
 onward are included.

#### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)<br>
A task that represents the asynchronous operation of creating the EPUB file.

### **CreateEpubFromStoryAsync(String, String, String, Boolean)**

Asynchronously creates an EPUB file from the specified story URL and saves it to the given output directory.

```csharp
Task CreateEpubFromStoryAsync(string storyUrl, string outputDirectory, string coverOverwrite, bool raw)
```

#### Parameters

`storyUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL of the story to download and convert to EPUB format. Must be a valid, accessible URL.

`outputDirectory` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The directory where the generated EPUB file will be saved. Must exist and be writable.

`coverOverwrite` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The file path to a custom cover image to use for the EPUB. If empty, the default cover is used.

`raw` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Specifies whether to use the raw, unprocessed version of the story. If , the EPUB will
 contain the original content without formatting; otherwise, formatting is applied.

#### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)<br>
A task that represents the asynchronous operation of creating the EPUB file.
