# BookList

Namespace: LiteroticaApi.DataObjects

```csharp
public class BookList : System.IEquatable`1[[LiteroticaApi.DataObjects.BookList, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BookList](./literoticaapi/dataobjects/booklist.md)<br>
Implements [IEquatable&lt;BookList&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public string CreatedAt { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UpdatedAt**

```csharp
public Nullable<DateTime> UpdatedAt { get; set; }
```

#### Property Value

[Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **BookList(Nullable&lt;Int32&gt;, String, Nullable&lt;Int32&gt;, String, String, String, Nullable&lt;Int32&gt;, String, Nullable&lt;DateTime&gt;)**

```csharp
public BookList(Nullable<int> Id, string Description, Nullable<int> StoriesCount, string SubmissionType, string Title, string Urlname, Nullable<int> UserId, string CreatedAt, Nullable<DateTime> UpdatedAt)
```

#### Parameters

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Description` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`StoriesCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`SubmissionType` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Urlname` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`UserId` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CreatedAt` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`UpdatedAt` [Nullable&lt;DateTime&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BookList(BookList)**

```csharp
protected BookList(BookList original)
```

#### Parameters

`original` [BookList](./literoticaapi/dataobjects/booklist.md)<br>

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

### **Equals(BookList)**

```csharp
public bool Equals(BookList other)
```

#### Parameters

`other` [BookList](./literoticaapi/dataobjects/booklist.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public BookList <Clone>$()
```

#### Returns

[BookList](./literoticaapi/dataobjects/booklist.md)<br>

### **Deconstruct(Nullable`1&, String&, Nullable`1&, String&, String&, String&, Nullable`1&, String&, Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& Id, String& Description, Nullable`1& StoriesCount, String& SubmissionType, String& Title, String& Urlname, Nullable`1& UserId, String& CreatedAt, Nullable`1& UpdatedAt)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Description` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`StoriesCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`SubmissionType` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Title` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Urlname` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`UserId` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CreatedAt` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`UpdatedAt` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
