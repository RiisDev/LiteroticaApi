# CommentHistoryMeta

Namespace: LiteroticaApi.DataObjects

Represents pagination and metadata information for a user's comment history on a specific story.

```csharp
public class CommentHistoryMeta : System.IEquatable`1[[LiteroticaApi.DataObjects.CommentHistoryMeta, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CommentHistoryMeta](./literoticaapi/dataobjects/commenthistorymeta.md)<br>
Implements [IEquatable&lt;CommentHistoryMeta&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **CurrentPage**

```csharp
public Nullable<int> CurrentPage { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LastPage**

```csharp
public Nullable<int> LastPage { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Total**

```csharp
public Nullable<int> Total { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PerPage**

```csharp
public Nullable<int> PerPage { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Work**

```csharp
public Story Work { get; set; }
```

#### Property Value

[Story](./literoticaapi/dataobjects/story.md)<br>

## Constructors

### **CommentHistoryMeta(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Story)**

Represents pagination and metadata information for a user's comment history on a specific story.

```csharp
public CommentHistoryMeta(Nullable<int> CurrentPage, Nullable<int> LastPage, Nullable<int> Total, Nullable<int> PerPage, Story Work)
```

#### Parameters

`CurrentPage` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`LastPage` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Total` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`PerPage` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Work` [Story](./literoticaapi/dataobjects/story.md)<br>

### **CommentHistoryMeta(CommentHistoryMeta)**

```csharp
protected CommentHistoryMeta(CommentHistoryMeta original)
```

#### Parameters

`original` [CommentHistoryMeta](./literoticaapi/dataobjects/commenthistorymeta.md)<br>

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

### **Equals(CommentHistoryMeta)**

```csharp
public bool Equals(CommentHistoryMeta other)
```

#### Parameters

`other` [CommentHistoryMeta](./literoticaapi/dataobjects/commenthistorymeta.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public CommentHistoryMeta <Clone>$()
```

#### Returns

[CommentHistoryMeta](./literoticaapi/dataobjects/commenthistorymeta.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Story&)**

```csharp
public void Deconstruct(Nullable`1& CurrentPage, Nullable`1& LastPage, Nullable`1& Total, Nullable`1& PerPage, Story& Work)
```

#### Parameters

`CurrentPage` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`LastPage` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Total` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`PerPage` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Work` [Story&](./literoticaapi/dataobjects/story&.md)<br>
