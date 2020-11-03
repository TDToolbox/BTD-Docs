# DefeatedEvent
EventGroup      |EventClass   |EventName
----------------|-------------|---------
SimulationEvents|DefeatedEvent|DefeatedEvent

access the instance using the `e` in

```cs
[EventAttribute("DefeatedEvent")]
public static void onEvent(SimulationEvents.DefeatedEvent e){
    //Code here
}
```


## `.simulation`
type: `Simulation`

