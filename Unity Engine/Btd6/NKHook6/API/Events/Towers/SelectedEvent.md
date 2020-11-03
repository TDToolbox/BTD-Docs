# TowerSelectedEvent
EventGroup |EventClass   |EventName
-----------|-------------|---------
TowerEvents|SelectedEvent|TowerSelectedEvent


access the instance using the `e` in

```cs
[EventAttribute("TowerSelectedEvent")]
public static void onEvent(TowerEvents.SelectedEvent e){
    //Code here
}
```


## `.instance`
type: `Tower`
