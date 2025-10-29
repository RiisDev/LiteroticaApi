# PeriodChecks

Namespace: LiteroticaApi.DataObjects

```csharp
public class PeriodChecks : System.IEquatable`1[[LiteroticaApi.DataObjects.PeriodChecks, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PeriodChecks](./literoticaapi/dataobjects/periodchecks.md)<br>
Implements [IEquatable&lt;PeriodChecks&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Month**

```csharp
public Nullable<int> Month { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Week**

```csharp
public Nullable<int> Week { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Today**

```csharp
public Nullable<int> Today { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Allperiod**

```csharp
public Nullable<int> Allperiod { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **PeriodChecks(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;)**

```csharp
public PeriodChecks(Nullable<int> Month, Nullable<int> Week, Nullable<int> Today, Nullable<int> Allperiod)
```

#### Parameters

`Month` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Week` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Today` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Allperiod` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PeriodChecks(PeriodChecks)**

```csharp
protected PeriodChecks(PeriodChecks original)
```

#### Parameters

`original` [PeriodChecks](./literoticaapi/dataobjects/periodchecks.md)<br>

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

### **Equals(PeriodChecks)**

```csharp
public bool Equals(PeriodChecks other)
```

#### Parameters

`other` [PeriodChecks](./literoticaapi/dataobjects/periodchecks.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public PeriodChecks <Clone>$()
```

#### Returns

[PeriodChecks](./literoticaapi/dataobjects/periodchecks.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&)**

```csharp
public void Deconstruct(Nullable`1& Month, Nullable`1& Week, Nullable`1& Today, Nullable`1& Allperiod)
```

#### Parameters

`Month` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Week` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Today` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Allperiod` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
