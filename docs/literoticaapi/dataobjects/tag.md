# Tag

Namespace: LiteroticaApi.DataObjects

Represents a tag entity used for categorizing stories, including its text and ban status.

```csharp
public class Tag : System.IEquatable`1[[LiteroticaApi.DataObjects.Tag, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Tag](./literoticaapi/dataobjects/tag.md)<br>
Implements [IEquatable&lt;Tag&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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

### **TagText**

```csharp
public StringOrInt TagText { get; set; }
```

#### Property Value

[StringOrInt](./literoticaapi/dataobjects/stringorint.md)<br>

### **IsBanned**

```csharp
public Nullable<int> IsBanned { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **Tag(Nullable&lt;Int32&gt;, StringOrInt, Nullable&lt;Int32&gt;)**

Represents a tag entity used for categorizing stories, including its text and ban status.

```csharp
public Tag(Nullable<int> Id, StringOrInt TagText, Nullable<int> IsBanned)
```

#### Parameters

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`TagText` [StringOrInt](./literoticaapi/dataobjects/stringorint.md)<br>

`IsBanned` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Tag(Tag)**

```csharp
protected Tag(Tag original)
```

#### Parameters

`original` [Tag](./literoticaapi/dataobjects/tag.md)<br>

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

### **Equals(Tag)**

```csharp
public bool Equals(Tag other)
```

#### Parameters

`other` [Tag](./literoticaapi/dataobjects/tag.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Tag <Clone>$()
```

#### Returns

[Tag](./literoticaapi/dataobjects/tag.md)<br>

### **Deconstruct(Nullable`1&, StringOrInt&, Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& Id, StringOrInt& TagText, Nullable`1& IsBanned)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`TagText` [StringOrInt&](./literoticaapi/dataobjects/stringorint&.md)<br>

`IsBanned` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
