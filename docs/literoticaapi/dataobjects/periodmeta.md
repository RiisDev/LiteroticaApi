# PeriodMeta

Namespace: LiteroticaApi.DataObjects

```csharp
public class PeriodMeta : System.IEquatable`1[[LiteroticaApi.DataObjects.PeriodMeta, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PeriodMeta](./literoticaapi/dataobjects/periodmeta.md)<br>
Implements [IEquatable&lt;PeriodMeta&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **PeriodChecks**

```csharp
public PeriodChecks PeriodChecks { get; set; }
```

#### Property Value

[PeriodChecks](./literoticaapi/dataobjects/periodchecks.md)<br>

## Constructors

### **PeriodMeta(PeriodChecks)**

```csharp
public PeriodMeta(PeriodChecks PeriodChecks)
```

#### Parameters

`PeriodChecks` [PeriodChecks](./literoticaapi/dataobjects/periodchecks.md)<br>

### **PeriodMeta(PeriodMeta)**

```csharp
protected PeriodMeta(PeriodMeta original)
```

#### Parameters

`original` [PeriodMeta](./literoticaapi/dataobjects/periodmeta.md)<br>

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

### **Equals(PeriodMeta)**

```csharp
public bool Equals(PeriodMeta other)
```

#### Parameters

`other` [PeriodMeta](./literoticaapi/dataobjects/periodmeta.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public PeriodMeta <Clone>$()
```

#### Returns

[PeriodMeta](./literoticaapi/dataobjects/periodmeta.md)<br>

### **Deconstruct(PeriodChecks&)**

```csharp
public void Deconstruct(PeriodChecks& PeriodChecks)
```

#### Parameters

`PeriodChecks` [PeriodChecks&](./literoticaapi/dataobjects/periodchecks&.md)<br>
