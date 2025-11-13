# WhatConverter

Namespace: LiteroticaApi.AuthClientData.DataObjects

Handles JSON deserialization for [What](./literoticaapi/authclientdata/dataobjects/what.md) objects that can contain
 either an array (biography) or an object (story).

```csharp
public class WhatConverter : System.Text.Json.Serialization.JsonConverter`1[[LiteroticaApi.AuthClientData.DataObjects.What, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → JsonConverter → JsonConverter&lt;What&gt; → [WhatConverter](./literoticaapi/authclientdata/dataobjects/whatconverter.md)<br>
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

### **WhatConverter()**

```csharp
public WhatConverter()
```

## Methods

### **Read(Utf8JsonReader&, Type, JsonSerializerOptions)**

Reads and converts JSON data into a [What](./literoticaapi/authclientdata/dataobjects/what.md) object.
 Determines if the data represents a biography or a story based on its structure.

```csharp
public What Read(Utf8JsonReader& reader, Type typeToConvert, JsonSerializerOptions options)
```

#### Parameters

`reader` Utf8JsonReader&<br>
The JSON reader instance.

`typeToConvert` [Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>
The target type to convert to.

`options` JsonSerializerOptions<br>
Serializer options.

#### Returns

[What](./literoticaapi/authclientdata/dataobjects/what.md)<br>
A deserialized [What](./literoticaapi/authclientdata/dataobjects/what.md) object, or null if parsing fails.

### **Write(Utf8JsonWriter, What, JsonSerializerOptions)**

Writes a [What](./literoticaapi/authclientdata/dataobjects/what.md) object as JSON, handling both biography and story formats.

```csharp
public void Write(Utf8JsonWriter writer, What value, JsonSerializerOptions options)
```

#### Parameters

`writer` Utf8JsonWriter<br>
The JSON writer instance.

`value` [What](./literoticaapi/authclientdata/dataobjects/what.md)<br>
The [What](./literoticaapi/authclientdata/dataobjects/what.md) value to write.

`options` JsonSerializerOptions<br>
Serializer options.
