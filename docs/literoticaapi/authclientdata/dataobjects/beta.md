# Beta

Namespace: LiteroticaApi.AuthClientData.DataObjects

Represents beta feature flags for user account features.

```csharp
public class Beta : System.IEquatable`1[[LiteroticaApi.AuthClientData.DataObjects.Beta, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Beta](./literoticaapi/authclientdata/dataobjects/beta.md)<br>
Implements [IEquatable&lt;Beta&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Story**

```csharp
public Nullable<bool> Story { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **Beta(Nullable&lt;Boolean&gt;)**

Represents beta feature flags for user account features.

```csharp
public Beta(Nullable<bool> Story)
```

#### Parameters

`Story` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Beta(Beta)**

```csharp
protected Beta(Beta original)
```

#### Parameters

`original` [Beta](./literoticaapi/authclientdata/dataobjects/beta.md)<br>

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

### **Equals(Beta)**

```csharp
public bool Equals(Beta other)
```

#### Parameters

`other` [Beta](./literoticaapi/authclientdata/dataobjects/beta.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Beta <Clone>$()
```

#### Returns

[Beta](./literoticaapi/authclientdata/dataobjects/beta.md)<br>

### **Deconstruct(Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& Story)
```

#### Parameters

`Story` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
