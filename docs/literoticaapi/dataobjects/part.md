# Part

Namespace: LiteroticaApi.DataObjects

```csharp
public class Part : System.IEquatable`1[[LiteroticaApi.DataObjects.Part, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Part](./literoticaapi/dataobjects/part.md)<br>
Implements [IEquatable&lt;Part&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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

### **CommentCount**

```csharp
public Nullable<int> CommentCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **Part(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, String, CategoryInfo, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, String, String, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Double&gt;, Nullable&lt;Int32&gt;, String, String, String, Nullable&lt;Int32&gt;, Nullable&lt;Boolean&gt;, Nullable&lt;Int32&gt;)**

```csharp
public Part(Nullable<int> AllowVote, Nullable<int> AllowDownload, string Authorname, CategoryInfo CategoryInfo, Nullable<int> Category, Nullable<int> ContestWinner, string DateApprove, string Description, Nullable<int> EnableComments, Nullable<int> FavoriteCount, Nullable<int> Id, Nullable<bool> IsHot, Nullable<bool> IsNew, Nullable<int> Language, Nullable<double> RateAll, Nullable<int> ReadingListsCount, string Title, string Type, string Url, Nullable<int> ViewCount, Nullable<bool> WritersPick, Nullable<int> CommentCount)
```

#### Parameters

`AllowVote` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`AllowDownload` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Authorname` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`CategoryInfo` [CategoryInfo](./literoticaapi/dataobjects/categoryinfo.md)<br>

`Category` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`ContestWinner` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`DateApprove` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Description` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`EnableComments` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FavoriteCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`IsHot` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`IsNew` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Language` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`RateAll` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`ReadingListsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Type` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`ViewCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`WritersPick` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CommentCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Part(Part)**

```csharp
protected Part(Part original)
```

#### Parameters

`original` [Part](./literoticaapi/dataobjects/part.md)<br>

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

### **Equals(Part)**

```csharp
public bool Equals(Part other)
```

#### Parameters

`other` [Part](./literoticaapi/dataobjects/part.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Part <Clone>$()
```

#### Returns

[Part](./literoticaapi/dataobjects/part.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&, String&, CategoryInfo&, Nullable`1&, Nullable`1&, String&, String&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, String&, String&, String&, Nullable`1&, Nullable`1&, Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& AllowVote, Nullable`1& AllowDownload, String& Authorname, CategoryInfo& CategoryInfo, Nullable`1& Category, Nullable`1& ContestWinner, String& DateApprove, String& Description, Nullable`1& EnableComments, Nullable`1& FavoriteCount, Nullable`1& Id, Nullable`1& IsHot, Nullable`1& IsNew, Nullable`1& Language, Nullable`1& RateAll, Nullable`1& ReadingListsCount, String& Title, String& Type, String& Url, Nullable`1& ViewCount, Nullable`1& WritersPick, Nullable`1& CommentCount)
```

#### Parameters

`AllowVote` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`AllowDownload` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Authorname` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`CategoryInfo` [CategoryInfo&](./literoticaapi/dataobjects/categoryinfo&.md)<br>

`Category` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`ContestWinner` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`DateApprove` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Description` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`EnableComments` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FavoriteCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`IsHot` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`IsNew` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Language` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`RateAll` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`ReadingListsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Title` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Type` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Url` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`ViewCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`WritersPick` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CommentCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
