# TowerToSimulation

## `.Abilities`

type: `List<AbilityToSimulation>`

## `.activeBuffs`

type: `Il2CppReferenceArray<BuffQuery>`

## `.cashEarned`

type: `long` (64 bit signed integer)

## `.CollectFromBank()`

```cs
towerToSimulation.CollectFromBank();
```

## `.damageDealt`

type: `long` (64 bit signed integer)

## `.Def`

type: `TowerModel`

## `.Destroy()`

```cs
towerToSimulation.Destroy();
```

## `.destroyed`

type: `bool`

## `.GetBankAmount()`

type: `float`

## `.GetBuffsAffectingPlacementTower`

```cs
towerToSimulation.GetBuffsAffectingPlacementTower(TowerModel placementTowerModel, Vector3 placementPosition, out bool towerBuffedThisTower)
```

type: `Il2CppReferenceArray<BuffQuery>`

## `.GetLoanAmount()`

type: `float`

## `.GetSimPosition()`

type: `Vector3`

## `.GetSimTower()`

type: `Tower`

## `.GetTowerBuffsFromSim()`

type: `Il2CppReferenceArray<BuffQuery>`

## `.GetUpgradeCost()`

```cs
towerToSimulation.GetUpgradeCost(int pathIndex, int tier, float overrideBaseCost)
```

type: `float`

## `.HasGlobalRangeBuffBehavior()`

type: `boolean`

## `.hero`

type: `HeroToSimulation`

## `.Id`

type: `int`

## `.id`

type: `int`

## `.Il2CppType`

type: `Type`

## `.IsDestroyed()`

type: `boolean`

## `.IsSelectable()`

type: `boolean`

## `.namedMonkeyKey`

type: `string`

## `.namedMonkeyName`

type: `string`

## `.OnDestroyed()`

type: `Action`

## `.OnSelectionDisabled`

type: `Action`

## `.owner`

type: `int`

## `.PerformCustomUIAction()`

(no clue)

## `.position`

type: `Vector3`

## `.result`

type: `List<AbilityToSimulation>`

## `.SelectableDisabled()`

```cs
towerToSimulation.SelectableDisabled();
```

## `.sellFor`

type: `float`

## `.SetNextTargetType()`

```cs
towerToSimulation.SelectableDisabled(bool prev);
```

## `.sim`

type: `UnityToSimulation`

## `.TargetType`

type: `TargetType`  

## `.tower`

type: `Tower`

## `.Upgrade()`

```cs
towerToSimulation.Upgrade(int pathIndex, Il2CppSystem.Action<bool> callback)
```

## `.worth`

type: `float`