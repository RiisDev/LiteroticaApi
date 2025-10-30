# Author

Namespace: LiteroticaApi.DataObjects

Represents an author profile on Literotica, including biography, statistics, and personal attributes.

```csharp
public class Author : System.IEquatable`1[[LiteroticaApi.DataObjects.Author, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Author](./literoticaapi/dataobjects/author.md)<br>
Implements [IEquatable&lt;Author&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

**Remarks:**

Contains detailed metadata such as follower counts, story counts, favorite works, and optional personal information
 like location, orientation, and interests.

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Aim**

```csharp
public string Aim { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Bio**

```csharp
public string Bio { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Biography**

```csharp
public string Biography { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CommentsCount**

```csharp
public Nullable<int> CommentsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Customtitle**

```csharp
public Nullable<int> Customtitle { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Drink**

```csharp
public string Drink { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EditorStatus**

```csharp
public string EditorStatus { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FollowedStoriesCount**

```csharp
public Nullable<int> FollowedStoriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FollowersCount**

```csharp
public Nullable<int> FollowersCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FollowingsCount**

```csharp
public Nullable<int> FollowingsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **HasPhoto**

```csharp
public Nullable<int> HasPhoto { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Homepage**

```csharp
public string Homepage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Icq**

```csharp
public object Icq { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **Joindate**

```csharp
public string Joindate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Location**

```csharp
public string Location { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Status**

```csharp
public string Status { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Options**

```csharp
public Nullable<int> Options { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Pets**

```csharp
public string Pets { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Smoke**

```csharp
public string Smoke { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **StoriesCount**

```csharp
public Nullable<int> StoriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PoemsCount**

```csharp
public Nullable<int> PoemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IllustrationsCount**

```csharp
public Nullable<int> IllustrationsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AudiosCount**

```csharp
public Nullable<int> AudiosCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SgsCount**

```csharp
public Nullable<int> SgsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SeriesCount**

```csharp
public Nullable<int> SeriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **StoriesAndSeriesCount**

```csharp
public Nullable<int> StoriesAndSeriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AudiosAndSeriesCount**

```csharp
public Nullable<int> AudiosAndSeriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PoemsAndSeriesCount**

```csharp
public Nullable<int> PoemsAndSeriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IllustrasAndSeriesCount**

```csharp
public Nullable<int> IllustrasAndSeriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SgsAndSeriesCount**

```csharp
public Nullable<int> SgsAndSeriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FavStoriesCount**

```csharp
public Nullable<int> FavStoriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FavPoemsCount**

```csharp
public Nullable<int> FavPoemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FavSgsCount**

```csharp
public Nullable<int> FavSgsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FavArtworksCount**

```csharp
public Nullable<int> FavArtworksCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FavAudiosCount**

```csharp
public Nullable<int> FavAudiosCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FavAuthorsCount**

```csharp
public Nullable<int> FavAuthorsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SubmissionsCount**

```csharp
public Nullable<int> SubmissionsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Userid**

```csharp
public Nullable<int> Userid { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Username**

```csharp
public StringOrInt Username { get; set; }
```

#### Property Value

[StringOrInt](./literoticaapi/dataobjects/stringorint.md)<br>

### **Userpic**

```csharp
public string Userpic { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Usertitle**

```csharp
public string Usertitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FavoritesCount**

```csharp
public Nullable<int> FavoritesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LastUpdate**

```csharp
public Nullable<DateTime> LastUpdate { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **JoindateApprox**

```csharp
public string JoindateApprox { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LastUpdateApprox**

```csharp
public string LastUpdateApprox { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FavoriteStoriesCount**

```csharp
public Nullable<int> FavoriteStoriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Sex**

```csharp
public string Sex { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Weight**

```csharp
public string Weight { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Height**

```csharp
public string Height { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Orientation**

```csharp
public string Orientation { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Interests**

```csharp
public string Interests { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Fetishes**

```csharp
public string Fetishes { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Datingstat**

```csharp
public string Datingstat { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Allowfeedback**

```csharp
public Nullable<int> Allowfeedback { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DisableAllFeedback**

```csharp
public Nullable<int> DisableAllFeedback { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Lists**

```csharp
public IReadOnlyList<BookList> Lists { get; set; }
```

#### Property Value

[IReadOnlyList&lt;BookList&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **ListsContent**

```csharp
public object ListsContent { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **SupportMeService**

```csharp
public string SupportMeService { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SupportMeLink**

```csharp
public string SupportMeLink { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **Author(String, String, String, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, String, String, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, String, Object, String, String, String, Nullable&lt;Int32&gt;, String, String, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, StringOrInt, String, String, Nullable&lt;Int32&gt;, Nullable&lt;DateTime&gt;, String, String, Nullable&lt;Int32&gt;, String, String, String, String, String, String, String, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, IReadOnlyList&lt;BookList&gt;, Object, String, String)**

Represents an author profile on Literotica, including biography, statistics, and personal attributes.

```csharp
public Author(string Aim, string Bio, string Biography, Nullable<int> CommentsCount, Nullable<int> Customtitle, string Drink, string EditorStatus, Nullable<int> FollowedStoriesCount, Nullable<int> FollowersCount, Nullable<int> FollowingsCount, Nullable<int> HasPhoto, string Homepage, object Icq, string Joindate, string Location, string Status, Nullable<int> Options, string Pets, string Smoke, Nullable<int> StoriesCount, Nullable<int> PoemsCount, Nullable<int> IllustrationsCount, Nullable<int> AudiosCount, Nullable<int> SgsCount, Nullable<int> SeriesCount, Nullable<int> StoriesAndSeriesCount, Nullable<int> AudiosAndSeriesCount, Nullable<int> PoemsAndSeriesCount, Nullable<int> IllustrasAndSeriesCount, Nullable<int> SgsAndSeriesCount, Nullable<int> FavStoriesCount, Nullable<int> FavPoemsCount, Nullable<int> FavSgsCount, Nullable<int> FavArtworksCount, Nullable<int> FavAudiosCount, Nullable<int> FavAuthorsCount, Nullable<int> SubmissionsCount, Nullable<int> Userid, StringOrInt Username, string Userpic, string Usertitle, Nullable<int> FavoritesCount, Nullable<DateTime> LastUpdate, string JoindateApprox, string LastUpdateApprox, Nullable<int> FavoriteStoriesCount, string Sex, string Weight, string Height, string Orientation, string Interests, string Fetishes, string Datingstat, Nullable<int> Allowfeedback, Nullable<int> DisableAllFeedback, IReadOnlyList<BookList> Lists, object ListsContent, string SupportMeService, string SupportMeLink)
```

#### Parameters

`Aim` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Bio` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Biography` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`CommentsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Customtitle` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Drink` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`EditorStatus` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`FollowedStoriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FollowersCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FollowingsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`HasPhoto` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Homepage` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Icq` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`Joindate` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Location` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Status` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Options` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Pets` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Smoke` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`StoriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`PoemsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`IllustrationsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`AudiosCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`SgsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`SeriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`StoriesAndSeriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`AudiosAndSeriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`PoemsAndSeriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`IllustrasAndSeriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`SgsAndSeriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FavStoriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FavPoemsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FavSgsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FavArtworksCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FavAudiosCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FavAuthorsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`SubmissionsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Userid` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Username` [StringOrInt](./literoticaapi/dataobjects/stringorint.md)<br>

`Userpic` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Usertitle` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`FavoritesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`LastUpdate` [Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`JoindateApprox` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`LastUpdateApprox` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`FavoriteStoriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Sex` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Weight` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Height` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Orientation` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Interests` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Fetishes` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Datingstat` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Allowfeedback` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`DisableAllFeedback` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Lists` [IReadOnlyList&lt;BookList&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

`ListsContent` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`SupportMeService` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`SupportMeLink` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

**Remarks:**

Contains detailed metadata such as follower counts, story counts, favorite works, and optional personal information
 like location, orientation, and interests.

### **Author(Author)**

```csharp
protected Author(Author original)
```

#### Parameters

`original` [Author](./literoticaapi/dataobjects/author.md)<br>

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

### **Equals(Author)**

```csharp
public bool Equals(Author other)
```

#### Parameters

`other` [Author](./literoticaapi/dataobjects/author.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Author <Clone>$()
```

#### Returns

[Author](./literoticaapi/dataobjects/author.md)<br>

### **Deconstruct(String&, String&, String&, Nullable`1&, Nullable`1&, String&, String&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, String&, Object&, String&, String&, String&, Nullable`1&, String&, String&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, StringOrInt&, String&, String&, Nullable`1&, Nullable`1&, String&, String&, Nullable`1&, String&, String&, String&, String&, String&, String&, String&, Nullable`1&, Nullable`1&, IReadOnlyList`1&, Object&, String&, String&)**

```csharp
public void Deconstruct(String& Aim, String& Bio, String& Biography, Nullable`1& CommentsCount, Nullable`1& Customtitle, String& Drink, String& EditorStatus, Nullable`1& FollowedStoriesCount, Nullable`1& FollowersCount, Nullable`1& FollowingsCount, Nullable`1& HasPhoto, String& Homepage, Object& Icq, String& Joindate, String& Location, String& Status, Nullable`1& Options, String& Pets, String& Smoke, Nullable`1& StoriesCount, Nullable`1& PoemsCount, Nullable`1& IllustrationsCount, Nullable`1& AudiosCount, Nullable`1& SgsCount, Nullable`1& SeriesCount, Nullable`1& StoriesAndSeriesCount, Nullable`1& AudiosAndSeriesCount, Nullable`1& PoemsAndSeriesCount, Nullable`1& IllustrasAndSeriesCount, Nullable`1& SgsAndSeriesCount, Nullable`1& FavStoriesCount, Nullable`1& FavPoemsCount, Nullable`1& FavSgsCount, Nullable`1& FavArtworksCount, Nullable`1& FavAudiosCount, Nullable`1& FavAuthorsCount, Nullable`1& SubmissionsCount, Nullable`1& Userid, StringOrInt& Username, String& Userpic, String& Usertitle, Nullable`1& FavoritesCount, Nullable`1& LastUpdate, String& JoindateApprox, String& LastUpdateApprox, Nullable`1& FavoriteStoriesCount, String& Sex, String& Weight, String& Height, String& Orientation, String& Interests, String& Fetishes, String& Datingstat, Nullable`1& Allowfeedback, Nullable`1& DisableAllFeedback, IReadOnlyList`1& Lists, Object& ListsContent, String& SupportMeService, String& SupportMeLink)
```

#### Parameters

`Aim` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Bio` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Biography` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`CommentsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Customtitle` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Drink` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`EditorStatus` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`FollowedStoriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FollowersCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FollowingsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`HasPhoto` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Homepage` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Icq` [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)<br>

`Joindate` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Location` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Status` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Options` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Pets` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Smoke` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`StoriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`PoemsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`IllustrationsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`AudiosCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`SgsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`SeriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`StoriesAndSeriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`AudiosAndSeriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`PoemsAndSeriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`IllustrasAndSeriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`SgsAndSeriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FavStoriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FavPoemsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FavSgsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FavArtworksCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FavAudiosCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FavAuthorsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`SubmissionsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Userid` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Username` [StringOrInt&](./literoticaapi/dataobjects/stringorint&.md)<br>

`Userpic` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Usertitle` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`FavoritesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`LastUpdate` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`JoindateApprox` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`LastUpdateApprox` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`FavoriteStoriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Sex` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Weight` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Height` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Orientation` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Interests` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Fetishes` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Datingstat` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Allowfeedback` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`DisableAllFeedback` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Lists` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`ListsContent` [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)<br>

`SupportMeService` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`SupportMeLink` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
