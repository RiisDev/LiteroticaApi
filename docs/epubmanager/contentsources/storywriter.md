# StoryWriter

Namespace: EpubManager.ContentSources

Provides static methods and constants for generating EPUB files from story data.

```csharp
public static class StoryWriter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [StoryWriter](./epubmanager/contentsources/storywriter.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

**Remarks:**

The StoryWriter class is intended for use in scenarios where stories, including chapters and cover
 art, need to be packaged into a valid EPUB format. All members are static and thread safety is not guaranteed;
 concurrent calls should be managed externally if required.

## Fields

### **TempDir**

Represents the full path to the application's temporary directory.

```csharp
public static string TempDir;
```

**Remarks:**

The directory is located under the application's base directory and is named "temp". This path
 can be used for storing temporary files specific to the application's runtime environment.

## Methods

### **CreateEpub(EpubStory, Action&lt;String&gt;, String, Boolean)**

Creates an EPUB file from the specified story, including chapters, metadata, and optional cover art.

```csharp
public static void CreateEpub(EpubStory story, Action<string> onLog, string outputDirectory, bool raw)
```

#### Parameters

`story` [EpubStory](./epubmanager/contentsources/epubstory.md)<br>
The story to be converted into an EPUB file. Must contain chapter information and metadata such as title and,
 optionally, cover art.

`onLog` [Action&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.action-1)<br>
An optional callback that receives log messages during the EPUB creation process. Can be used to monitor progress
 or capture errors.

`outputDirectory` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The directory in which to place the generated EPUB file and temporary working files. If null or empty, the
 application's base directory is used.

`raw` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If , the method generates the EPUB file structure without packaging it into a final .epub
 archive. If , the method creates the .epub archive and cleans up temporary files.

**Remarks:**

The method writes temporary files to a working directory and may download or copy cover art if
 specified. If the raw parameter is set to , the final .epub archive is not created, and the
 working directory is retained for inspection. The method may overwrite existing files in the output directory.
 Logging via the onLog callback can provide detailed progress and error information.
