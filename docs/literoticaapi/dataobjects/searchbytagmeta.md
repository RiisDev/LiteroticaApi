# SearchByTagMeta

Namespace: LiteroticaApi.DataObjects

Represents metadata specific to tag-based search queries.

```csharp
public class SearchByTagMeta : System.IEquatable`1[[LiteroticaApi.DataObjects.SearchByTagMeta, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SearchByTagMeta](./literoticaapi/dataobjects/searchbytagmeta.md)<br>
Implements [IEquatable&lt;SearchByTagMeta&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **SubmissionsCount**

```csharp
public Nullable<int> SubmissionsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PeriodChecks**

```csharp
public PeriodChecks PeriodChecks { get; set; }
```

#### Property Value

[PeriodChecks](./literoticaapi/dataobjects/periodchecks.md)<br>

## Constructors

### **SearchByTagMeta(Nullable&lt;Int32&gt;, PeriodChecks)**

Represents metadata specific to tag-based search queries.

```csharp
public SearchByTagMeta(Nullable<int> SubmissionsCount, PeriodChecks PeriodChecks)
```

#### Parameters

`SubmissionsCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`PeriodChecks` [PeriodChecks](./literoticaapi/dataobjects/periodchecks.md)<br>

### **SearchByTagMeta(SearchByTagMeta)**

```csharp
protected SearchByTagMeta(SearchByTagMeta original)
```

#### Parameters

`original` [SearchByTagMeta](./literoticaapi/dataobjects/searchbytagmeta.md)<br>

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

### **Equals(SearchByTagMeta)**

```csharp
public bool Equals(SearchByTagMeta other)
```

#### Parameters

`other` [SearchByTagMeta](./literoticaapi/dataobjects/searchbytagmeta.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public SearchByTagMeta <Clone>$()
```

#### Returns

[SearchByTagMeta](./literoticaapi/dataobjects/searchbytagmeta.md)<br>

### **Deconstruct(Nullable`1&, PeriodChecks&)**

```csharp
public void Deconstruct(Nullable`1& SubmissionsCount, PeriodChecks& PeriodChecks)
```

#### Parameters

`SubmissionsCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`PeriodChecks` [PeriodChecks&](./literoticaapi/dataobjects/periodchecks&.md)<br>
