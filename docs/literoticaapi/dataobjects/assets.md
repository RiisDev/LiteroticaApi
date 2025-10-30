# Assets

Namespace: LiteroticaApi.DataObjects

Represents all available media assets (e.g., cover images) for both mobile and desktop displays.

```csharp
public class Assets : System.IEquatable`1[[LiteroticaApi.DataObjects.Assets, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Assets](./literoticaapi/dataobjects/assets.md)<br>
Implements [IEquatable&lt;Assets&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Mobile**

```csharp
public Mobile Mobile { get; set; }
```

#### Property Value

[Mobile](./literoticaapi/dataobjects/mobile.md)<br>

### **Desktop**

```csharp
public Desktop Desktop { get; set; }
```

#### Property Value

[Desktop](./literoticaapi/dataobjects/desktop.md)<br>

## Constructors

### **Assets(Mobile, Desktop)**

Represents all available media assets (e.g., cover images) for both mobile and desktop displays.

```csharp
public Assets(Mobile Mobile, Desktop Desktop)
```

#### Parameters

`Mobile` [Mobile](./literoticaapi/dataobjects/mobile.md)<br>

`Desktop` [Desktop](./literoticaapi/dataobjects/desktop.md)<br>

### **Assets(Assets)**

```csharp
protected Assets(Assets original)
```

#### Parameters

`original` [Assets](./literoticaapi/dataobjects/assets.md)<br>

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

### **Equals(Assets)**

```csharp
public bool Equals(Assets other)
```

#### Parameters

`other` [Assets](./literoticaapi/dataobjects/assets.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Assets <Clone>$()
```

#### Returns

[Assets](./literoticaapi/dataobjects/assets.md)<br>

### **Deconstruct(Mobile&, Desktop&)**

```csharp
public void Deconstruct(Mobile& Mobile, Desktop& Desktop)
```

#### Parameters

`Mobile` [Mobile&](./literoticaapi/dataobjects/mobile&.md)<br>

`Desktop` [Desktop&](./literoticaapi/dataobjects/desktop&.md)<br>
