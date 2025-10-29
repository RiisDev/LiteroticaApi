# Error

Namespace: LiteroticaApi

```csharp
public class Error : System.IEquatable`1[[LiteroticaApi.Error, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Error](./literoticaapi/error.md)<br>
Implements [IEquatable&lt;Error&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

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

### **Message**

```csharp
public string Message { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **Error(Nullable&lt;Boolean&gt;, String)**

```csharp
public Error(Nullable<bool> Success, string Message)
```

#### Parameters

`Success` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Message` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Error(Error)**

```csharp
protected Error(Error original)
```

#### Parameters

`original` [Error](./literoticaapi/error.md)<br>

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

### **Equals(Error)**

```csharp
public bool Equals(Error other)
```

#### Parameters

`other` [Error](./literoticaapi/error.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Error <Clone>$()
```

#### Returns

[Error](./literoticaapi/error.md)<br>

### **Deconstruct(Nullable`1&, String&)**

```csharp
public void Deconstruct(Nullable`1& Success, String& Message)
```

#### Parameters

`Success` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Message` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
