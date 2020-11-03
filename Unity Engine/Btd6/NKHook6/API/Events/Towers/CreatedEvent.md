# TowerCreatedEvent
EventGroup |EventClass  |EventName
-----------|------------|---------
TowerEvents|CreatedEvent|TowerCreatedEvent


access the instance using the `e` in

```cs
[EventAttribute("TowerCreatedEvent")]
public static void onEvent(TowerEvents.CreatedEvent e){
    //Code here
}
```


## `.tower`
type: `Tower`

## `.entity`
type: `Entity`

## `.model`
type: `Model`