# MainMenuLoadedEvent
EventGroup    |EventClass |EventName
--------------|-----------|---------
MainMenuEvents|LoadedEvent|MainMenuLoadedEvent

access the instance using the `e` in

```cs
[EventAttribute("MainMenuLoadedEvent")]
public static void onEvent(MainMenuEvents.LoadedEvent e){
    //Code here
}
```

## `.menu` 
type: `MainMenu`