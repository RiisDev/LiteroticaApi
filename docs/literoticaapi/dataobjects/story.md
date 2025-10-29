# Story

Namespace: LiteroticaApi.DataObjects

```csharp
public class Story : System.IEquatable`1[[LiteroticaApi.DataObjects.Story, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Story](./literoticaapi/dataobjects/story.md)<br>
Implements [IEquatable&lt;Story&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **AllowVote**

```csharp
public Nullable<int> AllowVote { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AllowDownload**

```csharp
public Nullable<int> AllowDownload { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Author**

```csharp
public Author Author { get; set; }
```

#### Property Value

[Author](./literoticaapi/dataobjects/author.md)<br>

### **Authorname**

```csharp
public string Authorname { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CategoryInfo**

```csharp
public CategoryInfo CategoryInfo { get; set; }
```

#### Property Value

[CategoryInfo](./literoticaapi/dataobjects/categoryinfo.md)<br>

### **Category**

```csharp
public Nullable<int> Category { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CommentCount**

```csharp
public Nullable<int> CommentCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ContestWinner**

```csharp
public Nullable<int> ContestWinner { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DateApprove**

```csharp
public string DateApprove { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EnableComments**

```csharp
public Nullable<int> EnableComments { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FavoriteCount**

```csharp
public Nullable<int> FavoriteCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Id**

```csharp
public Nullable<int> Id { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsHot**

```csharp
public Nullable<bool> IsHot { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsNew**

```csharp
public Nullable<bool> IsNew { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Language**

```csharp
public Nullable<int> Language { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Newlanguage**

```csharp
public Nullable<int> Newlanguage { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rank**

```csharp
public string Rank { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RateAll**

```csharp
public Nullable<double> RateAll { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ReadingListsCount**

```csharp
public Nullable<int> ReadingListsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Tags**

```csharp
public IReadOnlyList<Tag> Tags { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Tag&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **Title**

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Type**

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ViewCount**

```csharp
public Nullable<int> ViewCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **WritersPick**

```csharp
public Nullable<bool> WritersPick { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Status**

```csharp
public string Status { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeriesCount**

```csharp
public Nullable<int> SeriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **Story(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Author, String, CategoryInfo, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, String, String, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, String, Nullable&lt;Double&gt;, Nullable&lt;Int32&gt;, IReadOnlyList&lt;Tag&gt;, String, String, String, Nullable&lt;Int32&gt;, Nullable&lt;Boolean&gt;, String, Nullable&lt;Int32&gt;)**

```csharp
public Story(Nullable<int> AllowVote, Nullable<int> AllowDownload, Author Author, string Authorname, CategoryInfo CategoryInfo, Nullable<int> Category, Nullable<int> CommentCount, Nullable<int> ContestWinner, string DateApprove, string Description, Nullable<int> EnableComments, Nullable<int> FavoriteCount, Nullable<int> Id, Nullable<bool> IsHot, Nullable<bool> IsNew, Nullable<int> Language, Nullable<int> Newlanguage, string Rank, Nullable<double> RateAll, Nullable<int> ReadingListsCount, IReadOnlyList<Tag> Tags, string Title, string Type, string Url, Nullable<int> ViewCount, Nullable<bool> WritersPick, string Status, Nullable<int> SeriesCount)
```

#### Parameters

`AllowVote` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`AllowDownload` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Author` [Author](./literoticaapi/dataobjects/author.md)<br>

`Authorname` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`CategoryInfo` [CategoryInfo](./literoticaapi/dataobjects/categoryinfo.md)<br>

`Category` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CommentCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`ContestWinner` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`DateApprove` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Description` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`EnableComments` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FavoriteCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`IsHot` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`IsNew` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Language` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Newlanguage` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Rank` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`RateAll` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`ReadingListsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Tags` [IReadOnlyList&lt;Tag&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

`Title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Type` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`ViewCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`WritersPick` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Status` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`SeriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Story(Story)**

```csharp
protected Story(Story original)
```

#### Parameters

`original` [Story](./literoticaapi/dataobjects/story.md)<br>

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

### **Equals(Story)**

```csharp
public bool Equals(Story other)
```

#### Parameters

`other` [Story](./literoticaapi/dataobjects/story.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Story <Clone>$()
```

#### Returns

[Story](./literoticaapi/dataobjects/story.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&, Author&, String&, CategoryInfo&, Nullable`1&, Nullable`1&, Nullable`1&, String&, String&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, String&, Nullable`1&, Nullable`1&, IReadOnlyList`1&, String&, String&, String&, Nullable`1&, Nullable`1&, String&, Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& AllowVote, Nullable`1& AllowDownload, Author& Author, String& Authorname, CategoryInfo& CategoryInfo, Nullable`1& Category, Nullable`1& CommentCount, Nullable`1& ContestWinner, String& DateApprove, String& Description, Nullable`1& EnableComments, Nullable`1& FavoriteCount, Nullable`1& Id, Nullable`1& IsHot, Nullable`1& IsNew, Nullable`1& Language, Nullable`1& Newlanguage, String& Rank, Nullable`1& RateAll, Nullable`1& ReadingListsCount, IReadOnlyList`1& Tags, String& Title, String& Type, String& Url, Nullable`1& ViewCount, Nullable`1& WritersPick, String& Status, Nullable`1& SeriesCount)
```

#### Parameters

`AllowVote` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`AllowDownload` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Author` [Author&](./literoticaapi/dataobjects/author&.md)<br>

`Authorname` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`CategoryInfo` [CategoryInfo&](./literoticaapi/dataobjects/categoryinfo&.md)<br>

`Category` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CommentCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`ContestWinner` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`DateApprove` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Description` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`EnableComments` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FavoriteCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`IsHot` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`IsNew` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Language` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Newlanguage` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Rank` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`RateAll` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`ReadingListsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Tags` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`Title` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Type` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Url` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`ViewCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`WritersPick` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Status` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`SeriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
