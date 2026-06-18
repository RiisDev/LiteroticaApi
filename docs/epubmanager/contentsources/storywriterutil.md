# StoryWriterUtil

Namespace: EpubManager.ContentSources

Provides utility methods for working with story writer file names, including generating safe file names suitable
 for use on the file system.

```csharp
public static class StoryWriterUtil
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [StoryWriterUtil](./epubmanager/contentsources/storywriterutil.md)<br>
Attributes [ExtensionAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.extensionattribute)

**Remarks:**

This class contains extension methods for the IStoryWriterUtil interface. All members are static
 and thread-safe. Use these utilities to ensure file names are valid and compatible across different operating
 systems.

## Methods

### **ToSafeFileName(String)**

```csharp
public static string ToSafeFileName(string input)
```

#### Parameters

`input` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
