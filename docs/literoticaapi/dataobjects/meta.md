# Meta

Namespace: LiteroticaApi.DataObjects

```csharp
public class Meta : System.IEquatable`1[[LiteroticaApi.DataObjects.Meta, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Meta](./literoticaapi/dataobjects/meta.md)<br>
Implements [IEquatable&lt;Meta&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **PagesCount**

```csharp
public Nullable<int> PagesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Id**

```csharp
public Nullable<int> Id { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Title**

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CreatedAt**

```csharp
public string CreatedAt { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UpdatedAt**

```csharp
public string UpdatedAt { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Order**

```csharp
public IReadOnlyList<Nullable<int>> Order { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

## Constructors

### **Meta(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, String, String, String, String, IReadOnlyList&lt;Nullable&lt;Int32&gt;&gt;)**

```csharp
public Meta(Nullable<int> PagesCount, Nullable<int> Id, string Title, string Url, string CreatedAt, string UpdatedAt, IReadOnlyList<Nullable<int>> Order)
```

#### Parameters

`PagesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`CreatedAt` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`UpdatedAt` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Order` [IReadOnlyList&lt;Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **Meta(Meta)**

```csharp
protected Meta(Meta original)
```

#### Parameters

`original` [Meta](./literoticaapi/dataobjects/meta.md)<br>

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

### **Equals(Meta)**

```csharp
public bool Equals(Meta other)
```

#### Parameters

`other` [Meta](./literoticaapi/dataobjects/meta.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Meta <Clone>$()
```

#### Returns

[Meta](./literoticaapi/dataobjects/meta.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&, String&, String&, String&, String&, IReadOnlyList`1&)**

```csharp
public void Deconstruct(Nullable`1& PagesCount, Nullable`1& Id, String& Title, String& Url, String& CreatedAt, String& UpdatedAt, IReadOnlyList`1& Order)
```

#### Parameters

`PagesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Title` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Url` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`CreatedAt` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`UpdatedAt` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Order` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>
