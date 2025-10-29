# StoryWriter

Namespace: LiteroticaApi.EpubWriter

Provides functionality for generating EPUB files from Literotica stories and series.

```csharp
public static class StoryWriter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [StoryWriter](./literoticaapi/epubwriter/storywriter.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

**Remarks:**

This class uses the Literotica API to fetch story or series data, and then compiles it into
 a standards-compliant EPUB structure. It generates all required EPUB components such as
 `toc.ncx`, `content.opf`, and XHTML files for chapters, cover, and navigation.

## Methods

### **CreateEpub(EpubStory, String)**

Creates an EPUB file from a given [EpubStory](./literoticaapi/epubwriter/epubstory.md) object and outputs it to the specified directory.

```csharp
public static void CreateEpub(EpubStory story, string outputDirectory)
```

#### Parameters

`story` [EpubStory](./literoticaapi/epubwriter/epubstory.md)<br>
The [EpubStory](./literoticaapi/epubwriter/epubstory.md) containing metadata, chapters, and optional cover.

`outputDirectory` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The directory where the final EPUB file should be saved. Defaults to the base directory.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
Thrown when a required file cannot be written or an I/O operation fails.

### **CreateEpubFromSeries(String, String)**

Generates an EPUB file from an entire series on Literotica, including all its parts (stories).

```csharp
public static Task CreateEpubFromSeries(string seriesUrl, string outputDirectory)
```

#### Parameters

`seriesUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL of the Literotica series to download and convert.

`outputDirectory` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The directory where the EPUB file should be created.

#### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)<br>

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
Thrown if the series cannot be found or has no valid stories.

### **CreateEpubFromStory(String, String)**

Generates an EPUB file from a single Literotica story.

```csharp
public static Task CreateEpubFromStory(string storyUrl, string outputDirectory)
```

#### Parameters

`storyUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL of the story to convert.

`outputDirectory` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The directory where the EPUB file should be created.

#### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)<br>

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
Thrown if the story or author information cannot be retrieved.
