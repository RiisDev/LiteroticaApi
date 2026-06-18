# EpubSeries

Namespace: EpubManager.ContentSources

Represents metadata about a story series, including its title and volume number.

```csharp
public class EpubSeries : System.IEquatable`1[[EpubManager.ContentSources.EpubSeries, LiteroticaApi, Version=2.1.1.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [EpubSeries](./epubmanager/contentsources/epubseries.md)<br>
Implements [IEquatable&lt;EpubSeries&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Title**

The title of the series.

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Volume**

The volume number of the story within the series.

```csharp
public int Volume { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **EpubSeries(String, Int32)**

Represents metadata about a story series, including its title and volume number.

```csharp
public EpubSeries(string Title, int Volume)
```

#### Parameters

`Title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The title of the series.

`Volume` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The volume number of the story within the series.

### **EpubSeries(EpubSeries)**

```csharp
protected EpubSeries(EpubSeries original)
```

#### Parameters

`original` [EpubSeries](./epubmanager/contentsources/epubseries.md)<br>

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

### **Equals(EpubSeries)**

```csharp
public bool Equals(EpubSeries other)
```

#### Parameters

`other` [EpubSeries](./epubmanager/contentsources/epubseries.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public EpubSeries <Clone>$()
```

#### Returns

[EpubSeries](./epubmanager/contentsources/epubseries.md)<br>

### **Deconstruct(String&, Int32&)**

```csharp
public void Deconstruct(String& Title, Int32& Volume)
```

#### Parameters

`Title` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Volume` [Int32&](https://docs.microsoft.com/en-us/dotnet/api/system.int32&)<br>
