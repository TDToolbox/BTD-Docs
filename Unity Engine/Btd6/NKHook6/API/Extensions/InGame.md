# Game extension methods

```cs
using NKHook6.Api.Extensions;
using Assets.Scripts.Unity.UI_New.InGame;
```

# `Ingame.instance`

## `.getCash()`

```cs
Ingame.instance.getCash();
```

Returns the player's Cash, or returns 0 if something is null that is needed for this function.

```cs
var cash = Ingame.instance.getCash();
```

type: `double`

## `.addCash()`

```cs
Ingame.instance.addCash(999);
Ingame.instance.addCash(double addAmount);
```

Adds the player's Cash by a given double value, assuming that the InGame instance isnt null.

type: `double`

## `.setCash()`

```cs
Ingame.instance.setCash(999);
Ingame.instance.setCash(double newAmount);
```

Sets the player's Cash to a given double value, assuming that the InGame instance isnt null.

type: `double`

## `.getHealth()`

Returns the player's Health, or returns 0 if something is null that is needed for this function.

```cs
var health = Ingame.instance.getHealth();
```

type: `double`

## `.addHealth()`

```cs
Ingame.instance.addHealth(999);
Ingame.instance.addHealth(double addAmount);
```

Adds the player's Health by a given double value, assuming that the InGame instance isnt null.

type: `double`

## `.setHealth()`

```cs
Ingame.instance.setHealth(999);
Ingame.instance.setHealth(double newAmount);
```

Sets the player's Health to a given double value, assuming that the InGame instance isnt null.

## `.getBloons()`

Get all the bloons present

```cs
Il2CppSystem.Collections.Generic.List<BloonToSimulation> bloons = InGame.instance.getBloons();
```
type: `List<BloonToSimulation>`

