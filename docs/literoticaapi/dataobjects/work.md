# Work

Namespace: LiteroticaApi.DataObjects

```csharp
public class Work : System.IEquatable`1[[LiteroticaApi.DataObjects.Work, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Work](./literoticaapi/dataobjects/work.md)<br>
Implements [IEquatable&lt;Work&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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

### **Url**

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **Work(Nullable&lt;Int32&gt;, String)**

```csharp
public Work(Nullable<int> Id, string Url)
```

#### Parameters

`Id` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Work(Work)**

```csharp
protected Work(Work original)
```

#### Parameters

`original` [Work](./literoticaapi/dataobjects/work.md)<br>

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

### **Equals(Work)**

```csharp
public bool Equals(Work other)
```

#### Parameters

`other` [Work](./literoticaapi/dataobjects/work.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Work <Clone>$()
```

#### Returns

[Work](./literoticaapi/dataobjects/work.md)<br>

### **Deconstruct(Nullable`1&, String&)**

```csharp
public void Deconstruct(Nullable`1& Id, String& Url)
```

#### Parameters

`Id` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Url` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
