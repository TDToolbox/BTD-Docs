# ReflectionUtils

```cs
BindingFlags bindingFlags = BindingFlags.Default;
```

## `.CopyFields()`

```cs
ReflectionUtils.CopyFields(this T original, T copy, BindingFlags bindingFlags); //where T : class
```

## `.GetInstanceField()`

```cs
ReflectionUtils.GetInstanceField(this T instance, string fieldName, BindingFlags bindingFlags);
```

## `.GetInstanceMethod()`

```cs
MethodInfo methodInfo = ReflectionUtils.GetInstanceMethod(this T instance, string methodName, BindingFlags bindingFlags);

MethodInfo methodInfo = ReflectionUtils.GetInstanceMethod(string methodName, BindingFlags bindingFlags);
```

## `.GetStaticField()`

```cs
var StaticField = ReflectionUtils.GetStaticField(string fieldName, BindingFlags bindingFlags);

var StaticField = ReflectionUtils.GetStaticField(this T instance, string fieldName, BindingFlags bindingFlags);

```

## `.GetStaticMethod()`

```cs
MethodInfo methodInfo = ReflectionUtils.GetStaticMethod(string methodName, BindingFlags bindingFlag);

MethodInfo methodInfo = ReflectionUtils.GetStaticMethod(this T instance, string methodName, BindingFlags bindingFlags);
```

## `.SetInstanceField()`

```cs
ReflectionUtils.SetInstanceField(this T instance, string fieldName, object value, BindingFlags bindingFlags);
```

## `.SetStaticField()`

```cs
ReflectionUtils.SetStaticField(string fieldName, object value, BindingFlags bindingFlags);

ReflectionUtils.SetStaticField(this T instance, string fieldName, object value, BindingFlags bindingFlags);
```