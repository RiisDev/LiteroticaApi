# ActivityData

Namespace: LiteroticaApi.AuthClientData.DataObjects

Represents an individual activity event, such as a story post, biography update,
 or user interaction on the platform.

```csharp
public class ActivityData : System.IEquatable`1[[LiteroticaApi.AuthClientData.DataObjects.ActivityData, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ActivityData](./literoticaapi/authclientdata/dataobjects/activitydata.md)<br>
Implements [IEquatable&lt;ActivityData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public string Id { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Action**

```csharp
public string Action { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **When**

```csharp
public Nullable<int> When { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Who**

```csharp
public Who Who { get; set; }
```

#### Property Value

[Who](./literoticaapi/authclientdata/dataobjects/who.md)<br>

### **What**

```csharp
public What What { get; set; }
```

#### Property Value

[What](./literoticaapi/authclientdata/dataobjects/what.md)<br>

### **Sequence**

```csharp
public Nullable<int> Sequence { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Whom**

```csharp
public Who Whom { get; set; }
```

#### Property Value

[Who](./literoticaapi/authclientdata/dataobjects/who.md)<br>

## Constructors

### **ActivityData(String, String, Nullable&lt;Int32&gt;, Who, What, Nullable&lt;Int32&gt;, Who)**

Represents an individual activity event, such as a story post, biography update,
 or user interaction on the platform.

```csharp
public ActivityData(string Id, string Action, Nullable<int> When, Who Who, What What, Nullable<int> Sequence, Who Whom)
```

#### Parameters

`Id` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Action` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`When` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Who` [Who](./literoticaapi/authclientdata/dataobjects/who.md)<br>

`What` [What](./literoticaapi/authclientdata/dataobjects/what.md)<br>

`Sequence` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Whom` [Who](./literoticaapi/authclientdata/dataobjects/who.md)<br>

### **ActivityData(ActivityData)**

```csharp
protected ActivityData(ActivityData original)
```

#### Parameters

`original` [ActivityData](./literoticaapi/authclientdata/dataobjects/activitydata.md)<br>

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

### **Equals(ActivityData)**

```csharp
public bool Equals(ActivityData other)
```

#### Parameters

`other` [ActivityData](./literoticaapi/authclientdata/dataobjects/activitydata.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public ActivityData <Clone>$()
```

#### Returns

[ActivityData](./literoticaapi/authclientdata/dataobjects/activitydata.md)<br>

### **Deconstruct(String&, String&, Nullable`1&, Who&, What&, Nullable`1&, Who&)**

```csharp
public void Deconstruct(String& Id, String& Action, Nullable`1& When, Who& Who, What& What, Nullable`1& Sequence, Who& Whom)
```

#### Parameters

`Id` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Action` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`When` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Who` [Who&](./literoticaapi/authclientdata/dataobjects/who&.md)<br>

`What` [What&](./literoticaapi/authclientdata/dataobjects/what&.md)<br>

`Sequence` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Whom` [Who&](./literoticaapi/authclientdata/dataobjects/who&.md)<br>
