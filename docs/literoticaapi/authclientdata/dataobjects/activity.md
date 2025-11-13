# Activity

Namespace: LiteroticaApi.AuthClientData.DataObjects

Represents a user's activity feed, including a list of recent activity data
 and the count of new unseen activities.

```csharp
public class Activity : System.IEquatable`1[[LiteroticaApi.AuthClientData.DataObjects.Activity, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Activity](./literoticaapi/authclientdata/dataobjects/activity.md)<br>
Implements [IEquatable&lt;Activity&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Data**

```csharp
public IReadOnlyList<ActivityData> Data { get; set; }
```

#### Property Value

[IReadOnlyList&lt;ActivityData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **NewActivityCount**

```csharp
public Nullable<int> NewActivityCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **Activity(IReadOnlyList&lt;ActivityData&gt;, Nullable&lt;Int32&gt;)**

Represents a user's activity feed, including a list of recent activity data
 and the count of new unseen activities.

```csharp
public Activity(IReadOnlyList<ActivityData> Data, Nullable<int> NewActivityCount)
```

#### Parameters

`Data` [IReadOnlyList&lt;ActivityData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

`NewActivityCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Activity(Activity)**

```csharp
protected Activity(Activity original)
```

#### Parameters

`original` [Activity](./literoticaapi/authclientdata/dataobjects/activity.md)<br>

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

### **Equals(Activity)**

```csharp
public bool Equals(Activity other)
```

#### Parameters

`other` [Activity](./literoticaapi/authclientdata/dataobjects/activity.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public Activity <Clone>$()
```

#### Returns

[Activity](./literoticaapi/authclientdata/dataobjects/activity.md)<br>

### **Deconstruct(IReadOnlyList`1&, Nullable`1&)**

```csharp
public void Deconstruct(IReadOnlyList`1& Data, Nullable`1& NewActivityCount)
```

#### Parameters

`Data` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`NewActivityCount` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
