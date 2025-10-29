# GetNew

Namespace: LiteroticaApi.DataObjects

```csharp
public class GetNew : System.IEquatable`1[[LiteroticaApi.DataObjects.GetNew, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [GetNew](./literoticaapi/dataobjects/getnew.md)<br>
Implements [IEquatable&lt;GetNew&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public NewMeta Meta { get; set; }
```

#### Property Value

[NewMeta](./literoticaapi/dataobjects/newmeta.md)<br>

### **Submissions**

```csharp
public IReadOnlyList<Submission> Submissions { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Submission&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

## Constructors

### **GetNew(NewMeta, IReadOnlyList&lt;Submission&gt;)**

```csharp
public GetNew(NewMeta Meta, IReadOnlyList<Submission> Submissions)
```

#### Parameters

`Meta` [NewMeta](./literoticaapi/dataobjects/newmeta.md)<br>

`Submissions` [IReadOnlyList&lt;Submission&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **GetNew(GetNew)**

```csharp
protected GetNew(GetNew original)
```

#### Parameters

`original` [GetNew](./literoticaapi/dataobjects/getnew.md)<br>

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

### **Equals(GetNew)**

```csharp
public bool Equals(GetNew other)
```

#### Parameters

`other` [GetNew](./literoticaapi/dataobjects/getnew.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public GetNew <Clone>$()
```

#### Returns

[GetNew](./literoticaapi/dataobjects/getnew.md)<br>

### **Deconstruct(NewMeta&, IReadOnlyList`1&)**

```csharp
public void Deconstruct(NewMeta& Meta, IReadOnlyList`1& Submissions)
```

#### Parameters

`Meta` [NewMeta&](./literoticaapi/dataobjects/newmeta&.md)<br>

`Submissions` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>
