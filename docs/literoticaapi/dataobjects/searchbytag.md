# SearchByTag

Namespace: LiteroticaApi.DataObjects

Represents a collection of stories found under a specific tag, along with related metadata.

```csharp
public class SearchByTag : System.IEquatable`1[[LiteroticaApi.DataObjects.SearchByTag, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SearchByTag](./literoticaapi/dataobjects/searchbytag.md)<br>
Implements [IEquatable&lt;SearchByTag&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Meta**

```csharp
public SearchByTagMeta Meta { get; set; }
```

#### Property Value

[SearchByTagMeta](./literoticaapi/dataobjects/searchbytagmeta.md)<br>

### **Submissions**

```csharp
public IReadOnlyList<Submission> Submissions { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Submission&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

## Constructors

### **SearchByTag(SearchByTagMeta, IReadOnlyList&lt;Submission&gt;)**

Represents a collection of stories found under a specific tag, along with related metadata.

```csharp
public SearchByTag(SearchByTagMeta Meta, IReadOnlyList<Submission> Submissions)
```

#### Parameters

`Meta` [SearchByTagMeta](./literoticaapi/dataobjects/searchbytagmeta.md)<br>

`Submissions` [IReadOnlyList&lt;Submission&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **SearchByTag(SearchByTag)**

```csharp
protected SearchByTag(SearchByTag original)
```

#### Parameters

`original` [SearchByTag](./literoticaapi/dataobjects/searchbytag.md)<br>

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

### **Equals(SearchByTag)**

```csharp
public bool Equals(SearchByTag other)
```

#### Parameters

`other` [SearchByTag](./literoticaapi/dataobjects/searchbytag.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public SearchByTag <Clone>$()
```

#### Returns

[SearchByTag](./literoticaapi/dataobjects/searchbytag.md)<br>

### **Deconstruct(SearchByTagMeta&, IReadOnlyList`1&)**

```csharp
public void Deconstruct(SearchByTagMeta& Meta, IReadOnlyList`1& Submissions)
```

#### Parameters

`Meta` [SearchByTagMeta&](./literoticaapi/dataobjects/searchbytagmeta&.md)<br>

`Submissions` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>
