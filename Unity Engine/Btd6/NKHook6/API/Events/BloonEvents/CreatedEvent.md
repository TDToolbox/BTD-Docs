# BloonCreatedEvent
EventGroup |EventClass	|EventName
-----------|------------|---------
BloonEvents|CreatedEvent|BloonCreatedEvent

access the instance using the `e` in

```cs
[EventAttribute("BloonCreatedEvent")]
public static void onEvent(BloonEvents.CreatedEvent e){
    //Code here
}
```

## `.bloon`
type: `bloon`
## `.model`
type: `bloonModel`
## `.entity`
type: `Entity`