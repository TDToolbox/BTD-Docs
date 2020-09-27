# Events
As you know, we mod BTD6 by using MelonLoader and Harmony patches. The problem is after a while harmony patches can get tedious and make your code look very ugly. Thats why we created our own custom event system so you can easily hook and alter the most common game methods without the long code. Here's an example of hooking Bloon.SetRotation with our event system vs with harmony:

### Our event system:
![our event system](https://media.discordapp.net/attachments/619054151967703061/759627919931867156/unknown.png?width=520&height=147)

### Harmony's event system:
![harmony's event system](https://media.discordapp.net/attachments/619054151967703061/759628715742855218/unknown.png?width=417&height=231)

This picture illustrates well that while harmony's system isn't bad, it definitely uses more code to do the same thing. Another reason to use the custom event system is we've tested every hook we add and only make sure to add hooks that you will use. This means you don't have to try to figure out which one you need for your mod, chances are we already added it! And if we missed a hook you'd really like to see in the api, join our [discord](https://discord.gg/VADMF2M) server and request we add it

Something else to point out about our custom event system is we've already collected every variable passed into the method and wired it all together, so now instead of having to use `ref` variable xyz you can just do `e.` and have access to every variable that method is in contact with. You can use this to both get and set the variable's original methods. Here's an example:

### Using custom event attributes
![our custom event attributes](https://media.discordapp.net/attachments/619054151967703061/759629970480955432/unknown.png?width=511&height=151)

### Harmony event attributes
![harmony event attributes](https://media.discordapp.net/attachments/619054151967703061/759630060415090748/unknown.png?width=486&height=243)

Again you can see that our system has simplified it for you. We want to make the modding process as smooth and easy as possible. Lastly, due to the way the game is coded every harmony patch is executed **twice**. If you're not careful this could seriously mess up your mod. We've taken the liberty of removing that problem from our event system. Each event we've added to our custom events will only fire once, exactly when it needs to.


## Currently implimented events:

- Game Update : Occurs every time the game updates (very often)
- Key Press : Occurs when the user presses a key (you can get which key they pressed)
- Key Held : Occurs when the user holds a key (you can get which key they're holding)
- Key Released : Occurs when the user releases a key (you can get which key they released)

- MainMenu.OnEnable : Occurs every time the user goes to the main menu

- Bloon.Initialise : When a bloon is created (it is off screen at this point)
- Bloon.OnDestroy : When a bloon is destroyed. Happens when popped and when it gets through exit
- Bloon.Damaged : Whenever the bloon takes any kind of damage
- Bloon.Leaked : When the bloon gets through the exit
- Bloon.UpdateModel : Whenever the bloon model gets updated (example is when a layer gets popped)
- Bloon.SetRotation : Occurs whenever the SetRotation method is called in the game (not often tbh. Might remove this one)

- Tower.Initialise : Occurs when a tower is created (example is when it is placed on map)
- Tower.Destroyed : Occurs when the tower is destroyed (example is when it is sold)
