# Learn more about Harmony Patching
Read this page to get a crash course in Harmony!
**Note**: NKHook6 features an *Event System*, which **should be used in favor of Harmony when possible.** It is much simpler to use as well, and does most of the work for you. It is also meant to be **version proof**, to garuntee that your mod would work across updated. You can find out more about it [here](https://github.com/TDToolbox/BTD-Docs/blob/master/Unity%20Engine/Btd6/NKHook6/Events.md)


## Harmony Basics
[Harmony](https://harmony.pardeike.net/index.html) is an amazing tool you can use to "hook" the game's code and have your own code get executed. In simpler terms, harmony creates a link between *your* mod and the game's code. To do this you need to "hook" or connect to one of the methods in the game's code. After doing this your code is linked to the game's code it get executed whenever the game uses the method you hooked.

Harmony has several different ways to hook the games code. Since BTD6/BTDAT use Il2cpp we can't use all of them, therefore we will only be using Prefixes and Postfixes.

# Getting Started

Before you can start using Harmony you need do the following:

![harmony patchall()](https://media.discordapp.net/attachments/619054151967703061/759606959304343572/unknown.png?width=639&height=141)

This is telling Harmony to hook *all* of your patches to the game. This should be the first thing in your mod. If you don't do this none of your Harmony patches will work. Also, instead of using `"TDToolbox.Random Stronger Bloons"` you should put `"AuthorName.ModName"`. You can use spaces and underscores if you want

# Prefix
When using Harmony Prefixes, your code will be executed *before* the game's code. 
Here's an example of how the method looks in the game's code:

![game's method](https://media.discordapp.net/attachments/619054151967703061/759598286834499584/unknown.png?width=561&height=147)

The code to hook this method looks like the following:

![Simple prefix hook](https://media.discordapp.net/attachments/619054151967703061/759601936458186762/unknown.png?width=1214&height=267)


The example above demonstrates what the game's method looks like and what our code would look like if we were to hook it. Notice how we're using `internal static` for our method. All Harmony patches need to be either `internal static` or `public static`, otherwise they won't be applied. A nice feature of Prefixes is you're able to get and even change the values of the arguments that go into the method you're hooking. For example if you look at the game's code for SetRotation you will notice the first line has `(float rotation)`. This is a paramater that passes information into the SetRotation method. In this case that parameter is a float value and its the rotation amount we want to set the bloon to. If you wanted to get the value of rotation before the method used it, you would do this:

![Getting variable from prefix](https://media.discordapp.net/attachments/619054151967703061/759602206298210336/unknown.png?width=1210&height=287)

Its important to remember that when you're referencing any parameters you **need** to spell it exactly, otherwise it won't work.

With a prefix we can actually change the value of rotation before the game's code gets it. This is really nice because we can change what information the game gets. In the example above we can change it as well in our copy called "copyRotation", however its a copy and not an actual reference to it. This means that in the example above, any changes to our variable "copyRotation" would *not* change the value that the games code gets, and would only change our copy. If you want to change what value the game gets, add the "ref" keyword like in the example below. This means that you are referencing the original and any changes made to it will affect the original. After your prefix finishes executing the games original code will execute (so long as you return true) and now the game will used the rotation that you modified. Heres what it would look like:

![Setting variable from prefix](https://media.discordapp.net/attachments/619054151967703061/759602414897856582/unknown.png?width=1228&height=306)


You can also get the exact Bloon that tried to use the SetRotation method. It's this easy:

![Getting instance of class](https://media.discordapp.net/attachments/619054151967703061/759602771006586890/unknown.png?width=1224&height=326)


All you need to do is put `Bloon __instance` as one of the parameters. For different classes in the game just change Bloon to whatever you need and keep instance the same. Ex: `Tower __instance`,  `Weapon __instance`, `Projectile __instance`. You have to use **2 underscores** otherwise it won't work. Just like in the previous example with `(ref float rotation)` you can set `__instance` to whatever you want. Normally you don't change it to entirely different thing, rather you just change aspects of it, like on our case we might change the BloonModel

---

# Postfix
Postfixes are hooks that execute your code *after* the game's method finishes. Postfixes are the most common because they allow the game to execute the same as it was going to originally. Prefixes are risky to use because they can permenantly change the result of the method, depending on what you do. This will change the method for everyone using your mod and will make your mod incompatible with all other mods that change this method. This is why it's best to always use Postfixes when you can. Don't let this discourage you though, prefixes are still very useful and sometimes they are required. Just use them sparingly.

Postfixes are coded almost exactly the same as a prefix, aside from a few key differences. Heres an example of a Postfix for the same method we used above, SetRotation():

![harmony postifx example](https://media.discordapp.net/attachments/619054151967703061/759610111474794516/unknown.png?width=1033&height=363)

Do you notice the differences? The only differences in how they are coded is they use the word `Postfix` instead of `Prefix` and they are `void` so they don't return anything. The last difference between them is Postfixes can get the result of a function, or what it returns to the game. For example, the method `CanTargetCamo()` is a method that the game uses to decide if a Tower can target a camo bloon. This method returns true or false, whether or not the Tower is actually able to target camo bloons. Heres how you'd get the return value of a method in a Postfix:

![getting result of method](https://media.discordapp.net/attachments/619054151967703061/759611505309909002/unknown.png?width=924&height=240)

Similar to getting the instance that used the method, you can get the result by using `Datatype __result` where datatype is the datatype of the return value (string, bool, int, etc) and the keyword `__result` with **2 underscores**. Just like with Prefixes you can still get the `__instance` of the tower that used the method, use `ref` keyword, as well as get any other parameters that the method uses.


