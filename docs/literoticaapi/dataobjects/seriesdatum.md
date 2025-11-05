# SeriesDatum

Namespace: LiteroticaApi.DataObjects

Represents a series containing multiple story items and its related metadata.

```csharp
public class SeriesDatum : System.IEquatable`1[[LiteroticaApi.DataObjects.SeriesDatum, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SeriesDatum](./literoticaapi/dataobjects/seriesdatum.md)<br>
Implements [IEquatable&lt;SeriesDatum&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public Meta Meta { get; set; }
```

#### Property Value

[Meta](./literoticaapi/dataobjects/meta.md)<br>

### **Items**

```csharp
public IReadOnlyList<Item> Items { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Item&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

## Constructors

### **SeriesDatum(Meta, IReadOnlyList&lt;Item&gt;)**

Represents a series containing multiple story items and its related metadata.

```csharp
public SeriesDatum(Meta Meta, IReadOnlyList<Item> Items)
```

#### Parameters

`Meta` [Meta](./literoticaapi/dataobjects/meta.md)<br>

`Items` [IReadOnlyList&lt;Item&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **SeriesDatum(SeriesDatum)**

```csharp
protected SeriesDatum(SeriesDatum original)
```

#### Parameters

`original` [SeriesDatum](./literoticaapi/dataobjects/seriesdatum.md)<br>

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

### **Equals(SeriesDatum)**

```csharp
public bool Equals(SeriesDatum other)
```

#### Parameters

`other` [SeriesDatum](./literoticaapi/dataobjects/seriesdatum.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public SeriesDatum <Clone>$()
```

#### Returns

[SeriesDatum](./literoticaapi/dataobjects/seriesdatum.md)<br>

### **Deconstruct(Meta&, IReadOnlyList`1&)**

```csharp
public void Deconstruct(Meta& Meta, IReadOnlyList`1& Items)
```

#### Parameters

`Meta` [Meta&](./literoticaapi/dataobjects/meta&.md)<br>

`Items` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>
