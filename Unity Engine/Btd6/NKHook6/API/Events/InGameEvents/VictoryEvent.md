# InGameVictoryEvent
EventGroup  |EventClass  |EventName     
------------|------------|--------------
InGameEvents|VictoryEvent|InGameVictoryEvent


access the instance using the `e` in

```cs
[EventAttribute("InGameVictoryEvent")]
public static void onEvent(InGameEvents.VictoryEvent e){
    //Code here
}
```

## `.inGame` 
type: `InGame`

