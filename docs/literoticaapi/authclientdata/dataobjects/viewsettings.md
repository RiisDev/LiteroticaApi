# ViewSettings

Namespace: LiteroticaApi.AuthClientData.DataObjects

Represents user-specific content viewing preferences such as font, spacing, and playback rate.

```csharp
public class ViewSettings : System.IEquatable`1[[LiteroticaApi.AuthClientData.DataObjects.ViewSettings, LiteroticaApi, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ViewSettings](./literoticaapi/authclientdata/dataobjects/viewsettings.md)<br>
Implements [IEquatable&lt;ViewSettings&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Properties

### **EqualityContract**

```csharp
protected Type EqualityContract { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

### **FontName**

```csharp
public string FontName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FontSpacing**

```csharp
public string FontSpacing { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FontSize**

```csharp
public string FontSize { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UserTheme**

```csharp
public string UserTheme { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Autodetect**

```csharp
public Nullable<bool> Autodetect { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PlaybackRate**

```csharp
public Nullable<int> PlaybackRate { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **ViewSettings(String, String, String, String, Nullable&lt;Boolean&gt;, Nullable&lt;Int32&gt;)**

Represents user-specific content viewing preferences such as font, spacing, and playback rate.

```csharp
public ViewSettings(string FontName, string FontSpacing, string FontSize, string UserTheme, Nullable<bool> Autodetect, Nullable<int> PlaybackRate)
```

#### Parameters

`FontName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`FontSpacing` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`FontSize` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`UserTheme` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`Autodetect` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`PlaybackRate` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ViewSettings(ViewSettings)**

```csharp
protected ViewSettings(ViewSettings original)
```

#### Parameters

`original` [ViewSettings](./literoticaapi/authclientdata/dataobjects/viewsettings.md)<br>

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

### **Equals(ViewSettings)**

```csharp
public bool Equals(ViewSettings other)
```

#### Parameters

`other` [ViewSettings](./literoticaapi/authclientdata/dataobjects/viewsettings.md)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **&lt;Clone&gt;$()**

```csharp
public ViewSettings <Clone>$()
```

#### Returns

[ViewSettings](./literoticaapi/authclientdata/dataobjects/viewsettings.md)<br>

### **Deconstruct(String&, String&, String&, String&, Nullable`1&, Nullable`1&)**

```csharp
public void Deconstruct(String& FontName, String& FontSpacing, String& FontSize, String& UserTheme, Nullable`1& Autodetect, Nullable`1& PlaybackRate)
```

#### Parameters

`FontName` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`FontSpacing` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`FontSize` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`UserTheme` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

`Autodetect` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>

`PlaybackRate` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
