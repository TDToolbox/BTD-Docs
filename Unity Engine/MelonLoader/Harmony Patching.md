# Learn more about Harmony Patching
Read this page to get a crash course in Harmony!


## Harmony Basics
[Harmony](https://harmony.pardeike.net/index.html) is an amazing tool you can use to "hook" the game's code and have your own code get executed. In simpler terms, harmony creates a link between *your* mod and the game's code. To do this you need to "hook" or connect to one of the methods in the game's code. After doing this your code is linked to the game's code it get executed whenever the game uses the method you hooked.

Harmony has several different ways to hook the games code. Since BTD6/BTDAT use Il2cpp we can't There are two main ways we'll be hooking the game's code for BTD6/BTDAT modding. They are Prefixes and Postfixes.

# Prefix
When using Harmony Prefixes, your code will be executed *before* the game's code. 
Example:

Here's how the method looks in the game's code:
`public void SetRotation(float rotation)
{
  //game code would normally be here. Removed for simplicity
}`

If we were to hook this our code would look like this:
`
class SetRotation_Patch  //Can use any name here, though it should releate to the method you're patching
{
    [HarmonyPrefix]
    internal static bool Prefix()
    {
        //Put your code here
        
        return true; //Return true if you want the games code to execute. Return false if you want it to be skipped(avoid this if possible).
    }
}
`
----
The example above demonstrates what the game's method looks like and what our code would look like if we were to hook it. Prefixes are really nice because you're able to get and even change the values of the arguments that go into it. For example if you look at the game's code for SetRotation you will notice the first line has `(float rotation)`. This is a paramater that passes information into the SetRotation method. In this case that parameter is a float value and its the rotation amount we want to set the bloon to. If you wanted to get the value of rotation before the method used it, you would do this:
`
class SetRotation_Patch  //Can use any name here, though it should releate to the method you're patching
{
    [HarmonyPrefix]
    internal static bool Prefix(float rotation) //this line here is the change. I simply add (float rotation) in the parenthasis and I'll be able to access the code
    {
        float copyRotation = rotation; //this is how you would use it
        //Put your code here
        
        return true; //Return true if you want the games code to execute. Return false if you want it to be skipped(avoid this if possible).
    }
}
`

Its important to remember that when you're referencing any parameters you **need** to spell it exactly, otherwise it won't work.

-----
With a prefix we can actually change the value of rotation before the game's code gets it. This is really nice because we can change what information the game gets. In the example above we can change it as well in our copy called "copyRotation", however its a copy and not an actual reference to it. This means that in the example above, any changes to our variable "copyRotation" would *not* change the value that the games code gets, and would only change our copy. If you want to change what value the game gets, add the "ref" keyword like in the example below. This means that you are referencing the original and any changes made to it will affect the original. After your prefix finishes executing the games original code will execute (so long as you return true) and now the game will used the rotation that you modified. Heres what it would look like:

`
class SetRotation_Patch  //Can use any name here, though it should releate to the method you're patching
{
    [HarmonyPrefix]
    internal static bool Prefix(ref float rotation)  //put the "ref" keyword before "float rotation" if you want to change it.
    {
        //Put your code here
        rotation = 0; //using this with the "ref" keyword will allow you to change the original variable
        return true; //Return true if you want the games original code to execute. Return false if you want it to be skipped(avoid this if possible).
    }
}
`

-----

You can also get the exact Bloon that tried to use the SetRotation method. It's this easy:
`
class SetRotation_Patch  //Can use any name here, though it should releate to the method you're patching
{
    [HarmonyPrefix]
    internal static bool Prefix(Bloon __instance, ref float rotation)  //add the Class name and then __instance (2 underscores!)
    {
        //Put your code here
        rotation = 0; //using this with the "ref" keyword will allow you to change the original variable
        return true; //Return true if you want the games original code to execute. Return false if you want it to be skipped(avoid this if possible).
    }
}
`
All you need to do is put `Bloon __instance` as one of the parameters. For different classes in the game just change Bloon to whatever you need and keep instance the same. Ex: `Tower __instance`,  `Weapon __instance`, `Projectile __instance`. You have to use **2 underscores** otherwise it won't work. Just like in the previous example with `(ref float rotation)` you can set `__instance` to whatever you want. Normally you don't change it to entirely different thing, rather you just change aspects of it, like on our case we might change the BloonModel

# Postfix
