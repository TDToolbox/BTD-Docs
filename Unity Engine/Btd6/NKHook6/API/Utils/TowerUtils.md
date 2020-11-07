# TowerUtils

## `.AddToTowerSelection()`

```cs
TowerUtils.AddToTowerSelection(ShopTowerDetailsModel details, TowerType insertBefore);
TowerUtils.AddToTowerSelection(ShopTowerDetailsModel details, string insertBefore);
TowerUtils.AddToTowerSelection(ShopTowerDetailsModel details, int index);
TowerUtils.AddToTowerSelection(ShopTowerDetailsModel details, TowerType insertBefore, List<TowerDetailsModel> allTowersInTheGame);
TowerUtils.AddToTowerSelection(ShopTowerDetailsModel details, string insertBefore, List<TowerDetailsModel> allTowersInTheGame);
TowerUtils.AddToTowerSelection(ShopTowerDetailsModel details, int index, List<TowerDetailsModel> allTowersInTheGame);
```

## `.GetTower()`

```cs
TowerUtils.GetTower(TowerType baseId, [Optional] int tier1, [Optional] int tier2, [Optional] int tier3);
TowerUtils.GetTower(string baseId, [Optional] int tier1, [Optional] int tier2, [Optional] int tier3);
```

## `.AllTowersInTheGame`

type: `List<TowerDetailsModel>`

## `.TowerInventory`

type: `TowerInventory`

## `.TowersOnMap`

type: `List<tower>`