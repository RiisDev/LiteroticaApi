# TopCommentersDatum

Namespace: LiteroticaApi.DataObjects

Represents a single top commenter entry with basic identification and activity metrics.

```csharp
public class TopCommentersDatum : System.IEquatable`1[[LiteroticaApi.DataObjects.TopCommentersDatum, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TopCommentersDatum](./literoticaapi/dataobjects/topcommentersdatum.md)<br>
Implements [IEquatable&lt;TopCommentersDatum&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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

### **Name**

```csharp
public string Name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TotalComments**

```csharp
public Nullable<int> TotalComments { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **TopCommentersDatum(Nullable&lt;Int32&gt;, String, Nullable&lt;Int32&gt;)**

Represents a single top commenter entry with basic identification and activity metrics.

```csharp
public TopCommentersDatum(Nullable<int> Id, string Name, Nullable<int> TotalComments)
```

#### Parameters

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`TotalComments` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TopCommentersDatum(TopCommentersDatum)**

```csharp
protected TopCommentersDatum(TopCommentersDatum original)
```

#### Parameters

`original` [TopCommentersDatum](./literoticaapi/dataobjects/topcommentersdatum.md)<br>

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

### **Equals(TopCommentersDatum)**

```csharp
public bool Equals(TopCommentersDatum other)
```

#### Parameters

`other` [TopCommentersDatum](./literoticaapi/dataobjects/topcommentersdatum.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public TopCommentersDatum <Clone>$()
```

#### Returns

[TopCommentersDatum](./literoticaapi/dataobjects/topcommentersdatum.md)<br>

### **Deconstruct(Nullable`1&, String&, Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& Id, String& Name, Nullable`1& TotalComments)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Name` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`TotalComments` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
