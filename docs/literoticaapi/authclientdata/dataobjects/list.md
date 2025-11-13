# List

Namespace: LiteroticaApi.AuthClientData.DataObjects

Represents a user's custom reading list with metadata such as title, description, and privacy settings.

```csharp
public class List : System.IEquatable`1[[LiteroticaApi.AuthClientData.DataObjects.List, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [List](./literoticaapi/authclientdata/dataobjects/list.md)<br>
Implements [IEquatable&lt;List&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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

### **Description**

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **StoriesCount**

```csharp
public Nullable<int> StoriesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SubmissionType**

```csharp
public string SubmissionType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Urlname**

```csharp
public string Urlname { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UserId**

```csharp
public Nullable<int> UserId { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CreatedAt**

```csharp
public object CreatedAt { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **UpdatedAt**

```csharp
public Nullable<DateTime> UpdatedAt { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsPrivate**

```csharp
public Nullable<int> IsPrivate { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **IsDeletable**

```csharp
public Nullable<int> IsDeletable { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **List(Nullable&lt;Int32&gt;, String, Nullable&lt;Int32&gt;, String, String, String, Nullable&lt;Int32&gt;, Object, Nullable&lt;DateTime&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

Represents a user's custom reading list with metadata such as title, description, and privacy settings.

```csharp
public List(Nullable<int> Id, string Description, Nullable<int> StoriesCount, string SubmissionType, string Title, string Urlname, Nullable<int> UserId, object CreatedAt, Nullable<DateTime> UpdatedAt, Nullable<int> IsPrivate, Nullable<int> IsDeletable)
```

#### Parameters

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Description` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`StoriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`SubmissionType` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Urlname` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`UserId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CreatedAt` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`UpdatedAt` [Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`IsPrivate` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`IsDeletable` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **List(List)**

```csharp
protected List(List original)
```

#### Parameters

`original` [List](./literoticaapi/authclientdata/dataobjects/list.md)<br>

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

### **Equals(List)**

```csharp
public bool Equals(List other)
```

#### Parameters

`other` [List](./literoticaapi/authclientdata/dataobjects/list.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public List <Clone>$()
```

#### Returns

[List](./literoticaapi/authclientdata/dataobjects/list.md)<br>

### **Deconstruct(Nullable`1&, String&, Nullable`1&, String&, String&, String&, Nullable`1&, Object&, Nullable`1&, Nullable`1&, Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& Id, String& Description, Nullable`1& StoriesCount, String& SubmissionType, String& Title, String& Urlname, Nullable`1& UserId, Object& CreatedAt, Nullable`1& UpdatedAt, Nullable`1& IsPrivate, Nullable`1& IsDeletable)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Description` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`StoriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`SubmissionType` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Title` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Urlname` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`UserId` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CreatedAt` [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)<br>

`UpdatedAt` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`IsPrivate` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`IsDeletable` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
