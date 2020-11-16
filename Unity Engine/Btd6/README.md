# Bloons Tower Defense 6
These wiki pages are all about modding BTD6! This page is focused on making BTD6 mods with NKHook6 and MelonLoader

BTD6 was made by NinjaKiwi. Unlike BTD5-era games which were made in C++ using NK's [solidarity game engine](https://github.com/TDToolbox/BTD-Docs/tree/master/BTD5%20Engine), BTD6 is made in C# using Unity Engine. This means that the methods of modding the newer games are radically different from previous methods of modding and required modders to think outside of the box to accomplish very small changes to the game. While it was a difficult challange we've managed to overcome it.

## Quick Access
- If you want to make mods for BTD6 using our API NKHook6, go [here](NKHook6) **(recommended)**
- If you want to use MelonLoader to make your mods, go [here](https://github.com/TDToolbox/BTD-Docs/tree/master/Unity%20Engine/MelonLoader)

## Currently there are 4 main ways to mod BTD6
From easiest to hardest, they are:

1. MelonLoader/NKHook6
2. BTD6api
3. GameAssembly.dll modding
4. Assembly modding


### BTD6 Modding History
In the beginning the only methods of modding were Assembly modding and GameAssembly.dll modding. These are unsustainable and very crude methods of modding and as such only skilled programmers could use them. Additionally, it took much effort to make *very* basic mods. Fast forward a year and a half and [Bowdown](https://github.com/BowDown097/BTD6API) and [Danny Parker](https://github.com/DannyParker0001) worked together to make BTD6api. 

BTD6api is coded in C++ and uses IL2CPPdumper to get access to the games files. This new method of modding allows us much more access to BTD6's code and allows for much more advanced mods. While it is much greater than previous methods of modding it's still not the best. Modding with BTD6api is difficult because it's coded in C++ and therefore requires you to be decently skilled at computer programming. Additionally in it's current state it is very taxing on your computer, taking up most of your pc's resources to develop and test your mods. This won't remain true forever though as it's still in it's infancy stage so it will likely see significant improvement in the future. This wiki will be updated to reflect those changes

## The future of BTD6 modding
The most significant advancement in BTD6/BATTD was the discovery of MelonLoader, a matured universal mod loader for Unity games coded in C#. When using MelonLoader mod making is *extremely easy* and allows us to make unbelievable mods that we never thought could be possible. In it's current state it requires you to know C# programming, but it has a much gentler learning curve than other BTD modding methods. It takes virtually no time at all to compile mods made this way. Not only that but it is not nearly as resource intensive as other modding methods. Put all of this together and you have a method for modding BTD6/BATTD that is fairly easy to learn, quick to make, and gentle on your computer. The best part is the TD Toolbox team that made BTD Toolbox and other modding tools have come together to make a new, cleaner, and easier to use api. We call it **NKHook6**.

#### NKHook6:
NKHook6 comes with a lot of the necessary tools and features you'll need to use in your mods. Here are some examples:
- A lightweight python-like scripting language called Boo, which allows you to make mods even easier than you can already
- Update notifications so your users can be notified if your mods have an update available
- Simplistic settings manager that allows your mods to have configurable settings both in game and out of game
- Built-in event system for hooking the game's code easier and quicker with less work. Inspired by Bukkit's event system with Minecraft
- A logging system that looks nice and can send messages to user in multiple ways, including in game.

## How to get started
Before you can get started making mods for BTD6 you need to decide how you want to make them. It is recommended that you use NKHook6 or MelonLoader as it is the best method currently available. Alternatively you can check out some of the other methods for BTD6 modding included in our BTD Docs repo

### What would you like to do?
- If you want to make mods for BTD6 using our API NKHook6, go [here](https://github.com/TDToolbox/BTD-Docs/tree/master/NK-Unity%20Engine/Btd6/NKHook6) **(recommended)**
- If you want to use MelonLoader to make your mods, go [here](https://github.com/TDToolbox/BTD-Docs/tree/master/NK-Unity%20Engine/MelonLoader)


#### Contact us
If you want to contact us about BTD6 modding you can join our [NKHook6](https://discord.gg/VADMF2M) discord server. Alternatively you can join our [TD Toolbox](https://discord.gg/jj5Q7mA) discord server which is the hub for all of our BTD Modding projects
