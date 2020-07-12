# Events
This page has all of the events in NKHook5 as well as how to use them in your plugin. Events are functions that take in a function and then call the given function when the event is triggered. This may sound complicated, but don't worry, its actually quite simple. As you will see in examples below, youll call event funtions in a format like this:
```
onEvent(fun(parameters){
    //Do stuff with parameters
});
```
the "fun(){}" creates a brand new function and gives it to onEvent so that when the event happens, the code written inside can be executed.

This format isn't only for events, however. This can also be seen in functions like "forEachTower" from the Tower Manager.

## onKey
This event is triggered whenever the game detects a key press

Example from [Movable Towers](https://github.com/DisabledMallis/NKHook5/blob/master/ScriptExamples/MovableTowers.chai):
```
//Create a variable for if we are moving towers
//The global version of "mov" is "moving" and so we want to use "moving" instead of "mov" now
var mov = 0
add_global(mov, "moving")
//onKey is a function that calls any given function inside whenever the game receives a key press.
onKey(fun(key)
{
	//Capital letters mean shift + the letter need to be pressed
	//Caps lock also works
	//You can use "if(key=='D'||key=='d')" to ignore casing
	if(key=='D')
	{
		//Adds 1 to moving (aka "mov" as defined above)
		moving = moving + 1
	}
});
```

## onBloonEscaped
This event is triggered when a bloon escapes through your towers and takes health.

Example:
```
//Called when a bloon escapes
onBloonEscaped(fun(event)
{
	//Get game data "getGame().getCGameSystemPointers().getGameData()"
	var gameData := lhcm_ptrs.getGameData();
	//Check to make sure its not null, if it is the game will crash
	if(!is_var_null(gameData))
	{
		//Set cash to cash - the escaped bloon's damage
		gameData.setCash(gameData.getCash()-event.getEscapedBloon().getBloonData().getDamage());
		//If cash is less than or equal to 0
		if(gameData.getCash() <= 0){
			//Kill the player
			gameData.setHealth(0)
		}
	}
});
```

This example will cause the player to lose money when a bloon escapes. This won't prevent the player from losing health, you'll have to prevent that yourself if you want to.


## onTowerUpgrade
This event is triggered when a Tower is upgraded.

Example:
```
//Called when a Tower is upgraded
/*
towerManager - The CTowerManager
tower - The upgraded tower
path - The upgraded path
*/
onTowerUpgrade(fun(towerManager, tower, path)
{
    if(path == 0)
	{
		print("Left path was upgraded!");
	}
	if(path == 1)
	{
		print("Right path was upgraded!");
	}
});
```