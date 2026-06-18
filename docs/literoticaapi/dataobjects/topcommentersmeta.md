# TopCommentersMeta

Namespace: LiteroticaApi.DataObjects

Metadata and pagination structure for the top commenters API response.

```csharp
public class TopCommentersMeta : System.IEquatable`1[[LiteroticaApi.DataObjects.TopCommentersMeta, LiteroticaApi, Version=2.1.1.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TopCommentersMeta](./literoticaapi/dataobjects/topcommentersmeta.md)<br>
Implements [IEquatable&lt;TopCommentersMeta&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public Nullable<long> CurrentPage { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LastPage**

```csharp
public Nullable<long> LastPage { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Total**

```csharp
public Nullable<long> Total { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PerPage**

```csharp
public Nullable<long> PerPage { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **TopCommentersMeta(Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;)**

Metadata and pagination structure for the top commenters API response.

```csharp
public TopCommentersMeta(Nullable<long> CurrentPage, Nullable<long> LastPage, Nullable<long> Total, Nullable<long> PerPage)
```

#### Parameters

`CurrentPage` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`LastPage` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Total` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`PerPage` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TopCommentersMeta(TopCommentersMeta)**

```csharp
protected TopCommentersMeta(TopCommentersMeta original)
```

#### Parameters

`original` [TopCommentersMeta](./literoticaapi/dataobjects/topcommentersmeta.md)<br>

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

### **Equals(TopCommentersMeta)**

```csharp
public bool Equals(TopCommentersMeta other)
```

#### Parameters

`other` [TopCommentersMeta](./literoticaapi/dataobjects/topcommentersmeta.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public TopCommentersMeta <Clone>$()
```

#### Returns

[TopCommentersMeta](./literoticaapi/dataobjects/topcommentersmeta.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& CurrentPage, Nullable`1& LastPage, Nullable`1& Total, Nullable`1& PerPage)
```

#### Parameters

`CurrentPage` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`LastPage` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Total` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`PerPage` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
