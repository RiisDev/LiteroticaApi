# Activity

Namespace: LiteroticaApi.AuthClientData

Provides access to various user activity endpoints, allowing retrieval of global, local, and author-related activities.

```csharp
public class Activity
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Activity](./literoticaapi/authclientdata/activity.md)<br>
Attributes [NullableContextAttribute](./system/runtime/compilerservices/nullablecontextattribute.md), [NullableAttribute](./system/runtime/compilerservices/nullableattribute.md)

## Constructors

### **Activity(AuthClient)**

Provides access to various user activity endpoints, allowing retrieval of global, local, and author-related activities.

```csharp
public Activity(AuthClient client)
```

#### Parameters

`client` [AuthClient](./literoticaapi/authclientdata/authclient.md)<br>
The authenticated [AuthClient](./literoticaapi/authclientdata/authclient.md) instance used to make API requests.

## Methods

### **GetAllActivityAsync(Int32)**

Retrieves all available activity events for the authenticated user.

```csharp
public Task<Activity> GetAllActivityAsync(int limit)
```

#### Parameters

`limit` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The maximum number of activity records to retrieve.

#### Returns

[Task&lt;Activity&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A [Activity](./literoticaapi/authclientdata/dataobjects/activity.md) object containing a list of activity events;

### **GetLocalActivityAsync(Int32)**

Retrieves the authenticated user's local activity (such as submissions, comments, and favorites).

```csharp
public Task<Activity> GetLocalActivityAsync(int limit)
```

#### Parameters

`limit` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The maximum number of activity records to retrieve.

#### Returns

[Task&lt;Activity&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A [Activity](./literoticaapi/authclientdata/dataobjects/activity.md) object containing local user activity data;

### **GetFollowedAuthorsActivityAsync(Int32)**

Retrieves activity from authors that the authenticated user follows.

```csharp
public Task<Activity> GetFollowedAuthorsActivityAsync(int limit)
```

#### Parameters

`limit` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The maximum number of followed author activity records to retrieve.

#### Returns

[Task&lt;Activity&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)<br>
A [Activity](./literoticaapi/authclientdata/dataobjects/activity.md) object containing activity data from followed authors;
