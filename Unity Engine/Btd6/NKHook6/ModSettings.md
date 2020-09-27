# Custom Mod Settings
NKhook6 comes with an easy to use Mod Settings class that you can use to add mod settings to your project. This means you can have customizable setting files that get saved to your mod's data folder. Users can access this settings file and change whatever you let them change so they can have a more unique experience and play the way they want. Its really awesome to have one in your mod and with NKHook6 you can make it in literally one line. Heres how you do it.

1. Create a new file in your mod. Call it anything you want. I usually call mine `Settings.cs`. Make sure the file ends in `.cs`
2. Open up that file and at the end of the class name put ` : ModSettings` . You're done! Here's what it should look like: 

![mod settings example](https://cdn.discordapp.com/attachments/619054151967703061/759614238246436904/unknown.png)

It's that easy! If you notice in step 2 I said to make sure it ends in `.cs`. If you're confused why it doesnt say `Settings.cs` in the picture its because the `.cs` is automatically applied to the file as a *file extension* and doesn't actually get added to the name.

You now have a fully functioning settings file for your mod. While you might have one now you still need to add settings to it. Here's how you do it

![setting example](https://media.discordapp.net/attachments/619054151967703061/759614926305099796/unknown.png?width=378&height=129)

In the picture you'll notice the words `int` and `MyProperty` are highlighted. `int` represents the datatype of the thing you want to save, while `MyProperty` is the actual name of it and the name of what you will see in the saved settings file. Change `int` to the datatype of the thing you want to save (int, string, bool, etc) and set `MyProperty` to whatever name you want. Also make sure that each variable you add to your settings is `public` and nothing else, otherwise it wont save right. If you want to set a default value you can do something like this:

![default value](https://media.discordapp.net/attachments/619054151967703061/759616377131761664/unknown.png?width=442&height=132)

You can add as many things as you want to your settings file. All thats left is to learn how to load your settings and how to save them.

### Loading settings:

Pick a good place to load your settings. Do you want to do it when the game starts? When a round starts? When a projectile is fired? Its up to you when you load it. Just make sure that your settings *do* get loaded. In this example I'm going to load them when the application starts, after I load my harmony patches.

![load settings example](https://media.discordapp.net/attachments/619054151967703061/759617470041423922/unknown.png?width=801&height=232)
Loading your settings is as simpel as that. Now to access the values inside of it just do `settings.` and after you type the period you will see a menu pop up with all the values you can use. This includes every variable you added to your Settings.cs file. If you load your settings like I did in the example, you can only acceess the data in `settings` in that particular method. If you want to allow your whole program to access the settings you loaded, do this:

![public static settings](https://media.discordapp.net/attachments/619054151967703061/759618884986208276/unknown.png?width=778&height=265)

If you do it this way you can access the `settings` variable at the top of your program anywhere in the program.


### Saving settings to file

If you want to save your settings to file, do this:
![Save your settings](https://media.discordapp.net/attachments/619054151967703061/759620167050854410/unknown.png?width=780&height=326)

It's as easy as that. The ModSettings class automatically keeps track of where your settings file is stored so you can worry about as little as possible
