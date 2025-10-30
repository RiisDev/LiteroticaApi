# RootAuthor

Namespace: LiteroticaApi.DataObjects

Represents the root response for an author data request.

```csharp
public class RootAuthor : System.IEquatable`1[[LiteroticaApi.DataObjects.RootAuthor, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RootAuthor](./literoticaapi/dataobjects/rootauthor.md)<br>
Implements [IEquatable&lt;RootAuthor&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

**Remarks:**

This model wraps the author object along with success status, as returned by Literotica's API.

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Success**

```csharp
public Nullable<bool> Success { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **User**

```csharp
public Author User { get; set; }
```

#### Property Value

[Author](./literoticaapi/dataobjects/author.md)<br>

## Constructors

### **RootAuthor(Nullable&lt;Boolean&gt;, Author)**

Represents the root response for an author data request.

```csharp
public RootAuthor(Nullable<bool> Success, Author User)
```

#### Parameters

`Success` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`User` [Author](./literoticaapi/dataobjects/author.md)<br>

**Remarks:**

This model wraps the author object along with success status, as returned by Literotica's API.

### **RootAuthor(RootAuthor)**

```csharp
protected RootAuthor(RootAuthor original)
```

#### Parameters

`original` [RootAuthor](./literoticaapi/dataobjects/rootauthor.md)<br>

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

### **Equals(RootAuthor)**

```csharp
public bool Equals(RootAuthor other)
```

#### Parameters

`other` [RootAuthor](./literoticaapi/dataobjects/rootauthor.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public RootAuthor <Clone>$()
```

#### Returns

[RootAuthor](./literoticaapi/dataobjects/rootauthor.md)<br>

### **Deconstruct(Nullable`1&, Author&)**

```csharp
public void Deconstruct(Nullable`1& Success, Author& User)
```

#### Parameters

`Success` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`User` [Author&](./literoticaapi/dataobjects/author&.md)<br>
