# StoryInfo

Namespace: LiteroticaApi.DataObjects

Represents the root object for detailed story information including metadata and submission content.

```csharp
public class StoryInfo : System.IEquatable`1[[LiteroticaApi.DataObjects.StoryInfo, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [StoryInfo](./literoticaapi/dataobjects/storyinfo.md)<br>
Implements [IEquatable&lt;StoryInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Meta**

```csharp
public Meta Meta { get; set; }
```

#### Property Value

[Meta](./literoticaapi/dataobjects/meta.md)<br>

### **Submission**

```csharp
public Submission Submission { get; set; }
```

#### Property Value

[Submission](./literoticaapi/dataobjects/submission.md)<br>

### **PageText**

```csharp
public string PageText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **StoryInfo(Meta, Submission, String)**

Represents the root object for detailed story information including metadata and submission content.

```csharp
public StoryInfo(Meta Meta, Submission Submission, string PageText)
```

#### Parameters

`Meta` [Meta](./literoticaapi/dataobjects/meta.md)<br>

`Submission` [Submission](./literoticaapi/dataobjects/submission.md)<br>

`PageText` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **StoryInfo(StoryInfo)**

```csharp
protected StoryInfo(StoryInfo original)
```

#### Parameters

`original` [StoryInfo](./literoticaapi/dataobjects/storyinfo.md)<br>

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

### **Equals(StoryInfo)**

```csharp
public bool Equals(StoryInfo other)
```

#### Parameters

`other` [StoryInfo](./literoticaapi/dataobjects/storyinfo.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public StoryInfo <Clone>$()
```

#### Returns

[StoryInfo](./literoticaapi/dataobjects/storyinfo.md)<br>

### **Deconstruct(Meta&, Submission&, String&)**

```csharp
public void Deconstruct(Meta& Meta, Submission& Submission, String& PageText)
```

#### Parameters

`Meta` [Meta&](./literoticaapi/dataobjects/meta&.md)<br>

`Submission` [Submission&](./literoticaapi/dataobjects/submission&.md)<br>

`PageText` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
