# What

Namespace: LiteroticaApi.AuthClientData.DataObjects

Represents the subject of an activity, which may be either a biography change or a story reference.

```csharp
public class What : System.IEquatable`1[[LiteroticaApi.AuthClientData.DataObjects.What, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [What](./literoticaapi/authclientdata/dataobjects/what.md)<br>
Implements [IEquatable&lt;What&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Biography**

```csharp
public IReadOnlyList<string> Biography { get; set; }
```

#### Property Value

[IReadOnlyList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **Story**

```csharp
public Story Story { get; set; }
```

#### Property Value

[Story](./literoticaapi/dataobjects/story.md)<br>

### **IsBiography**

Indicates whether the activity involves a biography update.

```csharp
public bool IsBiography { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsStory**

Indicates whether the activity involves a story.

```csharp
public bool IsStory { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### **What(IReadOnlyList&lt;String&gt;, Story)**

Represents the subject of an activity, which may be either a biography change or a story reference.

```csharp
public What(IReadOnlyList<string> Biography, Story Story)
```

#### Parameters

`Biography` [IReadOnlyList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

`Story` [Story](./literoticaapi/dataobjects/story.md)<br>

### **What(What)**

```csharp
protected What(What original)
```

#### Parameters

`original` [What](./literoticaapi/authclientdata/dataobjects/what.md)<br>

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

### **Equals(What)**

```csharp
public bool Equals(What other)
```

#### Parameters

`other` [What](./literoticaapi/authclientdata/dataobjects/what.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public What <Clone>$()
```

#### Returns

[What](./literoticaapi/authclientdata/dataobjects/what.md)<br>

### **Deconstruct(IReadOnlyList`1&, Story&)**

```csharp
public void Deconstruct(IReadOnlyList`1& Biography, Story& Story)
```

#### Parameters

`Biography` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`Story` [Story&](./literoticaapi/dataobjects/story&.md)<br>
