# AOB
This is a list of all the functions and related things, complete with the AOB (Array of Byte) scans, signatures, as well as the last version they were verified. If there is an outdated one, either make a pull request changing it to out of date or wrong or just let us know.


### IncrementUpgradeLevel
```
Signature: void __thiscall IncrementUpgradeLevel(CBaseTower* this, int path)
AOB: ?? ?? ?? ?? ?? ?? 51 53 56 57 8B 7D 08 8B F1 8D 04
Last checked: 3.24.1 (21202)
Status: Unconfirmed
```
### UpgradeTower
```
Signature: void __thiscall UpgradeTower(CTowerManager *this,CBaseTower *tower,int path,bool UNKNOWN)
AOB: ?? ?? ?? ?? ?? ?? 83 EC 44 53 8B 5D 08 8B
Last checked: 3.24.1 (21202)
Status: Unconfirmed
```
### Keypressed
```
Signature: void __thiscall Keypressed(WinInput* this, uint key)
AOB: 55 8B EC 53 57 8B 7D 08 8B D9 81 FF 00 01 00 00 73 3A
Last checked: 3.24.1 (21202)
Status: Unconfirmed
```
### UpdateSpriteGraphic
```
Signature: void __thiscall UpdateSpriteGraphic(CTowerFactory *this, CBaseTower *tower, STowerInfo* towerInfo)
AOB: 55 8b ec 6a ff 68 D4 ?? ?? ?? 64 A1 00 00 00 00 50 83 EC 6C A1 34 B0 52
Last checked: 3.25 (21202)
Status: Unconfirmed
```
### CalculateUpgradePrice
```
Signature: int __thiscall CalculateUpgradePrice(CGameRules* this, CBaseTower* tower, float Multiplier?)
AOB: 55 8b ec 51 8b 45 08 f3 0f 10 0d
Last checked: 3.24.1 (21202)
Status: Unconfirmed
```
### SetSprite
```
Signature: void __thiscall SetSprite(CBaseTower* tower, CCompoundSprite* sprite)
AOB: 55 8B EC 83 EC 10 56 8B C2 8B F1 89 45 F0 89 75 F4 3B F0 74
Last checked: 3.24.1 (21202)
Status: Unconfirmed
```
### UpdateHover
```
Signature: void __thiscall UpdateHover(CTowerManager *this,undefined4 param_1,int param_2)
AOB: 55 8B EC 83 E4 F0 83 EC 28 8B 45
Last checked: 3.24.1 (21202)
Status: Unconfirmed
```
### CTowerFactory
```
Signature: void __thiscall CTowerFactory(CTowerFactory *this,undefined4 param_1,undefined **param_2)
AOB: 55 8b ec 6a ff 68 6f 8a
Last checked: 3.24.1 (21202)
Status: Unconfirmed
```
### CWeaponFactory
```
Signature: void __thiscall CWeaponFactory?(CWeaponFactory *this,undefined4 param_1,undefined **param_2)
AOB: 55 8b ec 6a ff 68 b4 3d
Last checked: 3.24.1 (21202)
Status: Unconfirmed
```
### FlagToString
```
Signature: char* __thiscall FlagToString(CFlagStringConvertor* this, char* stringBuffer, uint param_2, uint typeHalfA, uint typeHalfB)
AOB: ?? ?? ?? ?? ?? ?? 56 57 ff 75 0c c7 45 FC 00 00 00 00 E8 E9
Last checked: 3.24.1
Status: Unconfirmed
```
### _GLOBAL__sub_I_InGameDebug.cpp
```
Signature: void _GLOBAL__sub_I_InGameDebug.cpp(void)
AOB: 55 8b ec 6a ff 68 4e c8
Last checked: 3.24.1
Status: Unconfirmed
```
### _GLOBAL__sub_I_FrontendDebug.cpp
```
Signature: void _GLOBAL__sub_I_FrontendDebug.cpp(void)
AOB: 55 8b ec 6a ff 68 4a 9d
Last checked: 3.24.1
Status: Unconfirmed
```
### GetTowerInfo
```
Signature: void * __thiscall GetTowerInfo(CTowerFactory *this, uint towerType, uint towerType)
AOB: 55 8B EC 6A FF 68 ?8 1? ?? ?? ?? A1 00 00 00 00 50 83 EC 24 A1 34 B0 ?? 01 33 C5 89 45 F0 56 50 8D 45 F4 64 A3 00 00 00 00 8B F1 8B
Last checked: 3.24.1
Status: Unconfirmed
```
### GetTowerUnlocked
```
Signature: bool __thiscall GetTowerUnlocked(CPlayerProfileV1* this,void *towerInfo)
AOB: 55 8B EC 83 EC 08 8B C1 8B 4D 08 56
Last checked: 3.24.1
Status: Unconfirmed
```
### StringToFlag
```
Signature: ulonglong __thiscall StringToFlag(CFlagStringConvertor *this,int **param_1,int **param_2)
AOB: ?? ?? ?? ?? ?? 0c 53 56 57 ff 75 08 e8 1f
Last checked: 3.24.1
Status: Unconfirmed
```
### CGameSelectPopup::Init
```
Signature: void __fastcall Init(IScreenData* IScreenData)
AOB: 55 8b ec 6a ff 68 8f b5
Last checked: 3.24.1
Status: Unconfirmed
```
### CPauseScreen::Init
```
Signature: void __fastcall Init(IScreenData* IScreenData)
AOB: 55 8b ec 6a ff 68 e6 d5
Last checked: 3.24.1
Status: Unconfirmed
```
### ValidateState
```
Signature: bool __thiscall ValidateState(CFlagStringConvertor *this,void *param_1)
AOB: 55 8b ec 6a ff 68 59 0d
Last checked: 3.24.1
Status: Unconfirmed
```
### DownloadMissingDLC
```
Signature: void __thiscall DownloadMissingDLC(CApp *this)
AOB: 68 07 01 00 00 68 7c
Last checked: 3.24.1
Status: Unconfirmed
```
### SetLanguage
```
Signature: bool __thiscall SetLanguage(CLoc* this, char* param_1)
AOB: ?? ?? ?? ?? ?? ?? 83 ec 08 56 8b 75 08 57 83 ec
Last checked: 3.24.1
Status: Unconfirmed
```
### CNewsBuilding
```
Signature: void __thiscall CNewsBuilding(int *piParm1,undefined4 param_1,undefined4 param_2,undefined4 param_3, undefined4 param_4,int param_5)
AOB: 55 8b ec 6a ff 68 cc 80
Last checked: 3.24.1
Status: Unconfirmed
```
### GetTowerUnderMouse
```
Signature: CBaseTower * __thiscall GetTowerUnderMouse(CTowerManager *this,float mouseX,float mouseY,int param_3,int param_4)
AOB: 55 8b ec 83 e4 f8 83 ec 0c f3
Last checked: 3.24.1
Status: Unconfirmed
```
### EndFrame
```
Signature: void __thiscall EndFrame(WinRenderLayer* this)
AOB: e8 ?b 4? 04 00 e8 ?6
Last checked: 3.25 (21423)
Status: Unconfirmed
```