# Desktop

Namespace: LiteroticaApi.DataObjects

Represents desktop-specific asset resolutions (x1, x2, x3).

```csharp
public class Desktop : System.IEquatable`1[[LiteroticaApi.DataObjects.Desktop, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Desktop](./literoticaapi/dataobjects/desktop.md)<br>
Implements [IEquatable&lt;Desktop&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **X1**

```csharp
public X1 X1 { get; set; }
```

#### Property Value

[X1](./literoticaapi/dataobjects/x1.md)<br>

### **X2**

```csharp
public X2 X2 { get; set; }
```

#### Property Value

[X2](./literoticaapi/dataobjects/x2.md)<br>

### **X3**

```csharp
public X3 X3 { get; set; }
```

#### Property Value

[X3](./literoticaapi/dataobjects/x3.md)<br>

## Constructors

### **Desktop(X1, X2, X3)**

Represents desktop-specific asset resolutions (x1, x2, x3).

```csharp
public Desktop(X1 X1, X2 X2, X3 X3)
```

#### Parameters

`X1` [X1](./literoticaapi/dataobjects/x1.md)<br>

`X2` [X2](./literoticaapi/dataobjects/x2.md)<br>

`X3` [X3](./literoticaapi/dataobjects/x3.md)<br>

### **Desktop(Desktop)**

```csharp
protected Desktop(Desktop original)
```

#### Parameters

`original` [Desktop](./literoticaapi/dataobjects/desktop.md)<br>

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

### **Equals(Desktop)**

```csharp
public bool Equals(Desktop other)
```

#### Parameters

`other` [Desktop](./literoticaapi/dataobjects/desktop.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Desktop <Clone>$()
```

#### Returns

[Desktop](./literoticaapi/dataobjects/desktop.md)<br>

### **Deconstruct(X1&, X2&, X3&)**

```csharp
public void Deconstruct(X1& X1, X2& X2, X3& X3)
```

#### Parameters

`X1` [X1&](./literoticaapi/dataobjects/x1&.md)<br>

`X2` [X2&](./literoticaapi/dataobjects/x2&.md)<br>

`X3` [X3&](./literoticaapi/dataobjects/x3&.md)<br>
