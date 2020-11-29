# BloonUtils

## `.GetAllBloonTypes()`

```cs
List<string> bloonTypes = BloonUtils.GetAllBloonTypes();
```

## `.GetBloon()`

```cs
BloonModel model = BloonUtils.GetBloon(DefaultBloonIds bloonId, bool ignoreException);

BloonModel model = GetBloon(string bloonId, bool ignoreException)
```

## `.GetBloonIdNum()`

```cs
BloonUtils.GetBloonIdNum(string bloonId);
```

## `.GetNextStrongestBloon()`

```cs
BloonModel nextStrongest = BloonUtils.GetNextStrongestBloon(BloonModel bloon, bool allowCamo, bool allowFortified, bool allowRegrow, bool ignoreException);

BloonModel nextStrongest = GetNextStrongestBloon(DefaultBloonIds bloonId, bool allowCamo, bool allowFortified, bool allowRegrow, bool ignoreException);

BloonModel nextStrongest = GetNextStrongestBloon(string bloonId, bool allowCamo, bool allowFortified, bool allowRegrow, bool ignoreException);
```

## `.GetNextWeakestBloon()`

```cs
BloonModel nextWeakest = BloonUtils.GetNextWeakestBloon(string bloonId, bool allowCamo, bool allowFortified, bool allowRegrow);
```

## `.RemoveBloonStatus()`

```cs
BloonModel statusRemoved = BloonUtils.RemoveBloonStatus(string bloonId, bool removeCamo, bool removeFortified, bool removeRegrow, bool ignoreException)
```

## `.SetBloonStatus()`

```cs
BloonModel newModel = BloonUtils.SetBloonStatus(string bloonId, [Optional] bool setCamo, [Optional] bool setFortified, [Optional] bool setRegrow)
```