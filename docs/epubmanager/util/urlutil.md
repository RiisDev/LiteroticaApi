# UrlUtil

Namespace: EpubManager.Util

Provides utility methods for parsing Literotica story and series URLs
 and extracting identifying information such as slugs or IDs.

```csharp
public static class UrlUtil
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [UrlUtil](./epubmanager/util/urlutil.md)

## Methods

### **ToSafeFileName(String)**

Converts a string into a safe filename valid for both Windows and Unix systems.

```csharp
public static string ToSafeFileName(string input)
```

#### Parameters

`input` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The input string to sanitize.

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A safe filename string.
