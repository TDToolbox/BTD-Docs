# Console logging and in-game messages
NKHook6 comes with a slick console logging system that you can use to notify the user of anything relating to your game. It will also be immensly useful when developing your mod as it will help you keep track of whats happening.

- To use it, type `Logger.Log("YOUR_TEXT_HERE")`. Replace `YOUR_TEXT_HERE` with the text you want to log. You can also specify optional parameters, such as color and Logger Level
- Logger level is a specific way we keep track of messages. For example, we use it to specify if something is a warning, error, etc. Currently there are 4 options, they are `Normal`, `Warning`, `Error`, and `Update Notify`. You guys probably won't be using the last one too much. We plan to add more support for these Logger Levels and allow for certain events to happen depending on which logger level you use. 
- You can also show In-Game popups! Just do `Logger.InGameMsg("TITLE", "BODY");` where `TITLE` is the title of the window and `BODY` is the body text for the popup. Here's an example of our in-game popup to notify users when NKHook6 recieves a major update

![In Game popup](https://media.discordapp.net/attachments/619054151967703061/759506362199179264/unknown.png?width=1156&height=677)
