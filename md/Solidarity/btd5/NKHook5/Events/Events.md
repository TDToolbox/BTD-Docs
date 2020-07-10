# Events
This page has all of the events in NKHook5 as well as how to use them in your plugin

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