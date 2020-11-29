# Utils

## `.GetCallingMod()`

type: `Assembly`

## `.GetCallingModInfo()`

type: `MelonInfoAttribute`

## `.getInGame()`

type: `InGame`

## `.GetMod()`

```cs
Utils.GetMod(int index);
```

## `.GetModInfo()`

```cs
MelonInfoAttribute melonInfoAttribute = Utils.GetModInfo(int index);
MelonInfoAttribute melonInfoAttribute = Utils.GetModInfo(string filePath);
MelonInfoAttribute melonInfoAttribute = Utils.GetModInfo(Assembly modAssembly);
```


## `.IsValidMelonMod()`

```cs
bool isValidMelonMod = Utils.IsValidMelonMod(int index);
bool isValidMelonMod = Utils.IsValidMelonMod(string filePath);
bool isValidMelonMod = Utils.IsValidMelonMod(Assembly modAssembly);
```