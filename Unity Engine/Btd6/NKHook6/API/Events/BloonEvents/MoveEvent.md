# BloonMoveEvent
EventGroup |EventClass |EventName     |
-----------|-----------|--------------|
BloonEvents|MoveEvent  |BloonMoveEvent|


access the instance using the `e` in

```cs
[EventAttribute("BloonMoveEvent")]
public static void onEvent(BloonEvents.MoveEvent e){
    //Code here
}
```

## `.bloon` 
type: `bloon`
## `.rotation`
type: `float`
