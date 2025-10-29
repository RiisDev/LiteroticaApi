# TagsApi

Namespace: LiteroticaApi.Api

Provides asynchronous methods for retrieving tags-related data from the Literotica API.

```csharp
public static class TagsApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TagsApi](./literoticaapi/api/tagsapi.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Methods

### **GetRelatedTagsAsync(Int32[], Period, Int32)**

Retrieves a list of tags that are related to the specified tag IDs.

```csharp
public static Task<List<RelatedTag>> GetRelatedTagsAsync(Int32[] tagIds, Period period, int language)
```

#### Parameters

`tagIds` [Int32[]](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
An array of tag IDs for which to retrieve related tags.

`period` [Period](./literoticaapi/types/period.md)<br>
The time period to filter by, defined in . 
 Defaults to .

`language` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The language identifier (typically `1` for English). 
 Defaults to `1`.

#### Returns

[Task&lt;List&lt;RelatedTag&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a list of [RelatedTag](./literoticaapi/dataobjects/relatedtag.md) objects
 that are related to the specified tags.

### **GetTopTagsAsync(Categories, Int32, Boolean, Period, Int32)**

Retrieves the most popular (top) tags within a specified category.

```csharp
public static Task<TopTags> GetTopTagsAsync(Categories category, int limit, bool periodCheck, Period period, int language)
```

#### Parameters

`category` [Categories](./literoticaapi/types/categories.md)<br>
The category to filter results by, defined in .

`limit` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The maximum number of tags to retrieve. 
 Defaults to `500`.

`periodCheck` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
A value indicating whether the tag ranking should be period-sensitive. 
 Defaults to `true`.

`period` [Period](./literoticaapi/types/period.md)<br>
The time period to evaluate, defined in . 
 Defaults to .

`language` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The language identifier (typically `1` for English). 
 Defaults to `1`.

#### Returns

[Task&lt;TopTags&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a [TopTags](./literoticaapi/dataobjects/toptags.md) object with metadata about the most popular tags.

### **GetTagIdFromNameAsync(String[])**

Retrieves tag metadata based on an array of tag names.

```csharp
public static Task<List<Tag>> GetTagIdFromNameAsync(String[] tags)
```

#### Parameters

`tags` [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
An array of tag names for which to retrieve tag ID and metadata.

#### Returns

[Task&lt;List&lt;Tag&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a list of [Tag](./literoticaapi/dataobjects/tag.md) objects corresponding to the specified tag names.

### **GetCategoriesAsync(Period)**

Retrieves all available story categories for the specified time period.

```csharp
public static Task<List<CategoryReturn>> GetCategoriesAsync(Period period)
```

#### Parameters

`period` [Period](./literoticaapi/types/period.md)<br>
The time period to filter by, defined in .

#### Returns

[Task&lt;List&lt;CategoryReturn&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A task representing the asynchronous operation. 
 The task result contains a list of [CategoryReturn](./literoticaapi/dataobjects/categoryreturn.md) objects representing story categories.
