# CommentHistory

Namespace: LiteroticaApi.DataObjects

```csharp
public class CommentHistory : System.IEquatable`1[[LiteroticaApi.DataObjects.CommentHistory, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CommentHistory](./literoticaapi/dataobjects/commenthistory.md)<br>
Implements [IEquatable&lt;CommentHistory&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public CommentHistoryMeta Meta { get; set; }
```

#### Property Value

[CommentHistoryMeta](./literoticaapi/dataobjects/commenthistorymeta.md)<br>

### **Data**

```csharp
public IReadOnlyList<CommentHistoryDatum> Data { get; set; }
```

#### Property Value

[IReadOnlyList&lt;CommentHistoryDatum&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

## Constructors

### **CommentHistory(CommentHistoryMeta, IReadOnlyList&lt;CommentHistoryDatum&gt;)**

```csharp
public CommentHistory(CommentHistoryMeta Meta, IReadOnlyList<CommentHistoryDatum> Data)
```

#### Parameters

`Meta` [CommentHistoryMeta](./literoticaapi/dataobjects/commenthistorymeta.md)<br>

`Data` [IReadOnlyList&lt;CommentHistoryDatum&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **CommentHistory(CommentHistory)**

```csharp
protected CommentHistory(CommentHistory original)
```

#### Parameters

`original` [CommentHistory](./literoticaapi/dataobjects/commenthistory.md)<br>

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

### **Equals(CommentHistory)**

```csharp
public bool Equals(CommentHistory other)
```

#### Parameters

`other` [CommentHistory](./literoticaapi/dataobjects/commenthistory.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public CommentHistory <Clone>$()
```

#### Returns

[CommentHistory](./literoticaapi/dataobjects/commenthistory.md)<br>

### **Deconstruct(CommentHistoryMeta&, IReadOnlyList`1&)**

```csharp
public void Deconstruct(CommentHistoryMeta& Meta, IReadOnlyList`1& Data)
```

#### Parameters

`Meta` [CommentHistoryMeta&](./literoticaapi/dataobjects/commenthistorymeta&.md)<br>

`Data` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>
