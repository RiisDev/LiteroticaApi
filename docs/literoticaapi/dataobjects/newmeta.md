# NewMeta

Namespace: LiteroticaApi.DataObjects

Represents metadata for newly added submissions.

```csharp
public class NewMeta : System.IEquatable`1[[LiteroticaApi.DataObjects.NewMeta, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [NewMeta](./literoticaapi/dataobjects/newmeta.md)<br>
Implements [IEquatable&lt;NewMeta&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **SubmissionsCount**

```csharp
public Nullable<int> SubmissionsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **NewMeta(Nullable&lt;Int32&gt;)**

Represents metadata for newly added submissions.

```csharp
public NewMeta(Nullable<int> SubmissionsCount)
```

#### Parameters

`SubmissionsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **NewMeta(NewMeta)**

```csharp
protected NewMeta(NewMeta original)
```

#### Parameters

`original` [NewMeta](./literoticaapi/dataobjects/newmeta.md)<br>

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

### **Equals(NewMeta)**

```csharp
public bool Equals(NewMeta other)
```

#### Parameters

`other` [NewMeta](./literoticaapi/dataobjects/newmeta.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public NewMeta <Clone>$()
```

#### Returns

[NewMeta](./literoticaapi/dataobjects/newmeta.md)<br>

### **Deconstruct(Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& SubmissionsCount)
```

#### Parameters

`SubmissionsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
