# FavoriteStories

Namespace: LiteroticaApi.AuthClientData.DataObjects

Represents a user's collection of favorite stories and related list metadata.

```csharp
public class FavoriteStories : System.IEquatable`1[[LiteroticaApi.AuthClientData.DataObjects.FavoriteStories, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [FavoriteStories](./literoticaapi/authclientdata/dataobjects/favoritestories.md)<br>
Implements [IEquatable&lt;FavoriteStories&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **List**

```csharp
public List List { get; set; }
```

#### Property Value

[List](./literoticaapi/authclientdata/dataobjects/list.md)<br>

### **Works**

```csharp
public Works Works { get; set; }
```

#### Property Value

[Works](./literoticaapi/authclientdata/dataobjects/works.md)<br>

## Constructors

### **FavoriteStories(List, Works)**

Represents a user's collection of favorite stories and related list metadata.

```csharp
public FavoriteStories(List List, Works Works)
```

#### Parameters

`List` [List](./literoticaapi/authclientdata/dataobjects/list.md)<br>

`Works` [Works](./literoticaapi/authclientdata/dataobjects/works.md)<br>

### **FavoriteStories(FavoriteStories)**

```csharp
protected FavoriteStories(FavoriteStories original)
```

#### Parameters

`original` [FavoriteStories](./literoticaapi/authclientdata/dataobjects/favoritestories.md)<br>

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

### **Equals(FavoriteStories)**

```csharp
public bool Equals(FavoriteStories other)
```

#### Parameters

`other` [FavoriteStories](./literoticaapi/authclientdata/dataobjects/favoritestories.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public FavoriteStories <Clone>$()
```

#### Returns

[FavoriteStories](./literoticaapi/authclientdata/dataobjects/favoritestories.md)<br>

### **Deconstruct(List&, Works&)**

```csharp
public void Deconstruct(List& List, Works& Works)
```

#### Parameters

`List` [List&](./literoticaapi/authclientdata/dataobjects/list&.md)<br>

`Works` [Works&](./literoticaapi/authclientdata/dataobjects/works&.md)<br>
