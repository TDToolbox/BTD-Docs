# TowerSelectedEvent
EventGroup |EventClass|EventName
-----------|----------|---------
TowerEvents|SoldEvent |TowerSoldEvent


access the instance using the `e` in

```cs
[EventAttribute("TowerSoldEvent")]
public static void onEvent(TowerEvents.SoldEvent e){
    //Code here
}
```


## `.instance`
type: `Tower`

## `.sellAmount`
type: `float`