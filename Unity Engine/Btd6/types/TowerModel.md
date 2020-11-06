# `TowerModel`

you can get a complete list of TowerModels using 
```cs
var TowerModels = InGame.instance.bridge.Model.bloons;
foreach (var towermodel in TowerModels)
    // code here
}
```

## `.animationSpeed`

type: `float`

## `.appliedUpgrades`

type: `Il2CppStringArray`

## `.areaTypes`

type: `Il2CppStructArray<AreaType>`

## `.baseId`

type: `string`

## `.behaviors`

type: `Il2CppStructArray<Model>`

## `.cachedThrowMarkerHeight`

type: `float`

## `.cost`

type: `float`

## `.display`

type: `string`

## `.doesntRotate`

type: `boolean`

## `.dontDisplayUpgrades`

type: `boolean`

## `.emoteSpriteLarge`

type: `SpriteReference`

## `.emoteSpriteSmall`

type: `SpriteReference`

## `.footprint`

type: `FootprintModel`

## `.icon`

type: `SpriteReference`

## `.ignoreBlockers`

type: `boolean`

## `.ignoreCoopAreas`

type: `boolean`

## `.ignoreTowerForSelection`

type: `boolean`

## `.Il2CppType`

type: `Type`

## `.instaIcon`

type: `SpriteReference`

## `.isBakable`

type: `boolean`

## `.IsBaseTower`

type: `boolean`

## `.isGlobalRange`

type: `boolean`

## `.isPowerTower`

type: `boolean`

## `.isSubTower`

type: `boolean`

## `.mods`

type: `Il2CppReferenceArray<ApplyModModel>`

## `.portrait`

type: `SpriteReference`

## `.powerName`

type: `string`

## `.radius`

type: `float`

## `.radiusSquared`

type: `float`

## `.range`

type: `float`

## `.showPowerTowerBuffs`

type: `boolean`

## `.targetTypes`

type: `Il2CppReferenceArray<TargetType>`

## `.TargetTypes`

type: `Il2CppReferenceArray<TargetType>`

## `.tier`

type: `int`

## `.tiers`

type: `Il2CppStructArray<int>`

## `.towerSelectionMenuThemeId`

type: `string`

## `.towerSet`

type: `string`

## `.towerSize`

type: `TowerModel.TowerSize`

## `.upgrades`

type: `Il2CppReferenceArray<UpgradePathModel>`



source code:
```cs
public unsafe TowerModel(
    string name = "Monkey", 
    string baseId = "Monkey", 
    string towerSet = "Primary", 
    string display = "Towers/Dart", 
    [Optional] float cost, 
    [Optional] float radius, 
    [Optional] float range, 
    bool ignoreBlockers = false, 
    bool isGlobalRange = false, 
    [Optional] int tier, 
    [Optional] Il2CppStructArray<int> tiers, 
    [Optional] Il2CppStringArray appliedUpgrades, 
    [Optional] Il2CppReferenceArray<UpgradePathModel> upgrades, 
    [Optional] Il2CppReferenceArray<Model> behaviors, 
    [Optional] Il2CppStructArray<AreaType> areaTypes, 
    [Optional] SpriteReference icon, 
    [Optional] SpriteReference portrait, 
    [Optional] SpriteReference instaIcon, 
    [Optional] Il2CppReferenceArray<ApplyModModel> mods, 
    bool ignoreTowerForSelection = false, 
    bool isSubTower = false, 
    bool isBakable = false, 
    [Optional] FootprintModel footprint, 
    bool dontDisplayUpgrades = false, 
    [Optional] string powerName, 
    [Optional] float animationSpeed, 
    [Optional] SpriteReference emoteSpriteSmall, 
    [Optional] SpriteReference emoteSpriteLarge, 
    bool doesntRotate = false, 
    bool showPowerTowerBuffs = false, 
    string towerSelectionMenuThemeId = "Default", 
    bool ignoreCoopAreas = false
    ) : 
    this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TowerModel>.NativeClassPtr)){}
```