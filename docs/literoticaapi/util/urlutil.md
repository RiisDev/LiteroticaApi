# UrlUtil

Namespace: LiteroticaApi.Util

Provides utility methods for parsing Literotica story and series URLs
 and extracting identifying information such as slugs or IDs.

```csharp
public static class UrlUtil
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [UrlUtil](./literoticaapi/util/urlutil.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Methods

### **GetStorySlug(String)**

Extracts the story slug from a Literotica story URL.

```csharp
public static Task<string> GetStorySlug(string url)
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

The slug is validated using .

### **GetSeriesId(String)**

Extracts the numeric series ID from a Literotica series URL.

```csharp
public static Task<string> GetSeriesId(string url)
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

The series ID is validated using .

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
