# JsonUtils

## `.GetDefaultPath()`

```cs
string defaultPath = JsonUtils.GetDefaultPath();
```

## `.Load()`

```cs
bool createFileIfNotExist = true;
string path = null;

T t = JsonUtils.Load(string path, bool createFileIfNotExist, params JsonConverter[] jsonConverters);

T t = JsonUtils.Load(T jsonObject, string path, bool createFileIfNotExist, params JsonConverter[] jsonConverters);
```

## `.Save()`

```cs
string path = null;
JsonUtils.Save(T jsonObject, string path = null, params JsonConverter[] jsonConverters);
```