# TagInfo

Namespace: LiteroticaApi.DataObjects

Represents detailed information about a specific tag, including category, language, and usage metrics.

```csharp
public class TagInfo : System.IEquatable`1[[LiteroticaApi.DataObjects.TagInfo, LiteroticaApi, Version=2.1.1.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TagInfo](./literoticaapi/dataobjects/taginfo.md)<br>
Implements [IEquatable&lt;TagInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Id**

```csharp
public Nullable<long> Id { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Tag**

```csharp
public string Tag { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Language**

```csharp
public Nullable<long> Language { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Tagid**

```csharp
public Nullable<long> Tagid { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Category**

```csharp
public Nullable<long> Category { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Cnt**

```csharp
public Nullable<long> Cnt { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsBanned**

```csharp
public Nullable<long> IsBanned { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **TagInfo(Nullable&lt;Int64&gt;, String, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;, Nullable&lt;Int64&gt;)**

Represents detailed information about a specific tag, including category, language, and usage metrics.

```csharp
public TagInfo(Nullable<long> Id, string Tag, Nullable<long> Language, Nullable<long> Tagid, Nullable<long> Category, Nullable<long> Cnt, Nullable<long> IsBanned)
```

#### Parameters

`Id` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Tag` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Language` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Tagid` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Category` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Cnt` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`IsBanned` [Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TagInfo(TagInfo)**

```csharp
protected TagInfo(TagInfo original)
```

#### Parameters

`original` [TagInfo](./literoticaapi/dataobjects/taginfo.md)<br>

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

### **Equals(TagInfo)**

```csharp
public bool Equals(TagInfo other)
```

#### Parameters

`other` [TagInfo](./literoticaapi/dataobjects/taginfo.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public TagInfo <Clone>$()
```

#### Returns

[TagInfo](./literoticaapi/dataobjects/taginfo.md)<br>

### **Deconstruct(Nullable`1&, String&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& Id, String& Tag, Nullable`1& Language, Nullable`1& Tagid, Nullable`1& Category, Nullable`1& Cnt, Nullable`1& IsBanned)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Tag` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Language` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Tagid` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Category` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Cnt` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`IsBanned` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
