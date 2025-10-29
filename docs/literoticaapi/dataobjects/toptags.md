# TopTags

Namespace: LiteroticaApi.DataObjects

```csharp
public class TopTags : System.IEquatable`1[[LiteroticaApi.DataObjects.TopTags, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TopTags](./literoticaapi/dataobjects/toptags.md)<br>
Implements [IEquatable&lt;TopTags&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public PeriodMeta Meta { get; set; }
```

#### Property Value

[PeriodMeta](./literoticaapi/dataobjects/periodmeta.md)<br>

### **Tags**

```csharp
public IReadOnlyList<TagInfo> Tags { get; set; }
```

#### Property Value

[IReadOnlyList&lt;TagInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

## Constructors

### **TopTags(PeriodMeta, IReadOnlyList&lt;TagInfo&gt;)**

```csharp
public TopTags(PeriodMeta Meta, IReadOnlyList<TagInfo> Tags)
```

#### Parameters

`Meta` [PeriodMeta](./literoticaapi/dataobjects/periodmeta.md)<br>

`Tags` [IReadOnlyList&lt;TagInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **TopTags(TopTags)**

```csharp
protected TopTags(TopTags original)
```

#### Parameters

`original` [TopTags](./literoticaapi/dataobjects/toptags.md)<br>

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

### **Equals(TopTags)**

```csharp
public bool Equals(TopTags other)
```

#### Parameters

`other` [TopTags](./literoticaapi/dataobjects/toptags.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public TopTags <Clone>$()
```

#### Returns

[TopTags](./literoticaapi/dataobjects/toptags.md)<br>

### **Deconstruct(PeriodMeta&, IReadOnlyList`1&)**

```csharp
public void Deconstruct(PeriodMeta& Meta, IReadOnlyList`1& Tags)
```

#### Parameters

`Meta` [PeriodMeta&](./literoticaapi/dataobjects/periodmeta&.md)<br>

`Tags` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>
