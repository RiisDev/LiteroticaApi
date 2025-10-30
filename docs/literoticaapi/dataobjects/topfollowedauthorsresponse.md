# TopFollowedAuthorsResponse

Namespace: LiteroticaApi.DataObjects

Represents the response for a top-followed authors request.

```csharp
public class TopFollowedAuthorsResponse : System.IEquatable`1[[LiteroticaApi.DataObjects.TopFollowedAuthorsResponse, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TopFollowedAuthorsResponse](./literoticaapi/dataobjects/topfollowedauthorsresponse.md)<br>
Implements [IEquatable&lt;TopFollowedAuthorsResponse&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Data**

```csharp
public TopFollowedAuthor Data { get; set; }
```

#### Property Value

[TopFollowedAuthor](./literoticaapi/dataobjects/topfollowedauthor.md)<br>

## Constructors

### **TopFollowedAuthorsResponse(TopFollowedAuthor)**

Represents the response for a top-followed authors request.

```csharp
public TopFollowedAuthorsResponse(TopFollowedAuthor Data)
```

#### Parameters

`Data` [TopFollowedAuthor](./literoticaapi/dataobjects/topfollowedauthor.md)<br>

### **TopFollowedAuthorsResponse(TopFollowedAuthorsResponse)**

```csharp
protected TopFollowedAuthorsResponse(TopFollowedAuthorsResponse original)
```

#### Parameters

`original` [TopFollowedAuthorsResponse](./literoticaapi/dataobjects/topfollowedauthorsresponse.md)<br>

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

### **Equals(TopFollowedAuthorsResponse)**

```csharp
public bool Equals(TopFollowedAuthorsResponse other)
```

#### Parameters

`other` [TopFollowedAuthorsResponse](./literoticaapi/dataobjects/topfollowedauthorsresponse.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public TopFollowedAuthorsResponse <Clone>$()
```

#### Returns

[TopFollowedAuthorsResponse](./literoticaapi/dataobjects/topfollowedauthorsresponse.md)<br>

### **Deconstruct(TopFollowedAuthor&)**

```csharp
public void Deconstruct(TopFollowedAuthor& Data)
```

#### Parameters

`Data` [TopFollowedAuthor&](./literoticaapi/dataobjects/topfollowedauthor&.md)<br>
