# RoundStartEvent
EventGroup      |EventClass     |EventName
----------------|---------------|---------
SimulationEvents|RoundStartEvent|RoundStartEvent


access the instance using the `e` in

```cs
[EventAttribute("RoundStartEvent")]
public static void onEvent(SimulationEvents.RoundStartEvent e){
    //Code here
}
```


## `.simulation`
type: `Simulation`

## `.roundArrayIndex`
the round
type: `int`
