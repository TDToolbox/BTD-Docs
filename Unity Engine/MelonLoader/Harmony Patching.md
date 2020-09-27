# Learn more about Harmony Patching
Read this page to get a crash course in Harmony!


## Harmony Basics
[Harmony](https://harmony.pardeike.net/index.html) is an amazing tool you can use to "hook" the game's code and have your own code get executed. In simpler terms, harmony creates a link between *your* mod and the game's code. To do this you need to "hook" or connect to one of the methods in the game's code. After doing this your code is linked to the game's code it get executed whenever the game uses the method you hooked.

Harmony has several different ways to hook the games code. Since BTD6/BTDAT use Il2cpp we can't use all of them, therefore we will only be using Prefixes and Postfixes.

# Prefix
When using Harmony Prefixes, your code will be executed *before* the game's code. 
Example:

Here's how the method looks in the game's code:

![game's method](https://media.discordapp.net/attachments/619054151967703061/759598286834499584/unknown.png?width=561&height=147)

If we were to hook this our code would look like this:

![Simple prefix hook](https://media.discordapp.net/attachments/619054151967703061/759600555638784000/unknown.png?width=1246&height=270)

---

The example above demonstrates what the game's method looks like and what our code would look like if we were to hook it. Prefixes are really nice because you're able to get and even change the values of the arguments that go into it. For example if you look at the game's code for SetRotation you will notice the first line has `(float rotation)`. This is a paramater that passes information into the SetRotation method. In this case that parameter is a float value and its the rotation amount we want to set the bloon to. If you wanted to get the value of rotation before the method used it, you would do this:

![Getting variable from prefix](https://media.discordapp.net/attachments/619054151967703061/759600766880317480/unknown.png?width=1257&height=297)

Its important to remember that when you're referencing any parameters you **need** to spell it exactly, otherwise it won't work.

---

With a prefix we can actually change the value of rotation before the game's code gets it. This is really nice because we can change what information the game gets. In the example above we can change it as well in our copy called "copyRotation", however its a copy and not an actual reference to it. This means that in the example above, any changes to our variable "copyRotation" would *not* change the value that the games code gets, and would only change our copy. If you want to change what value the game gets, add the "ref" keyword like in the example below. This means that you are referencing the original and any changes made to it will affect the original. After your prefix finishes executing the games original code will execute (so long as you return true) and now the game will used the rotation that you modified. Heres what it would look like:

![Setting variable from prefix](https://media.discordapp.net/attachments/619054151967703061/759600942353350696/unknown.png?width=1266&height=301)

---

You can also get the exact Bloon that tried to use the SetRotation method. It's this easy:

![Getting instance of class](https://media.discordapp.net/attachments/619054151967703061/759601132162514954/unknown.png?width=1246&height=282)


All you need to do is put `Bloon __instance` as one of the parameters. For different classes in the game just change Bloon to whatever you need and keep instance the same. Ex: `Tower __instance`,  `Weapon __instance`, `Projectile __instance`. You have to use **2 underscores** otherwise it won't work. Just like in the previous example with `(ref float rotation)` you can set `__instance` to whatever you want. Normally you don't change it to entirely different thing, rather you just change aspects of it, like on our case we might change the BloonModel

# Postfix
