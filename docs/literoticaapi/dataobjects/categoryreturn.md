# CategoryReturn

Namespace: LiteroticaApi.DataObjects

```csharp
public class CategoryReturn : System.IEquatable`1[[LiteroticaApi.DataObjects.CategoryReturn, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CategoryReturn](./literoticaapi/dataobjects/categoryreturn.md)<br>
Implements [IEquatable&lt;CategoryReturn&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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

### **Language**

```csharp
public Nullable<int> Language { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Ldesc**

```csharp
public string Ldesc { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Name**

```csharp
public string Name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PageUrl**

```csharp
public string PageUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Sdesc**

```csharp
public string Sdesc { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TopUrl**

```csharp
public string TopUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Type**

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SubmissionCount**

```csharp
public Nullable<int> SubmissionCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **CategoryReturn(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, String, String, String, String, String, String, Nullable&lt;Int32&gt;)**

```csharp
public CategoryReturn(Nullable<int> Id, Nullable<int> Language, string Ldesc, string Name, string PageUrl, string Sdesc, string TopUrl, string Type, Nullable<int> SubmissionCount)
```

#### Parameters

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Language` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Ldesc` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`PageUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Sdesc` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`TopUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Type` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`SubmissionCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CategoryReturn(CategoryReturn)**

```csharp
protected CategoryReturn(CategoryReturn original)
```

#### Parameters

`original` [CategoryReturn](./literoticaapi/dataobjects/categoryreturn.md)<br>

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

### **Equals(CategoryReturn)**

```csharp
public bool Equals(CategoryReturn other)
```

#### Parameters

`other` [CategoryReturn](./literoticaapi/dataobjects/categoryreturn.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public CategoryReturn <Clone>$()
```

#### Returns

[CategoryReturn](./literoticaapi/dataobjects/categoryreturn.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&, String&, String&, String&, String&, String&, String&, Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& Id, Nullable`1& Language, String& Ldesc, String& Name, String& PageUrl, String& Sdesc, String& TopUrl, String& Type, Nullable`1& SubmissionCount)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Language` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Ldesc` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Name` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`PageUrl` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Sdesc` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`TopUrl` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Type` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`SubmissionCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
