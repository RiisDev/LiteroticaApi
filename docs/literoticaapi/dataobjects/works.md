# Works

Namespace: LiteroticaApi.DataObjects

Represents an individual work, including metadata, author details, and associated categories.

```csharp
public class Works : System.IEquatable`1[[LiteroticaApi.DataObjects.Works, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Works](./literoticaapi/dataobjects/works.md)<br>
Implements [IEquatable&lt;Works&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public Nullable<int> Id { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **UserId**

```csharp
public Nullable<int> UserId { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Url**

```csharp
public object Url { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

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
public Nullable<int> Language { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **State**

```csharp
public string State { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

```csharp
public object Description { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **ViewCount**

```csharp
public Nullable<int> ViewCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CommentsCount**

```csharp
public Nullable<int> CommentsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FavoritesCount**

```csharp
public Nullable<int> FavoritesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ListsCount**

```csharp
public Nullable<int> ListsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AuthorName**

```csharp
public string AuthorName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Categories**

```csharp
public IReadOnlyList<Category> Categories { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Category&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **WorksInfo**

```csharp
public IReadOnlyList<Work> WorksInfo { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Work&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

## Constructors

### **Works(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Object, Nullable&lt;DateTime&gt;, Nullable&lt;DateTime&gt;, String, Nullable&lt;Int32&gt;, String, Object, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, String, IReadOnlyList&lt;Category&gt;, IReadOnlyList&lt;Work&gt;)**

Represents an individual work, including metadata, author details, and associated categories.

```csharp
public Works(Nullable<int> Id, Nullable<int> UserId, object Url, Nullable<DateTime> CreatedAt, Nullable<DateTime> ModifiedAt, string Title, Nullable<int> Language, string State, object Description, Nullable<int> ViewCount, Nullable<int> CommentsCount, Nullable<int> FavoritesCount, Nullable<int> ListsCount, string AuthorName, IReadOnlyList<Category> Categories, IReadOnlyList<Work> WorksInfo)
```

#### Parameters

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`UserId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Url` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`CreatedAt` [Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`ModifiedAt` [Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Language` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`State` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Description` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`ViewCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CommentsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FavoritesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`ListsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`AuthorName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Categories` [IReadOnlyList&lt;Category&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

`WorksInfo` [IReadOnlyList&lt;Work&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **Works(Works)**

```csharp
protected Works(Works original)
```

#### Parameters

`original` [Works](./literoticaapi/dataobjects/works.md)<br>

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

### **Equals(Works)**

```csharp
public bool Equals(Works other)
```

#### Parameters

`other` [Works](./literoticaapi/dataobjects/works.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Works <Clone>$()
```

#### Returns

[Works](./literoticaapi/dataobjects/works.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&, Object&, Nullable`1&, Nullable`1&, String&, Nullable`1&, String&, Object&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, String&, IReadOnlyList`1&, IReadOnlyList`1&)**

```csharp
public void Deconstruct(Nullable`1& Id, Nullable`1& UserId, Object& Url, Nullable`1& CreatedAt, Nullable`1& ModifiedAt, String& Title, Nullable`1& Language, String& State, Object& Description, Nullable`1& ViewCount, Nullable`1& CommentsCount, Nullable`1& FavoritesCount, Nullable`1& ListsCount, String& AuthorName, IReadOnlyList`1& Categories, IReadOnlyList`1& WorksInfo)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`UserId` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Url` [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)<br>

`CreatedAt` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`ModifiedAt` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Title` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Language` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`State` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Description` [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)<br>

`ViewCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CommentsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FavoritesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`ListsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`AuthorName` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Categories` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`WorksInfo` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>
