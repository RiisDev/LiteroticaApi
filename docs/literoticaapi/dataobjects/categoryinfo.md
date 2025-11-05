# CategoryInfo

Namespace: LiteroticaApi.DataObjects

Represents information about a story category, including its name, description, and type.

```csharp
public class CategoryInfo : System.IEquatable`1[[LiteroticaApi.DataObjects.CategoryInfo, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CategoryInfo](./literoticaapi/dataobjects/categoryinfo.md)<br>
Implements [IEquatable&lt;CategoryInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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

### **Ldesc**

```csharp
public string Ldesc { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Sdesc**

```csharp
public string Sdesc { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Type**

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PageUrl**

```csharp
public string PageUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **CategoryInfo(Nullable&lt;Int32&gt;, String, String, String, String, String)**

Represents information about a story category, including its name, description, and type.

```csharp
public CategoryInfo(Nullable<int> Id, string Name, string Ldesc, string Sdesc, string Type, string PageUrl)
```

#### Parameters

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Ldesc` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Sdesc` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Type` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`PageUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CategoryInfo(CategoryInfo)**

```csharp
protected CategoryInfo(CategoryInfo original)
```

#### Parameters

`original` [CategoryInfo](./literoticaapi/dataobjects/categoryinfo.md)<br>

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

### **Equals(CategoryInfo)**

```csharp
public bool Equals(CategoryInfo other)
```

#### Parameters

`other` [CategoryInfo](./literoticaapi/dataobjects/categoryinfo.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public CategoryInfo <Clone>$()
```

#### Returns

[CategoryInfo](./literoticaapi/dataobjects/categoryinfo.md)<br>

### **Deconstruct(Nullable`1&, String&, String&, String&, String&, String&)**

```csharp
public void Deconstruct(Nullable`1& Id, String& Name, String& Ldesc, String& Sdesc, String& Type, String& PageUrl)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Name` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Ldesc` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Sdesc` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Type` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`PageUrl` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
