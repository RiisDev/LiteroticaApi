# Literotica

Namespace: EpubManager.ContentSources

Provides functionality for downloading and converting stories or series from Literotica into EPUB format.

```csharp
public class Literotica : IStoryWriter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Literotica](./epubmanager/contentsources/literotica.md)<br>
Implements [IStoryWriter](./epubmanager/contentsources/istorywriter.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

**Remarks:**

Use the Literotica class to generate EPUB files from either individual stories or entire series
 hosted on Literotica. The class offers asynchronous methods for both scenarios, allowing you to specify output
 directories, custom cover images, and formatting options. This class is intended for use in applications that
 automate the retrieval and conversion of Literotica content for offline reading. All methods require valid
 Literotica URLs and may throw exceptions if the content cannot be found or retrieved.

## Fields

### **UrlUtil**

Provides a shared instance of the LiteroticaUrlUtil class for working with Literotica URLs.

```csharp
public static LiteroticaUrlUtil UrlUtil;
```

**Remarks:**

This static field can be used to access URL utility methods without creating a new
 LiteroticaUrlUtil instance. The instance is thread-safe for concurrent use if LiteroticaUrlUtil itself is
 thread-safe.

## Constructors

### **Literotica()**

```csharp
public Literotica()
```

## Methods

### **Log(String)**

Writes the specified message to both the standard output and the debug output streams.

```csharp
public void Log(string message)
```

#### Parameters

`message` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The message to be logged. If `message` is null, no output is written.

### **CreateEpubFromSeriesAsync(String, String, String, Boolean, Int32, Int32)**

Generates an EPUB file from an entire series on Literotica, including all its parts (stories).

```csharp
public Task CreateEpubFromSeriesAsync(string seriesUrl, string outputDirectory, string coverOverwrite, bool raw, int startIndex, int endIndex)
```

#### Parameters

`seriesUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL of the Literotica series to download and convert.

`outputDirectory` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The directory where the EPUB file should be created.

`coverOverwrite` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Forcefully set cover art for Epub

`raw` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If you don't want it to output .epub but instead the raw formatting.

`startIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
What chapter of the series to start at

`endIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
What chapter of the series to end at

#### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)<br>

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
Thrown if the series cannot be found or has no valid stories.

### **CreateEpubFromStoryAsync(String, String, String, Boolean)**

Generates an EPUB file from a single Literotica story.

```csharp
public Task CreateEpubFromStoryAsync(string storyUrl, string outputDirectory, string coverOverwrite, bool raw)
```

#### Parameters

`storyUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL of the story to convert.

`outputDirectory` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The directory where the EPUB file should be created.

`coverOverwrite` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Forcefully set cover art for Epub

`raw` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If you don't want it to output .epub but instead the raw formatting.

#### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)<br>

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
Thrown if the story or author information cannot be retrieved.
