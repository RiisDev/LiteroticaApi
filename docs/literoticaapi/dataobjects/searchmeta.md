# SearchMeta

Namespace: LiteroticaApi.DataObjects

```csharp
public class SearchMeta : System.IEquatable`1[[LiteroticaApi.DataObjects.SearchMeta, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SearchMeta](./literoticaapi/dataobjects/searchmeta.md)<br>
Implements [IEquatable&lt;SearchMeta&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **PageSize**

```csharp
public Nullable<int> PageSize { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Total**

```csharp
public Nullable<int> Total { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **SearchMeta(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

```csharp
public SearchMeta(Nullable<int> PageSize, Nullable<int> Total)
```

#### Parameters

`PageSize` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Total` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SearchMeta(SearchMeta)**

```csharp
protected SearchMeta(SearchMeta original)
```

#### Parameters

`original` [SearchMeta](./literoticaapi/dataobjects/searchmeta.md)<br>

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

### **Equals(SearchMeta)**

```csharp
public bool Equals(SearchMeta other)
```

#### Parameters

`other` [SearchMeta](./literoticaapi/dataobjects/searchmeta.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public SearchMeta <Clone>$()
```

#### Returns

[SearchMeta](./literoticaapi/dataobjects/searchmeta.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& PageSize, Nullable`1& Total)
```

#### Parameters

`PageSize` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Total` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
