# Bloons Tower Defense 6
These wiki pages are all about modding BTD6!

BTD6 was made by NinjaKiwi. Unlike BTD5-era games which were made in C++ using NK's [solidarity game engine](https://github.com/TDToolbox/BTD-Docs/tree/master/BTD5%20Engine), BTD6 was made in C# using Unity Engine. This means that the methods of modding the newer games are radically different from previous methods of modding and required modders to think outside of the box to accomplish very small changes to the game. 


## Currently there are 4 main ways to mod BTD6
From easiest to hardest, they are:

1. MelonLoader/NKHook6
2. BTD6api
3. GameAssembly.dll modding
4. Assembly modding


### BTD6 Modding History
In the beginning the only methods of modding were Assembly modding and GameAssembly.dll modding. These are unsustainable and very crude methods of modding and as such only skilled programmers could use them. Additionally, it took much effor to make *very* basic mods. Fast forward a year and a half and [Bowdown](https://github.com/BowDown097/BTD6API) and [Danny Parker](https://github.com/DannyParker0001) worked together to make BTD6api. 

BTD6api is coded in C++ and uses IL2CPPdumper to get access to the games files. This new method of modding allows us much more access to BTD6's code and allows for much more advanced mods. While it is much greater than previous methods of modding it is no where near the best. Modding with BTD6api is difficult as it requires you to be a skilled C++ programmer. Additionally, in it's current state it is unreasonably resource intensive and can take several minutes to compile your mod *each time* you try to compile it. It's still in it's infancy stage so it will likely see significant improvement in the future. 

## The future of BTD6 modding
The most significant advancement in BTD6/BATTD was the discovery of MelonLoader, a matured universal mod loader for Unity games coded in C#. When using MelonLoader mod making is *extremely easy* and allows us to make unbelievable mods that we never thought could be possible. In it's current state it requires you to know C# programming, but it has a much gentler learning curve than other BTD modding methods. It takes virtually no time at all to compile mods made this way. Not only that but it is not nearly as resource intensive as other modding methods. Put all of this together and you have a method for modding BTD6/BATTD that is fairly easy to learn, quick to make, and gentle on your computer. The best part is the TD Toolbox team that made BTD Toolbox and other modding tools have come together to make a new, cleaner, and easier to use api. We call it **NKHook6**.

NKHook6 comes with a lot of the necessary tools and features you'll need to use in your mods. Here are some examples:
• A lightweight scripting language called Boo, which allows you to make mods even easier than you can already
• Update notifications so your users can be notified if your mods have an update available
• Simplistic settings manager that allows your mods to have configurable settings both in game and out of game
• A built-in event system for hooking the game's code easier and quicker with less work. Similar to Bukkit's event system with Minecraft




## MelonLoader/NKHook6
MelonLoader is a universal mod manager for Unity games. 
