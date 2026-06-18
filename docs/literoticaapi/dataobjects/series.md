# Series

Namespace: LiteroticaApi.DataObjects

Represents a series of related stories or works, including parts, metadata, and creation details.

```csharp
public class Series : System.IEquatable`1[[LiteroticaApi.DataObjects.Series, LiteroticaApi, Version=2.1.1.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Series](./literoticaapi/dataobjects/series.md)<br>
Implements [IEquatable&lt;Series&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public object Description { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

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

## Constructors

### **Series(Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, String, Nullable&lt;DateTime&gt;, Nullable&lt;DateTime&gt;, String, Nullable&lt;Int64&gt;, String, Object, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, IReadOnlyList&lt;Part&gt;)**

Represents a series of related stories or works, including parts, metadata, and creation details.

```csharp
public Series(Nullable<long> Id, Nullable<long> UserId, string Url, Nullable<DateTime> CreatedAt, Nullable<DateTime> ModifiedAt, string Title, Nullable<long> Language, string State, object Description, Nullable<long> ViewCount, Nullable<long> CommentsCount, Nullable<long> FavoritesCount, Nullable<long> ListsCount, Nullable<long> WorkCount, IReadOnlyList<Part> Parts)
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

`Description` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`ViewCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CommentsCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`FavoritesCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`ListsCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`WorkCount` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Parts` [IReadOnlyList&lt;Part&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **Series(Series)**

```csharp
protected Series(Series original)
```

#### Parameters

`original` [Series](./literoticaapi/dataobjects/series.md)<br>

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

### **Equals(Series)**

```csharp
public bool Equals(Series other)
```

#### Parameters

`other` [Series](./literoticaapi/dataobjects/series.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Series <Clone>$()
```

#### Returns

[Series](./literoticaapi/dataobjects/series.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&, String&, Nullable`1&, Nullable`1&, String&, Nullable`1&, String&, Object&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, IReadOnlyList`1&)**

```csharp
public void Deconstruct(Nullable`1& Id, Nullable`1& UserId, String& Url, Nullable`1& CreatedAt, Nullable`1& ModifiedAt, String& Title, Nullable`1& Language, String& State, Object& Description, Nullable`1& ViewCount, Nullable`1& CommentsCount, Nullable`1& FavoritesCount, Nullable`1& ListsCount, Nullable`1& WorkCount, IReadOnlyList`1& Parts)
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

`Description` [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)<br>

`ViewCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CommentsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`FavoritesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`ListsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`WorkCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Parts` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>
