# NewAuthors

Namespace: LiteroticaApi.DataObjects

```csharp
public class NewAuthors : System.IEquatable`1[[LiteroticaApi.DataObjects.NewAuthors, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [NewAuthors](./literoticaapi/dataobjects/newauthors.md)<br>
Implements [IEquatable&lt;NewAuthors&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public IReadOnlyList<Author> Data { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Author&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

## Constructors

### **NewAuthors(IReadOnlyList&lt;Author&gt;)**

```csharp
public NewAuthors(IReadOnlyList<Author> Data)
```

#### Parameters

`Data` [IReadOnlyList&lt;Author&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **NewAuthors(NewAuthors)**

```csharp
protected NewAuthors(NewAuthors original)
```

#### Parameters

`original` [NewAuthors](./literoticaapi/dataobjects/newauthors.md)<br>

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

### **Equals(NewAuthors)**

```csharp
public bool Equals(NewAuthors other)
```

#### Parameters

`other` [NewAuthors](./literoticaapi/dataobjects/newauthors.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public NewAuthors <Clone>$()
```

#### Returns

[NewAuthors](./literoticaapi/dataobjects/newauthors.md)<br>

### **Deconstruct(IReadOnlyList`1&)**

```csharp
public void Deconstruct(IReadOnlyList`1& Data)
```

#### Parameters

`Data` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>
