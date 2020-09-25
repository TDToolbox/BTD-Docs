# Structure of NK Unity Games

## Table of contents

- [Structure of NK Unity Games](#structure-of-nk-unity-games)
  - [Table of contents](#table-of-contents)
  - [FAQ](#faq)
  - [What is Mono & IL2CPP?](#what-is-mono--il2cpp)
  - [Folder Structure - IL2CPP Backend](#folder-structure---il2cpp-backend)
    - [General file structure](#general-file-structure)
    - [(Example) BTD6's file structure](#example-btd6s-file-structure)
  - [Folder Structure - Mono backend](#folder-structure---mono-backend)
    - [General Structure](#general-structure)
    - [(Example) Tower Keepers file structure](#example-tower-keepers-file-structure)

## FAQ

Q: What does Native mean?  
A: Native for this articles purpose just means *not C#*. C# Is hosted in the [CLR](https://en.wikipedia.org/wiki/Common_Language_Runtime) which is a virtual machine, whilst C++ runs directly on your CPU. This makes C# hosted and C++ Native.  

## What is Mono & IL2CPP?

When compiling any unity project, there are two backends that you can choose from, Mono and IL2CPP.  
Mono is the default. [Mono](https://www.mono-project.com/) is an [open source](https://github.com/mono/mono) project that implements C# for MacOS, Linux and more. At the time of Unity's creation, Mono's support for mobile was unstable and poorly performing. Unity came up with a solution to that problem: IL2CPP  
The IL2CPP backend compiler the project in Mono, then using a proprietary tool, it converts the compiled C# into C++ source code. Then using any standard C++ compiler, you compile the C++ and you game is now technically fully made in C++. C++ has much better support for compiling to mobile, so it is used in place of C#.

## Folder Structure - IL2CPP Backend

### General file structure

```tree
[Game Name] (Steam folder)
│   [GameName].exe
│   GameAssembly.dll
│   UnityPlayer.dll
│
└───[Game Name]_Data
    │   globalgamemanagers
    │   globalgamemanagers.assets
    │   resources.assets
    │   resources.assets.resS
    │
    ├───il2cpp_data
    │   └───Metadata
    │           global-metadata.dat
    │
    └───StreamingAssets
        └───full
                [game]_megabundle
                resource_bundle
                sprite_atlases
```

`[GameName.exe]` The game's [executable](../executable.md) is a stub that calls UnityMain() in UnityPlayer.dll with some parameters.  
`UnityPlayer.dll` A native C++ [executable](../executable.md) that contains the internal Unity Engine functions.  
`GameAssembly.dll` Is a [executable](../executable.md) that contains all the converted C# code. This is likely what you would be modding if you want to chance any of the games code.  
  
`[Game Name]_Data/globalgamemanagers` Is useful, not sure what it contains.  
`[Game Name]_Data/resources.assets` I believe this file is useful.  
  
`[Game Name]_Data/il2cpp_data/Metadata/global-metadata.dat`  This file contains all the [metadata](metadata.md) required to achieve [reflection](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/reflection) in C++  

`[Game Name]_Data/StreamingAssets` This folder contains files downloaded at the game launch. It contains many [assets](assets.md) such as textures, models, sounds & more.

### (Example) BTD6's file structure

```tree
BloonsTD6
│   BloonsTD6.exe
│   GameAssembly.dll
│   steam_api64.dll
│   steam_appid.txt
│   UnityCrashHandler64.exe
│   UnityPlayer.dll
│
└───BloonsTD6_Data
    │   boot.config
    │   globalgamemanagers
    │   globalgamemanagers.assets
    │   resources.assets
    │   resources.assets.resS
    │
    ├───il2cpp_data
    │   └───Metadata
    │           global-metadata.dat
    │
    └───StreamingAssets
        └───full
                btd6_megabundle
                resource_bundle
                sprite_atlases
```

## Folder Structure - Mono backend

### General Structure

```tree
[Game Name] (Steam Folder)
│   [Game Name]].exe
│   UnityCrashHandler64.exe
│   UnityPlayer.dll
│
└───[GameName]_Data
    │   globalgamemanagers
    │   globalgamemanagers.assets
    │   resources.assets
    │   resources.assets.resS
    │
    ├───Managed
    │       Assembly-CSharp.dll
    │       mscorlib.dll
    │       Ninjakiwi.LiNK.dll
    │       NK-Unity-Libs.dll
    │       UnityEngine.dll
    |       ... 156 files ommited
    │
    └───StreamingAssets
        │   crashlytics-build.properties
        │
        └───Win
                [GameName]pack
                [GameName]pack.manifest
                Win
                Win.manifest
```

### (Example) Tower Keepers file structure

```tree
Tower Keepers
│   Tower Keepers.exe
│   UnityCrashHandler64.exe
│   UnityPlayer.dll
│
│
└───Tower Keepers_Data
    │   boot.config
    │   globalgamemanagers
    │   globalgamemanagers.assets
    │   resources.assets
    │   resources.assets.resS
    │
    ├───Managed
    │       Assembly-CSharp.dll
    │       mscorlib.dll
    │       Ninjakiwi.LiNK.dll
    │       NK-Unity-Libs.dll
    │       UnityEngine.dll
    |       ... 156 files ommited
    │
    └───StreamingAssets
        │   crashlytics-build.properties
        │
        └───Win
                tkpack
                tkpack.manifest
                Win
                Win.manifest

```
