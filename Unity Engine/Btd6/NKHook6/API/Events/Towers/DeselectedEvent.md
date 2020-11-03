# TowerDeselectedEvent
EventGroup |EventClass     |EventName
-----------|---------------|---------
TowerEvents|DeselectedEvent|TowerDeselectedEvent


access the instance using the `e` in

```cs
[EventAttribute("TowerDeselectedEvent")]
public static void onEvent(TowerEvents.DeselectedEvent e){
    //Code here
}
```


## `.instance`
type: `Tower`
