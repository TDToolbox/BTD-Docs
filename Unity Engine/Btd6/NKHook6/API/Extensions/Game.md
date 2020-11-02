# Game extension methods

```cs
using NKHook6.Api.Extensions;
using Assets.Scripts.Unity;
```

# `Game.instance`

## `.getMonkeyMoney()`

```cs
var monkeyMoney = Game.instance.getMonkeyMoney();
```

Returns the player's Monkey Money

type: `double`

## `.setMonkeyMoney()`

```cs
Game.instance.setMonkeyMoney(1234567);
Game.instance.setMonkeyMoney(double monkeyMoney);
```

type: `double`

## `.getBloonModel()`

```cs
BloonModel = Game.instance.getBloonModel(string bloonName);
```
type: `BloonModel`

## `.getAllBloonModels();`

```cs
var allBloonTypes = Game.instance.getAllBloonModels();
```

type: `array`

## `.getTowerModel()`

```cs
towernModel = Game.instance.getTowerModel(string towerName);
```

type: `TowerModel`

## `.getAllTowerModels();`

```cs
var allTowers = Game.instance.getAllTowerModels();
```

type: `array`

## `.getUpgradeModel()`

```cs
upgradeModel = Game.instance.getUpgradeModel(string upgradeName);
```
type: `UpgradeModel`

