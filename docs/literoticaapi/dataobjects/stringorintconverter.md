# StringOrIntConverter

Namespace: LiteroticaApi.DataObjects

Custom JSON converter to handle string-or-integer conversions during serialization and deserialization.

```csharp
public class StringOrIntConverter : System.Text.Json.Serialization.JsonConverter`1[[LiteroticaApi.DataObjects.StringOrInt, LiteroticaApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → JsonConverter → JsonConverter&lt;StringOrInt&gt; → [StringOrIntConverter](./literoticaapi/dataobjects/stringorintconverter.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **HandleNull**

```csharp
public bool HandleNull { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Type**

```csharp
public Type Type { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

## Constructors

### **StringOrIntConverter()**

```csharp
public StringOrIntConverter()
```

## Methods

### **Read(Utf8JsonReader&, Type, JsonSerializerOptions)**

```csharp
public StringOrInt Read(Utf8JsonReader& reader, Type typeToConvert, JsonSerializerOptions options)
```

#### Parameters

`reader` Utf8JsonReader&<br>

`typeToConvert` [Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

`options` JsonSerializerOptions<br>

#### Returns

[StringOrInt](./literoticaapi/dataobjects/stringorint.md)<br>

### **Write(Utf8JsonWriter, StringOrInt, JsonSerializerOptions)**

```csharp
public void Write(Utf8JsonWriter writer, StringOrInt value, JsonSerializerOptions options)
```

#### Parameters

`writer` Utf8JsonWriter<br>

`value` [StringOrInt](./literoticaapi/dataobjects/stringorint.md)<br>

`options` JsonSerializerOptions<br>
