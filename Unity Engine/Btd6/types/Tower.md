# Tower

## `.AddDiscountZoneBuffs()`

type: `List<BuffQuery>`

## `.AddMutator()`

```cs
tower.AddMutator(BehaviorMutator mutator, [Optional] int time, bool updateDuration = true, bool applyMutation = true, bool onlyTimeoutWhenActive = false, bool useRoundTime = true, bool cascadeMutators = false, bool includeSubTowers = false);
tower.AddMutator(BehaviorMutator mutator, int time, bool updateDuration, bool applyMutation, bool onlyTimeoutWhenActive , bool useRoundTime, bool cascadeMutators, bool includeSubTowers);
```

## `.AddMutatorFromParent()`

```cs
tower.AddMutatorFromParent(BehaviorMutator mutator, [Optional] int time, bool updateDuration = true, bool applyMutation = true, bool onlyTimeoutWhenActive = false, bool useRoundTime = true);
tower.AddMutatorFromParent(BehaviorMutator mutator, int time, bool updateDuration, bool applyMutation, bool onlyTimeoutWhenActive, bool useRoundTime);
```

## `.AddMutatorIncludeSubTowers()`

```cs
tower.AddMutatorIncludeSubTowers(BehaviorMutator mutator, [Optional] int time, bool updateDuration = true, bool applyMutation = true, bool onlyTimeoutWhenActive = false, bool useRoundTime = true);
tower.AddMutatorIncludeSubTowers(BehaviorMutator mutator, int time, bool updateDuration, bool applyMutationz, bool onlyTimeoutWhenActive, bool useRoundTime);

```

## `.AddPoppedCash()`

```cs
tower.AddPoppedCash(float cash);
```

## `.add_onUpgraded()`

```cs
tower.add_onUpgraded(Tower.OnUpgradedDelegate value);
```

## `.add_onUpgradedWithTower()`

```cs
tower.add_onUpgradedWithTower(Tower.OnUpgradedWithTowerDelegate value);
```

## `.ApplyTargetTypeData()`

```cs
tower.ApplyTargetTypeData(TargetType type, Il2CppSystem.Object data);
```

## `.Attatched()`

```cs
tower.Attatched();
```

## `.CanTargetCamo()`

```cs
bool canTargetCamo = tower.CanTargetCamo();
```

## `.CheckIfModelBehaviorExists()`

```cs
bool ifModelBehaviorExists = tower.CheckIfModelBehaviorExists();
```

## `.FilterMutation()`

```cs
bool var = tower.FilterMutation(BehaviorMutator mutator, ICollection<BehaviorMutatorFilter> filters);
```

## `.FindDiscountZones()`

```cs
List<DiscountZone> = tower.FindDiscountZones(int path);
```

## `.GetAppliedCash()`

type: `float`

## `.GetSaveData()`

type: `TowerSaveDataModel`

## `.GetTotalSaleTransforms()`

type: `float`

## `.GetUpgrade()`

```cs
UpgradeModel model = tower.getUpgrade(int path);
```

## `.Hilight()`

```cs
tower.Hilight();
```

## `.Intialise()`

```cs
tower.Intialise(Entity target, Model modelToUse);
```

## `.IsSelectable()`

type: `boolean`

## `.IsUpgradeBlocked()`

```cs
bool isUpgradeBlocked = tower.IsUpgradeBlocked(int path, int tier, out string reason);
```

## `.LateSetSaveData()`

```cs
tower.LateSetSaveData(TowerSaveDataModel towerData);
```

## `.OnBloonCreate()`

```cs
tower.OnBloonCreate(Bloon bloon);
```

## `.OnBloonDamaged()`

```cs
tower.OnBloonDamaged(Bloon bloon, float effectiveDamage, Projectile projectile);
```

## `.OnBloonEnterTrack()`

```cs
tower.OnBloonEnterTrack(Bloon bloon);
```

## `.OnDestroy()`

```cs
tower.OnDestroy();
```

## `.OnExpire()`

```cs
tower.OnExpire();
```

## `.OnLivesLost()`

```cs
tower.OnLivesLost(bool fromLeak);
```

## `.OnPlace()`

```cs
tower.OnPlace(bool playPlacementEffects);
```

## `.OnPreLivesLost()`

```cs
tower.OnPreLivesLost(bool fromLeak);
```

## `.OnRoundComplete()`

```cs
tower.OnRoundComplete(int roundArrayIndex);
```

## `.OnRoundStart()`

```cs
tower.OnRoundStart(int roundNo);
```

## `.OnSold()`

```cs
tower.OnSold(float amount);
```

## `.OnTsmThemeAction()`

```cs
tower.OnTsmThemeAction(string themeId, string buttonId, TSMInfoModel info);
```

## `.OnUpgrade()`

```cs
tower.OnUpgrade();
```

## `.OnUpgraded()`

```cs
tower.OnUpgraded();
```

## `.PerformCustomUIAction()`

```cs
tower.PerformCustomUIAction();
```

## `.PositionTower()`

```cs
tower.PositionTower(Vector2 newPosition, bool updateThrowCache);
```

## `.RemoveMutatorIncludeSubTowers()`

```cs
tower.RemoveMutatorIncludeSubTowers(BehaviorMutator mutator);
```

## `.RemoveMutatorsIncludeSubTowersById()`

```cs
tower.RemoveMutatorsIncludeSubTowersById(string id);
```

## `.remove_onUpgraded()`

```cs
tower.remove_onUpgraded(Tower.OnUpgradedDelegate value);
```

## `.remove_onUpgradedWithTower()`

```cs
tower.remove_onUpgradedWithTower(Tower.OnUpgradedWithTowerDelegate value);
```

## `.RotateAroundPivot()`

```cs
tower.RotateAroundPivot(Vector2 pivotPoint, float rotation, bool updateThrowCache);
```

## `.RotateTower()`

```cs
tower.RotateTower(float rotation, bool updateThrowCache);
```

## `.SetGlobalScale()`

```cs
tower.SetGlobalScale();
```

## `.SetNextTargetType()`

```cs
tower.SetNextTargetType(bool prev);
```

## `.SetOnTheMoveTargetting()`

```cs
tower.SetOnTheMoveTargetting(bool val);
```

## `.SetSaveData()`

```cs
tower.SetSaveData(TowerSaveDataModel towerData);
```

## `.SetSelectionBlocked()`

```cs
tower.SetSelectionBlocked(bool value);
```

## `.SetTargetType()`

```cs
tower.SetTargetType(TargetType type);
```

## `.TransformXp()`

```cs
tower.TransformXp(float xp);
```

## `.UnHighlight()`

```cs
tower.UnHighlight();
```

## `.UpdateBuffs()`

```cs
tower.UpdateBuffs();
```

## `.UpdatedModel()`

```cs
tower.UpdatedModel(Model modelToUse);
```

## `.UpdateTargetType()`

```cs
tower.UpdateTargetType();
```

## `.UpdateThrowCache()`

```cs
tower.UpdateThrowCache();
```

## `.UpdateThrowLocation()`

```cs
tower.UpdateThrowLocation();
```