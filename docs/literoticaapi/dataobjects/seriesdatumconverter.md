# SeriesDatumConverter

Namespace: LiteroticaApi.DataObjects

Custom JSON converter for handling [SeriesDatum](./literoticaapi/dataobjects/seriesdatum.md) objects that may appear
 as either valid JSON objects, nulls, or unexpected arrays in the API response.

```csharp
public class SeriesDatumConverter : System.Text.Json.Serialization.JsonConverter`1[[LiteroticaApi.DataObjects.SeriesDatum, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → JsonConverter → JsonConverter&lt;SeriesDatum&gt; → [SeriesDatumConverter](./literoticaapi/dataobjects/seriesdatumconverter.md)<br>
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

### **SeriesDatumConverter()**

```csharp
public SeriesDatumConverter()
```

## Methods

### **Read(Utf8JsonReader&, Type, JsonSerializerOptions)**

Reads and deserializes a [SeriesDatum](./literoticaapi/dataobjects/seriesdatum.md) instance from the JSON input.
 Handles inconsistent API responses where the property may be null, an array, or an object.

```csharp
public SeriesDatum Read(Utf8JsonReader& reader, Type typeToConvert, JsonSerializerOptions options)
```

#### Parameters

`reader` Utf8JsonReader&<br>
The JSON reader.

`typeToConvert` [Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>
The target type.

`options` JsonSerializerOptions<br>
Serializer options.

#### Returns

[SeriesDatum](./literoticaapi/dataobjects/seriesdatum.md)<br>
A deserialized [SeriesDatum](./literoticaapi/dataobjects/seriesdatum.md) instance or `null` if invalid.

#### Exceptions

T:System.Text.Json.JsonException<br>
Thrown when the JSON format is unexpected or invalid.

### **Write(Utf8JsonWriter, SeriesDatum, JsonSerializerOptions)**

Writes the [SeriesDatum](./literoticaapi/dataobjects/seriesdatum.md) instance to JSON.

```csharp
public void Write(Utf8JsonWriter writer, SeriesDatum value, JsonSerializerOptions options)
```

#### Parameters

`writer` Utf8JsonWriter<br>
The JSON writer.

`value` [SeriesDatum](./literoticaapi/dataobjects/seriesdatum.md)<br>
The [SeriesDatum](./literoticaapi/dataobjects/seriesdatum.md) instance to serialize.

`options` JsonSerializerOptions<br>
Serializer options.
