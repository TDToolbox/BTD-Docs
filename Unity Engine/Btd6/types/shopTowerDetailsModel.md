# ShopTowerDetailsModel

```cs
ShopTowerDetailsModel newTowerDetails = new ShopTowerDetailsModel("DartlingGun", -1, 5, 5, 5, -1, null);
ShopTowerDetailsModel newTowerDetails = new ShopTowerDetailsModel("towerName", int towerIndex, int pathOneMax, int pathTwoMax, int pathThreeMax, int towerCount, Il2CppReferenceArray<ApplyModModel> mods);

```

## `.getMaxPath()`

```cs
maxPath = shopTowerDetailsModel.getMaxPath(1);
maxPath = shopTowerDetailsModel.getMaxPath(int path);
```

## Usage

normally used to add towers into the tower list, [here is an example](https://pastebin.com/yY1Jx2ax)
