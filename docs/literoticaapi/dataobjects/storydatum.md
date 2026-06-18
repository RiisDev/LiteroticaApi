# StoryDatum

Namespace: LiteroticaApi.DataObjects

Represents detailed metadata and content information for a story or work, including author and category data.

```csharp
public class StoryDatum : System.IEquatable`1[[LiteroticaApi.DataObjects.StoryDatum, LiteroticaApi, Version=2.1.1.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [StoryDatum](./literoticaapi/dataobjects/storydatum.md)<br>
Implements [IEquatable&lt;StoryDatum&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Id**

```csharp
public Nullable<long> Id { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **UserId**

```csharp
public Nullable<long> UserId { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Url**

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CreatedAt**

```csharp
public Nullable<DateTime> CreatedAt { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ModifiedAt**

```csharp
public Nullable<DateTime> ModifiedAt { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Title**

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Language**

```csharp
public Nullable<long> Language { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **State**

```csharp
public string State { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ViewCount**

```csharp
public Nullable<long> ViewCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CommentsCount**

```csharp
public Nullable<long> CommentsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FavoritesCount**

```csharp
public Nullable<long> FavoritesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ListsCount**

```csharp
public Nullable<long> ListsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **WorkCount**

```csharp
public Nullable<long> WorkCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Parts**

```csharp
public IReadOnlyList<Part> Parts { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Part&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **AllowVote**

```csharp
public Nullable<long> AllowVote { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AllowDownload**

```csharp
public Nullable<long> AllowDownload { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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
public Nullable<long> Category { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CommentCount**

```csharp
public Nullable<long> CommentCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ContestWinner**

```csharp
public Nullable<long> ContestWinner { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DateApprove**

```csharp
public string DateApprove { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EnableComments**

```csharp
public Nullable<long> EnableComments { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FavoriteCount**

```csharp
public Nullable<long> FavoriteCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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

### **Newlanguage**

```csharp
public Nullable<long> Newlanguage { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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
public Nullable<long> ReadingListsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Tags**

```csharp
public IReadOnlyList<Tag> Tags { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Tag&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **Type**

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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

## Constructors

### **StoryDatum(Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, String, Nullable&lt;DateTime&gt;, Nullable&lt;DateTime&gt;, String, Nullable&lt;Int64&gt;, String, String, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, IReadOnlyList&lt;Part&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Author, String, CategoryInfo, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, String, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Int64&gt;, String, Nullable&lt;Double&gt;, Nullable&lt;Int64&gt;, IReadOnlyList&lt;Tag&gt;, String, Nullable&lt;Boolean&gt;, String)**

Represents detailed metadata and content information for a story or work, including author and category data.

```csharp
public StoryDatum(Nullable<long> Id, Nullable<long> UserId, string Url, Nullable<DateTime> CreatedAt, Nullable<DateTime> ModifiedAt, string Title, Nullable<long> Language, string State, string Description, Nullable<long> ViewCount, Nullable<long> CommentsCount, Nullable<long> FavoritesCount, Nullable<long> ListsCount, Nullable<long> WorkCount, IReadOnlyList<Part> Parts, Nullable<long> AllowVote, Nullable<long> AllowDownload, Author Author, string Authorname, CategoryInfo CategoryInfo, Nullable<long> Category, Nullable<long> CommentCount, Nullable<long> ContestWinner, string DateApprove, Nullable<long> EnableComments, Nullable<long> FavoriteCount, Nullable<bool> IsHot, Nullable<bool> IsNew, Nullable<long> Newlanguage, string Rank, Nullable<double> RateAll, Nullable<long> ReadingListsCount, IReadOnlyList<Tag> Tags, string Type, Nullable<bool> WritersPick, string Status)
```

#### Parameters

`Id` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`UserId` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`CreatedAt` [Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`ModifiedAt` [Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Language` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`State` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Description` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`ViewCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CommentsCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FavoritesCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`ListsCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`WorkCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Parts` [IReadOnlyList&lt;Part&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

`AllowVote` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`AllowDownload` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Author` [Author](./literoticaapi/dataobjects/author.md)<br>

`Authorname` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`CategoryInfo` [CategoryInfo](./literoticaapi/dataobjects/categoryinfo.md)<br>

`Category` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CommentCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`ContestWinner` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`DateApprove` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`EnableComments` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FavoriteCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`IsHot` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`IsNew` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Newlanguage` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Rank` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`RateAll` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`ReadingListsCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Tags` [IReadOnlyList&lt;Tag&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

`Type` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`WritersPick` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Status` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **StoryDatum(StoryDatum)**

```csharp
protected StoryDatum(StoryDatum original)
```

#### Parameters

`original` [StoryDatum](./literoticaapi/dataobjects/storydatum.md)<br>

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

### **Equals(StoryDatum)**

```csharp
public bool Equals(StoryDatum other)
```

#### Parameters

`other` [StoryDatum](./literoticaapi/dataobjects/storydatum.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public StoryDatum <Clone>$()
```

#### Returns

[StoryDatum](./literoticaapi/dataobjects/storydatum.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&, String&, Nullable`1&, Nullable`1&, String&, Nullable`1&, String&, String&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, IReadOnlyList`1&, Nullable`1&, Nullable`1&, Author&, String&, CategoryInfo&, Nullable`1&, Nullable`1&, Nullable`1&, String&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, String&, Nullable`1&, Nullable`1&, IReadOnlyList`1&, String&, Nullable`1&, String&)**

```csharp
public void Deconstruct(Nullable`1& Id, Nullable`1& UserId, String& Url, Nullable`1& CreatedAt, Nullable`1& ModifiedAt, String& Title, Nullable`1& Language, String& State, String& Description, Nullable`1& ViewCount, Nullable`1& CommentsCount, Nullable`1& FavoritesCount, Nullable`1& ListsCount, Nullable`1& WorkCount, IReadOnlyList`1& Parts, Nullable`1& AllowVote, Nullable`1& AllowDownload, Author& Author, String& Authorname, CategoryInfo& CategoryInfo, Nullable`1& Category, Nullable`1& CommentCount, Nullable`1& ContestWinner, String& DateApprove, Nullable`1& EnableComments, Nullable`1& FavoriteCount, Nullable`1& IsHot, Nullable`1& IsNew, Nullable`1& Newlanguage, String& Rank, Nullable`1& RateAll, Nullable`1& ReadingListsCount, IReadOnlyList`1& Tags, String& Type, Nullable`1& WritersPick, String& Status)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`UserId` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Url` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`CreatedAt` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`ModifiedAt` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Title` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Language` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`State` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Description` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`ViewCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CommentsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FavoritesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`ListsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`WorkCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Parts` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`AllowVote` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`AllowDownload` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Author` [Author&](./literoticaapi/dataobjects/author&.md)<br>

`Authorname` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`CategoryInfo` [CategoryInfo&](./literoticaapi/dataobjects/categoryinfo&.md)<br>

`Category` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CommentCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`ContestWinner` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`DateApprove` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`EnableComments` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FavoriteCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`IsHot` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`IsNew` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Newlanguage` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Rank` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`RateAll` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`ReadingListsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Tags` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`Type` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`WritersPick` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Status` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
