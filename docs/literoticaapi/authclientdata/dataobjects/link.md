# Link

Namespace: LiteroticaApi.AuthClientData.DataObjects

Represents a hyperlink reference with display label and active state.

```csharp
public class Link : System.IEquatable`1[[LiteroticaApi.AuthClientData.DataObjects.Link, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Link](./literoticaapi/authclientdata/dataobjects/link.md)<br>
Implements [IEquatable&lt;Link&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Url**

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Label**

```csharp
public string Label { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Active**

```csharp
public Nullable<bool> Active { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **Link(String, String, Nullable&lt;Boolean&gt;)**

Represents a hyperlink reference with display label and active state.

```csharp
public Link(string Url, string Label, Nullable<bool> Active)
```

#### Parameters

`Url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Label` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Active` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Link(Link)**

```csharp
protected Link(Link original)
```

#### Parameters

`original` [Link](./literoticaapi/authclientdata/dataobjects/link.md)<br>

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

### **Equals(Link)**

```csharp
public bool Equals(Link other)
```

#### Parameters

`other` [Link](./literoticaapi/authclientdata/dataobjects/link.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Link <Clone>$()
```

#### Returns

[Link](./literoticaapi/authclientdata/dataobjects/link.md)<br>

### **Deconstruct(String&, String&, Nullable`1&)**

```csharp
public void Deconstruct(String& Url, String& Label, Nullable`1& Active)
```

#### Parameters

`Url` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Label` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Active` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
