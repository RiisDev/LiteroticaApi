# EpubStory

Namespace: LiteroticaApi.EpubWriter

Represents a story prepared for EPUB generation, containing its metadata and chapters.

```csharp
public class EpubStory : System.IEquatable`1[[LiteroticaApi.EpubWriter.EpubStory, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [EpubStory](./literoticaapi/epubwriter/epubstory.md)<br>
Implements [IEquatable&lt;EpubStory&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Title**

The title of the story.

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Language**

The language in which the story is written (e.g., "English").

```csharp
public string Language { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Author**

The author’s name or pseudonym.

```csharp
public string Author { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Series**

Optional series metadata if the story belongs to one.

```csharp
public EpubSeries Series { get; set; }
```

#### Property Value

[EpubSeries](./literoticaapi/epubwriter/epubseries.md)<br>

### **Tags**

An array of associated tags or genres describing the story.

```csharp
public String[] Tags { get; set; }
```

#### Property Value

[String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Chapters**

A collection of file paths to the chapter text files for the story.

```csharp
public IReadOnlyList<string> Chapters { get; set; }
```

#### Property Value

[IReadOnlyList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **CoverPath**

Optional file path to the story’s cover image.

```csharp
public string CoverPath { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Identifier**

Gets a unique identifier for this story instance. 
 Used internally for metadata consistency and manifest references.

```csharp
public object Identifier { get; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

## Constructors

### **EpubStory(String, String, String, EpubSeries, String[], IReadOnlyList&lt;String&gt;, String)**

Represents a story prepared for EPUB generation, containing its metadata and chapters.

```csharp
public EpubStory(string Title, string Language, string Author, EpubSeries Series, String[] Tags, IReadOnlyList<string> Chapters, string CoverPath)
```

#### Parameters

`Title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The title of the story.

`Language` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The language in which the story is written (e.g., "English").

`Author` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The author’s name or pseudonym.

`Series` [EpubSeries](./literoticaapi/epubwriter/epubseries.md)<br>
Optional series metadata if the story belongs to one.

`Tags` [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
An array of associated tags or genres describing the story.

`Chapters` [IReadOnlyList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>
A collection of file paths to the chapter text files for the story.

`CoverPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Optional file path to the story’s cover image.

### **EpubStory(EpubStory)**

```csharp
protected EpubStory(EpubStory original)
```

#### Parameters

`original` [EpubStory](./literoticaapi/epubwriter/epubstory.md)<br>

## Methods

### **ToString()**

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PrintMembers(StringBuilder)**

```csharp
protected bool PrintMembers(StringBuilder builder)
```

#### Parameters

`builder` [StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **GetHashCode()**

```csharp
public int GetHashCode()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Equals(Object)**

```csharp
public bool Equals(object obj)
```

#### Parameters

`obj` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Equals(EpubStory)**

```csharp
public bool Equals(EpubStory other)
```

#### Parameters

`other` [EpubStory](./literoticaapi/epubwriter/epubstory.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public EpubStory <Clone>$()
```

#### Returns

[EpubStory](./literoticaapi/epubwriter/epubstory.md)<br>

### **Deconstruct(String&, String&, String&, EpubSeries&, String[]&, IReadOnlyList`1&, String&)**

```csharp
public void Deconstruct(String& Title, String& Language, String& Author, EpubSeries& Series, String[]& Tags, IReadOnlyList`1& Chapters, String& CoverPath)
```

#### Parameters

`Title` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Language` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Author` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Series` [EpubSeries&](./literoticaapi/epubwriter/epubseries&.md)<br>

`Tags` [String[]&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Chapters` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`CoverPath` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
