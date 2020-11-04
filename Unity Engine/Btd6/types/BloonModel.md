# `BloonModel`

you can get a complete list of BloonModels using 
```cs
var bloonModels = InGame.instance.bridge.Model.bloons;
foreach (var bloonmodel in bloonModels)
    // code here
}
```

## `.baseId` 

gets the base bloon type (for example `LeadRegrowFortifiedCamo` -> `Lead`)
type: `string`

## `.behaviors` 

type: `Il2CppReferenceArray<Model>` 

## `.childBloonModels`

type: `List<BloonModel>`

## `.collisionGroup`

type: `CollisionGroupModel`

## `.damageDisplayStates`

type: `Il2CppReferenceArray<DamageStateModel>` 

## `.damageTypeImmunities`

type: `Il2CppReferenceArray<DamageTypeImunityModel>` 

## `.danger`

type: `float`

## `.depletionEffects`

type: `Il2CppReferenceArray<EffectModel>`

## `.display`

type: `string`

## `.distributeDamageToChildren`

type: `boolean`

## `.hasChildrenWithDifferentTotalHealth`

type: `boolean`

## `.icon`

type: `SpriteReference`

## `.id`

type: `string`

## `.GetIl2CppType()`

type: `Type`

## `.isBase`

type: `boolean`

## `.isCamo`

type: `boolean`

## `.isFortified`

type: `boolean`

## `.isGrow`

type: `boolean`

## `.isInvulnerable`

type: `boolean`

## `.isMoab`

type: `boolean`

## `.layerNumber`

type: `int`

## `.leakDamage`

type: `float`

## `maxHealth`

type: `float`

## `.overlayClass`

type: `string`

## `.radius`

type: `float`

## `.rotate`

type: `bool`

## `.rotateToFollowPath`

type: `bool`

## `.speed`

type: `float`

(note: from some testing this doesnt work)

## `.Speed`

type: `float`

## `.speedFrames`

type: `float`

## `.storedLayers`

type: `float`

## `.storedRbe`

type: `float`

## `.tags`

type: `Il2CppStringArray`

## `.updateChildBloonsModels`

type: `bool`


# Bloon Data

name|danger|layer number
---------------|---|---
Red|1|1
RedRegrow|1|1
RedRegrowCamo|1|1
RedCamo|1|1
Blue|2|2
BlueRegrow|2|2
BlueRegrowCamo|2|2
BlueCamo|2|2
Green|3|3
GreenRegrow|3|3
GreenRegrowCamo|3|3
GreenCamo|3|3
Yellow|4|4
YellowRegrow|4|4
YellowRegrowCamo|4|4
YellowCamo|4|4
Pink|5|5
PinkRegrow|5|5
PinkRegrowCamo|5|5
PinkCamo|5|5
Black|6|6
BlackRegrow|6|6
BlackRegrowCamo|6|6
BlackCamo|6|6
White|6|6
WhiteRegrow|6|6
WhiteRegrowCamo|6|6
WhiteCamo|6|6
Purple|6|6
PurpleRegrow|6|6
PurpleRegrowCamo|6|6
PurpleCamo|6|6
Zebra|7|7
ZebraRegrow|7|7
ZebraRegrowCamo|7|7
ZebraCamo|7|7
Lead|7|7
LeadRegrow|7|7
LeadRegrowFortified|7|7
LeadRegrowFortifiedCamo|7|7
LeadRegrowCamo|7|7
LeadFortified|7.5|7
LeadFortifiedCamo|7.5|7
LeadCamo|7|7
Rainbow|8|8
RainbowRegrow|8|8
RainbowRegrowCamo|8|8
RainbowCamo|8|8
Ceramic|9|9
CeramicRegrow|9|9
CeramicRegrowFortified|9|9
CeramicRegrowFortifiedCamo|9|9
CeramicRegrowCamo|9|9
CeramicFortified|9.5|9
CeramicFortifiedCamo|9.5|9
CeramicCamo|9|9
Moab|10|10
MoabFortified|10.5|10
Bfb|11|11
BfbFortified|11.5|11
Zomg|13|12
ZomgFortified|13.5|12
Ddt|12|12
DdtFortified|14|12
DdtFortifiedCamo|14|12
DdtCamo|12|12
Bad|15|13
BadFortified|15.5|13
TestBloon|0|0