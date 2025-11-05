# RelatedTag

Namespace: LiteroticaApi.DataObjects

Represents a tag that is related to another tag, including its ID, display text, and usage count.

```csharp
public class RelatedTag : System.IEquatable`1[[LiteroticaApi.DataObjects.RelatedTag, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RelatedTag](./literoticaapi/dataobjects/relatedtag.md)<br>
Implements [IEquatable&lt;RelatedTag&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public Nullable<int> Id { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Tag**

```csharp
public StringOrInt Tag { get; set; }
```

#### Property Value

[StringOrInt](./literoticaapi/dataobjects/stringorint.md)<br>

### **Cnt**

```csharp
public Nullable<int> Cnt { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **RelatedTag(Nullable&lt;Int32&gt;, StringOrInt, Nullable&lt;Int32&gt;)**

Represents a tag that is related to another tag, including its ID, display text, and usage count.

```csharp
public RelatedTag(Nullable<int> Id, StringOrInt Tag, Nullable<int> Cnt)
```

#### Parameters

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Tag` [StringOrInt](./literoticaapi/dataobjects/stringorint.md)<br>

`Cnt` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RelatedTag(RelatedTag)**

```csharp
protected RelatedTag(RelatedTag original)
```

#### Parameters

`original` [RelatedTag](./literoticaapi/dataobjects/relatedtag.md)<br>

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

### **Equals(RelatedTag)**

```csharp
public bool Equals(RelatedTag other)
```

#### Parameters

`other` [RelatedTag](./literoticaapi/dataobjects/relatedtag.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public RelatedTag <Clone>$()
```

#### Returns

[RelatedTag](./literoticaapi/dataobjects/relatedtag.md)<br>

### **Deconstruct(Nullable`1&, StringOrInt&, Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& Id, StringOrInt& Tag, Nullable`1& Cnt)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Tag` [StringOrInt&](./literoticaapi/dataobjects/stringorint&.md)<br>

`Cnt` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
