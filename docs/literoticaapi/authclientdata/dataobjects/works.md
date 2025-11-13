# Works

Namespace: LiteroticaApi.AuthClientData.DataObjects

Represents a paginated collection of favorite story entries.

```csharp
public class Works : System.IEquatable`1[[LiteroticaApi.AuthClientData.DataObjects.Works, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Works](./literoticaapi/authclientdata/dataobjects/works.md)<br>
Implements [IEquatable&lt;Works&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public IReadOnlyList<FavoriteStoriesDatum> Data { get; set; }
```

#### Property Value

[IReadOnlyList&lt;FavoriteStoriesDatum&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **Links**

```csharp
public IReadOnlyList<Link> Links { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Link&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **Meta**

```csharp
public Meta Meta { get; set; }
```

#### Property Value

[Meta](./literoticaapi/authclientdata/dataobjects/meta.md)<br>

## Constructors

### **Works(IReadOnlyList&lt;FavoriteStoriesDatum&gt;, IReadOnlyList&lt;Link&gt;, Meta)**

Represents a paginated collection of favorite story entries.

```csharp
public Works(IReadOnlyList<FavoriteStoriesDatum> Data, IReadOnlyList<Link> Links, Meta Meta)
```

#### Parameters

`Data` [IReadOnlyList&lt;FavoriteStoriesDatum&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

`Links` [IReadOnlyList&lt;Link&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

`Meta` [Meta](./literoticaapi/authclientdata/dataobjects/meta.md)<br>

### **Works(Works)**

```csharp
protected Works(Works original)
```

#### Parameters

`original` [Works](./literoticaapi/authclientdata/dataobjects/works.md)<br>

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

`other` [Works](./literoticaapi/authclientdata/dataobjects/works.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Works <Clone>$()
```

#### Returns

[Works](./literoticaapi/authclientdata/dataobjects/works.md)<br>

### **Deconstruct(IReadOnlyList`1&, IReadOnlyList`1&, Meta&)**

```csharp
public void Deconstruct(IReadOnlyList`1& Data, IReadOnlyList`1& Links, Meta& Meta)
```

#### Parameters

`Data` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`Links` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`Meta` [Meta&](./literoticaapi/authclientdata/dataobjects/meta&.md)<br>
