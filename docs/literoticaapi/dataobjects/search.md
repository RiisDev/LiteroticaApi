# Search

Namespace: LiteroticaApi.DataObjects

Represents a paginated list of search results, including the data and metadata.

```csharp
public class Search : System.IEquatable`1[[LiteroticaApi.DataObjects.Search, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Search](./literoticaapi/dataobjects/search.md)<br>
Implements [IEquatable&lt;Search&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Data**

```csharp
public IReadOnlyList<Submission> Data { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Submission&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **Meta**

```csharp
public SearchMeta Meta { get; set; }
```

#### Property Value

[SearchMeta](./literoticaapi/dataobjects/searchmeta.md)<br>

## Constructors

### **Search(IReadOnlyList&lt;Submission&gt;, SearchMeta)**

Represents a paginated list of search results, including the data and metadata.

```csharp
public Search(IReadOnlyList<Submission> Data, SearchMeta Meta)
```

#### Parameters

`Data` [IReadOnlyList&lt;Submission&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

`Meta` [SearchMeta](./literoticaapi/dataobjects/searchmeta.md)<br>

### **Search(Search)**

```csharp
protected Search(Search original)
```

#### Parameters

`original` [Search](./literoticaapi/dataobjects/search.md)<br>

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

### **Equals(Search)**

```csharp
public bool Equals(Search other)
```

#### Parameters

`other` [Search](./literoticaapi/dataobjects/search.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Search <Clone>$()
```

#### Returns

[Search](./literoticaapi/dataobjects/search.md)<br>

### **Deconstruct(IReadOnlyList`1&, SearchMeta&)**

```csharp
public void Deconstruct(IReadOnlyList`1& Data, SearchMeta& Meta)
```

#### Parameters

`Data` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`Meta` [SearchMeta&](./literoticaapi/dataobjects/searchmeta&.md)<br>
