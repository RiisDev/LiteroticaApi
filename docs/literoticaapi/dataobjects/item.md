# Item

Namespace: LiteroticaApi.DataObjects

```csharp
public class Item : System.IEquatable`1[[LiteroticaApi.DataObjects.Item, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Item](./literoticaapi/dataobjects/item.md)<br>
Implements [IEquatable&lt;Item&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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

### **CategoryInfo**

```csharp
public CategoryInfo CategoryInfo { get; set; }
```

#### Property Value

[CategoryInfo](./literoticaapi/dataobjects/categoryinfo.md)<br>

### **Category**

```csharp
public Nullable<int> Category { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Title**

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Type**

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **Item(Nullable&lt;Int32&gt;, CategoryInfo, Nullable&lt;Int32&gt;, String, String, String)**

```csharp
public Item(Nullable<int> Id, CategoryInfo CategoryInfo, Nullable<int> Category, string Title, string Type, string Url)
```

#### Parameters

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CategoryInfo` [CategoryInfo](./literoticaapi/dataobjects/categoryinfo.md)<br>

`Category` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Type` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Item(Item)**

```csharp
protected Item(Item original)
```

#### Parameters

`original` [Item](./literoticaapi/dataobjects/item.md)<br>

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

### **Equals(Item)**

```csharp
public bool Equals(Item other)
```

#### Parameters

`other` [Item](./literoticaapi/dataobjects/item.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Item <Clone>$()
```

#### Returns

[Item](./literoticaapi/dataobjects/item.md)<br>

### **Deconstruct(Nullable`1&, CategoryInfo&, Nullable`1&, String&, String&, String&)**

```csharp
public void Deconstruct(Nullable`1& Id, CategoryInfo& CategoryInfo, Nullable`1& Category, String& Title, String& Type, String& Url)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CategoryInfo` [CategoryInfo&](./literoticaapi/dataobjects/categoryinfo&.md)<br>

`Category` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Title` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Type` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Url` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
