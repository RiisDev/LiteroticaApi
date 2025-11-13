# Who

Namespace: LiteroticaApi.AuthClientData.DataObjects

Represents a user involved in an activity — either the actor or the target.

```csharp
public class Who : System.IEquatable`1[[LiteroticaApi.AuthClientData.DataObjects.Who, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Who](./literoticaapi/authclientdata/dataobjects/who.md)<br>
Implements [IEquatable&lt;Who&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Userid**

```csharp
public Nullable<int> Userid { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Username**

```csharp
public string Username { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Userpic**

```csharp
public string Userpic { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **Who(Nullable&lt;Int32&gt;, String, String)**

Represents a user involved in an activity — either the actor or the target.

```csharp
public Who(Nullable<int> Userid, string Username, string Userpic)
```

#### Parameters

`Userid` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Userpic` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Who(Who)**

```csharp
protected Who(Who original)
```

#### Parameters

`original` [Who](./literoticaapi/authclientdata/dataobjects/who.md)<br>

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

### **Equals(Who)**

```csharp
public bool Equals(Who other)
```

#### Parameters

`other` [Who](./literoticaapi/authclientdata/dataobjects/who.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Who <Clone>$()
```

#### Returns

[Who](./literoticaapi/authclientdata/dataobjects/who.md)<br>

### **Deconstruct(Nullable`1&, String&, String&)**

```csharp
public void Deconstruct(Nullable`1& Userid, String& Username, String& Userpic)
```

#### Parameters

`Userid` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Username` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Userpic` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
