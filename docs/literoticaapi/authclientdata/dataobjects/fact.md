# Fact

Namespace: LiteroticaApi.AuthClientData.DataObjects

Represents an individual profile fact such as height, weight, or preferences.

```csharp
public class Fact : System.IEquatable`1[[LiteroticaApi.AuthClientData.DataObjects.Fact, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Fact](./literoticaapi/authclientdata/dataobjects/fact.md)<br>
Implements [IEquatable&lt;Fact&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Field**

```csharp
public string Field { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Value**

```csharp
public string Value { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UpdatedAt**

```csharp
public string UpdatedAt { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PrivacyLevel**

```csharp
public Nullable<int> PrivacyLevel { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **Fact(String, String, String, Nullable&lt;Int32&gt;)**

Represents an individual profile fact such as height, weight, or preferences.

```csharp
public Fact(string Field, string Value, string UpdatedAt, Nullable<int> PrivacyLevel)
```

#### Parameters

`Field` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`UpdatedAt` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`PrivacyLevel` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Fact(Fact)**

```csharp
protected Fact(Fact original)
```

#### Parameters

`original` [Fact](./literoticaapi/authclientdata/dataobjects/fact.md)<br>

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

### **Equals(Fact)**

```csharp
public bool Equals(Fact other)
```

#### Parameters

`other` [Fact](./literoticaapi/authclientdata/dataobjects/fact.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Fact <Clone>$()
```

#### Returns

[Fact](./literoticaapi/authclientdata/dataobjects/fact.md)<br>

### **Deconstruct(String&, String&, String&, Nullable`1&)**

```csharp
public void Deconstruct(String& Field, String& Value, String& UpdatedAt, Nullable`1& PrivacyLevel)
```

#### Parameters

`Field` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Value` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`UpdatedAt` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`PrivacyLevel` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
