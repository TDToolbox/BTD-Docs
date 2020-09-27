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

Again you can see that our system has simplified it for you. We want to make the modding process as smooth and easy as possible. You can even cancel the original method from our prefixes:

![cancelling method from prefixes](https://media.discordapp.net/attachments/619054151967703061/759638121423175690/unknown.png?width=522&height=163)


Lastly, due to the way the game is coded every harmony patch is executed **twice**. If you're not careful this could seriously mess up your mod. We've taken the liberty of removing that problem from our event system. Each event we've added to our custom events will only fire once, exactly when it needs to.


## Currently implimented events:

- Game Update : Occurs every time the game updates (very often)
- Key Press : Occurs when the user presses a key (you can get which key they pressed)
- Key Held : Occurs when the user holds a key (you can get which key they're holding)
- Key Released : Occurs when the user releases a key (you can get which key they released)
---
- MainMenu.OnEnable : Occurs every time the user goes to the main menu. Note: When patching with harmony this method is normally called twice when you see it for the first time in a game. We made our event version fire only once
---
- TimeManager.SetFastForward : Happens when you press the fast forward button
---
- InGame.Update : Occurs whenever InGame.instance is updated (often). Can be useful for running mods if InGame.instance is not null
- InGame.OnVictory : Occurs when you win a game
- InGame.GetContinueCost : Happens after you lose and you decide to spend monkey money to continue. Occurs after you click okay to spend the money
---
- Bloon.Initialise : When a bloon is created (it is off screen at this point)
- Bloon.OnDestroy : When a bloon is destroyed. Happens when popped and when it gets through exit
- Bloon.Damaged : Whenever the bloon takes any kind of damage
- Bloon.Leaked : When the bloon gets through the exit
- Bloon.UpdatedModel : Whenever the bloon model gets updated (example is when a layer gets popped)
- Bloon.SetRotation : Used by MOAB class bloons and Regrow bloons. MOAB class bloons call this like 20imes every second but regrows seem to call it once when needed
---
- Tower.Initialise : Occurs when a tower is created (example is when it is placed on map)
- Tower.Destroyed : Occurs when the tower is destroyed (example is when it is sold)
- Tower.Sold : Happens when the tower is sold
- Tower.UpdatedModel : Happens whenever the model is updated (ex: buying upgrades)
- Tower.OnUpgrade : Occurs whenever the tower is upgraded
- Tower.IsSelectable : Occurs whenever the user clicks on a tower. Game decides if its possible to select the tower or not
- Tower.IsUpgradeBlocked : Occurs whenever you buy an upgrade. Game checks if the upgrade is blocked or not
- Tower.AddPoppedCash : Occurs when you pop a bloon and cash is added for popping it
- Tower.GetSaveData : Occurs at the end of each round. Not exactly sure what else it does
- Tower.Hilight : Occurs when you click on the tower and it is highlighted with a white outline
- Tower.UnHighlight : Occurs when you click off of a tower and it is un-highlighted
---
- Simulation.RoundStart : Occurs when the round starts
- Simulation.RoundEnd : Occurs when the round ends
- Simulation.OnDefeat : Occurs when you lose the game
- Simulation.TakeDamage : Happens whenever the player looses any health at all
- Simulation.SetCash : Called once at the beginning of a game when you contiune previous game (not called for new games) and called every time you set cash in sandbox
- Simulation.AddCash : Occurs whenever you gain cash. Note: The game normally calls this method every InGame update even if you gain zero cash, so it's 20 times a second. We made our event only fire once when you get cash so no need to worry about repeating
- Simulation.RemoveCash : Occurs whenever cash is spent. Note: Game normally fires Harmony version of this 3 times for both prefix and postfix. Our event only fires once when cash is spent
---
- Weapon.Initialise : Happens when the weapon is created (not 100% sure but I think it's when tower is created/when buying upgrades)
- Weapon.OnDestroy : Happens when weapon is destroyed. Like above, not 100% sure but I think it happens when tower is destroyed
- Weapon.UpdatedModel : Happens whenever the weapons model is updated (ex: buying upgrades and being generally awesome)
---
- Projectile.Initialise : Happens when the projectile is created (when fired from weapon)
- Projectile.OnDestroy : Happens when the projectile is destroyed
- Projectile.UpdatedModel : Happens when the projectile model has been updated (I'm assuming mid-flight because projectiles are fired from weapons)
