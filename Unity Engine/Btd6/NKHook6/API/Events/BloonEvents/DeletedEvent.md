# BloonDeletedEvent
EventGroup |EventClass	|EventName
-----------|------------|---------
BloonEvents|DeletedEvent|BloonDeletedEvent

access the instance using the `e` in

```cs
[EventAttribute("BloonDeletedEvent")]
public static void onEvent(BloonEvents.DeletedEvent e){
    //Code here
}
```

## `.bloon` 
type: `bloon`