# Cover

Namespace: LiteroticaApi.DataObjects

```csharp
public class Cover : System.IEquatable`1[[LiteroticaApi.DataObjects.Cover, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Cover](./literoticaapi/dataobjects/cover.md)<br>
Implements [IEquatable&lt;Cover&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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

### **Data**

```csharp
public Assets Data { get; set; }
```

#### Property Value

[Assets](./literoticaapi/dataobjects/assets.md)<br>

## Constructors

### **Cover(Nullable&lt;Boolean&gt;, Assets)**

```csharp
public Cover(Nullable<bool> Success, Assets Data)
```

#### Parameters

`Success` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Data` [Assets](./literoticaapi/dataobjects/assets.md)<br>

### **Cover(Cover)**

```csharp
protected Cover(Cover original)
```

#### Parameters

`original` [Cover](./literoticaapi/dataobjects/cover.md)<br>

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

### **Equals(Cover)**

```csharp
public bool Equals(Cover other)
```

#### Parameters

`other` [Cover](./literoticaapi/dataobjects/cover.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Cover <Clone>$()
```

#### Returns

[Cover](./literoticaapi/dataobjects/cover.md)<br>

### **Deconstruct(Nullable`1&, Assets&)**

```csharp
public void Deconstruct(Nullable`1& Success, Assets& Data)
```

#### Parameters

`Success` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Data` [Assets&](./literoticaapi/dataobjects/assets&.md)<br>
