# EditorDatum

Namespace: LiteroticaApi.AuthClientData.DataObjects

Represents an editor's capabilities, assigned languages, and related user information.

```csharp
public class EditorDatum : System.IEquatable`1[[LiteroticaApi.AuthClientData.DataObjects.EditorDatum, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [EditorDatum](./literoticaapi/authclientdata/dataobjects/editordatum.md)<br>
Implements [IEquatable&lt;EditorDatum&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **Uid**

```csharp
public Nullable<int> Uid { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CanPasted**

```csharp
public Nullable<int> CanPasted { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CanTxt**

```csharp
public Nullable<int> CanTxt { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CanRtf**

```csharp
public Nullable<int> CanRtf { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CanDoc**

```csharp
public Nullable<int> CanDoc { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Created**

```csharp
public Nullable<int> Created { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Updated**

```csharp
public Nullable<int> Updated { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rating**

```csharp
public Nullable<int> Rating { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **StoriesEditted**

```csharp
public Nullable<int> StoriesEditted { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Categories**

```csharp
public IReadOnlyList<Nullable<int>> Categories { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **Languages**

```csharp
public IReadOnlyList<Nullable<int>> Languages { get; set; }
```

#### Property Value

[IReadOnlyList&lt;Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

### **Description**

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **OtherLanguages**

```csharp
public object OtherLanguages { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **User**

```csharp
public User User { get; set; }
```

#### Property Value

[User](./literoticaapi/authclientdata/dataobjects/user.md)<br>

## Constructors

### **EditorDatum(Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, Nullable&lt;Int32&gt;, IReadOnlyList&lt;Nullable&lt;Int32&gt;&gt;, IReadOnlyList&lt;Nullable&lt;Int32&gt;&gt;, String, Object, User)**

Represents an editor's capabilities, assigned languages, and related user information.

```csharp
public EditorDatum(Nullable<int> Uid, Nullable<int> CanPasted, Nullable<int> CanTxt, Nullable<int> CanRtf, Nullable<int> CanDoc, Nullable<int> Created, Nullable<int> Updated, Nullable<int> Rating, Nullable<int> StoriesEditted, IReadOnlyList<Nullable<int>> Categories, IReadOnlyList<Nullable<int>> Languages, string Description, object OtherLanguages, User User)
```

#### Parameters

`Uid` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CanPasted` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CanTxt` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CanRtf` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`CanDoc` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Created` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Updated` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Rating` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`StoriesEditted` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`Categories` [IReadOnlyList&lt;Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

`Languages` [IReadOnlyList&lt;Nullable&lt;Int32&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>

`Description` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`OtherLanguages` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

`User` [User](./literoticaapi/authclientdata/dataobjects/user.md)<br>

### **EditorDatum(EditorDatum)**

```csharp
protected EditorDatum(EditorDatum original)
```

#### Parameters

`original` [EditorDatum](./literoticaapi/authclientdata/dataobjects/editordatum.md)<br>

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

### **Equals(EditorDatum)**

```csharp
public bool Equals(EditorDatum other)
```

#### Parameters

`other` [EditorDatum](./literoticaapi/authclientdata/dataobjects/editordatum.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public EditorDatum <Clone>$()
```

#### Returns

[EditorDatum](./literoticaapi/authclientdata/dataobjects/editordatum.md)<br>

### **Deconstruct(Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, Nullable`1&, IReadOnlyList`1&, IReadOnlyList`1&, String&, Object&, User&)**

```csharp
public void Deconstruct(Nullable`1& Uid, Nullable`1& CanPasted, Nullable`1& CanTxt, Nullable`1& CanRtf, Nullable`1& CanDoc, Nullable`1& Created, Nullable`1& Updated, Nullable`1& Rating, Nullable`1& StoriesEditted, IReadOnlyList`1& Categories, IReadOnlyList`1& Languages, String& Description, Object& OtherLanguages, User& User)
```

#### Parameters

`Uid` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CanPasted` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CanTxt` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CanRtf` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`CanDoc` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Created` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Updated` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Rating` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`StoriesEditted` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`Categories` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`Languages` [IReadOnlyList`1&](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1&)<br>

`Description` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`OtherLanguages` [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)<br>

`User` [User&](./literoticaapi/authclientdata/dataobjects/user&.md)<br>
