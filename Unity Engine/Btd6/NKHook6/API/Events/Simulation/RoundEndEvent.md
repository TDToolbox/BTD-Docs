# RoundEndEvent
EventGroup      |EventClass   |EventName
----------------|-------------|---------
SimulationEvents|RoundEndEvent|RoundEndEvent

access the instance using the `e` in

```cs
[EventAttribute("RoundEndEvent")]
public static void onEvent(SimulationEvents.RoundEndEvent e){
    //Code here
}
```


## `.simulation`
type: `Simulation`

## `.roundArrayIndex`
the round
type: `int`
