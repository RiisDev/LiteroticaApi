# RecentComment

Namespace: LiteroticaApi.DataObjects

Represents a recent comment made on a work, typically used in global or author-wide comment feeds.

```csharp
public class RecentComment : System.IEquatable`1[[LiteroticaApi.DataObjects.RecentComment, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RecentComment](./literoticaapi/dataobjects/recentcomment.md)<br>
Implements [IEquatable&lt;RecentComment&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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

### **Date**

```csharp
public Nullable<int> Date { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rate**

```csharp
public Nullable<int> Rate { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Type**

```csharp
public Nullable<int> Type { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Story**

```csharp
public Story Story { get; set; }
```

#### Property Value

[Story](./literoticaapi/dataobjects/story.md)<br>

### **Text**

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Author**

```csharp
public Author Author { get; set; }
```

#### Property Value

[Author](./literoticaapi/dataobjects/author.md)<br>

## Constructors

### **RecentComment(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Story, String, String, Author)**

Represents a recent comment made on a work, typically used in global or author-wide comment feeds.

```csharp
public RecentComment(Nullable<int> Id, Nullable<int> Date, Nullable<int> Rate, Nullable<int> Type, Story Story, string Text, string Title, Author Author)
```

#### Parameters

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Date` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Rate` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Type` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Story` [Story](./literoticaapi/dataobjects/story.md)<br>

`Text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Author` [Author](./literoticaapi/dataobjects/author.md)<br>

### **RecentComment(RecentComment)**

```csharp
protected RecentComment(RecentComment original)
```

#### Parameters

`original` [RecentComment](./literoticaapi/dataobjects/recentcomment.md)<br>

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

### **Equals(RecentComment)**

```csharp
public bool Equals(RecentComment other)
```

#### Parameters

`other` [RecentComment](./literoticaapi/dataobjects/recentcomment.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public RecentComment <Clone>$()
```

#### Returns

[RecentComment](./literoticaapi/dataobjects/recentcomment.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Story&, String&, String&, Author&)**

```csharp
public void Deconstruct(Nullable`1& Id, Nullable`1& Date, Nullable`1& Rate, Nullable`1& Type, Story& Story, String& Text, String& Title, Author& Author)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Date` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Rate` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Type` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Story` [Story&](./literoticaapi/dataobjects/story&.md)<br>

`Text` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Title` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Author` [Author&](./literoticaapi/dataobjects/author&.md)<br>
