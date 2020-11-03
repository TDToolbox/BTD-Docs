# TowerDeletedEvent
EventGroup |EventClass  |EventName
-----------|------------|---------
TowerEvents|DeletedEvent|TowerDeletedEvent


access the instance using the `e` in

```cs
[EventAttribute("TowerDeletedEvent")]
public static void onEvent(TowerEvents.DeletedEvent e){
    //Code here
}
```


## `.instance`
type: `Tower`
