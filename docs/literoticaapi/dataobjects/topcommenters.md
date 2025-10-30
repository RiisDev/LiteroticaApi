# TopCommenters

Namespace: LiteroticaApi.DataObjects

Represents the response model containing a list of top commenters and pagination metadata.

```csharp
public class TopCommenters : System.IEquatable`1[[LiteroticaApi.DataObjects.TopCommenters, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TopCommenters](./literoticaapi/dataobjects/topcommenters.md)<br>
Implements [IEquatable&lt;TopCommenters&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public TopCommentersMeta Meta { get; set; }
```

#### Property Value

[TopCommentersMeta](./literoticaapi/dataobjects/topcommentersmeta.md)<br>

### **Data**

```csharp
public IReadOnlyList<TopCommentersDatum> Data { get; set; }
```

#### Property Value

[IReadOnlyList&lt;TopCommentersDatum&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

## Constructors

### **TopCommenters(TopCommentersMeta, IReadOnlyList&lt;TopCommentersDatum&gt;)**

Represents the response model containing a list of top commenters and pagination metadata.

```csharp
public TopCommenters(TopCommentersMeta Meta, IReadOnlyList<TopCommentersDatum> Data)
```

#### Parameters

`Meta` [TopCommentersMeta](./literoticaapi/dataobjects/topcommentersmeta.md)<br>

`Data` [IReadOnlyList&lt;TopCommentersDatum&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **TopCommenters(TopCommenters)**

```csharp
protected TopCommenters(TopCommenters original)
```

#### Parameters

`original` [TopCommenters](./literoticaapi/dataobjects/topcommenters.md)<br>

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

### **Equals(TopCommenters)**

```csharp
public bool Equals(TopCommenters other)
```

#### Parameters

`other` [TopCommenters](./literoticaapi/dataobjects/topcommenters.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public TopCommenters <Clone>$()
```

#### Returns

[TopCommenters](./literoticaapi/dataobjects/topcommenters.md)<br>

### **Deconstruct(TopCommentersMeta&, IReadOnlyList`1&)**

```csharp
public void Deconstruct(TopCommentersMeta& Meta, IReadOnlyList`1& Data)
```

#### Parameters

`Meta` [TopCommentersMeta&](./literoticaapi/dataobjects/topcommentersmeta&.md)<br>

`Data` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>
