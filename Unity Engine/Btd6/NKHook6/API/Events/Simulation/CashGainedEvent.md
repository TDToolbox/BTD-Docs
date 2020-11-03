# CashGainedEvent
EventGroup      |EventClass     |EventName
----------------|---------------|---------
SimulationEvents|CashGainedEvent|CashGainedEvent

access the instance using the `e` in

```cs
[EventAttribute("CashGainedEvent")]
public static void onEvent(SimulationEvents.CashGainedEvent e){
    //Code here
}
```


## `.simulation`
type: `Simulation`

## `.cash`
type: `double`

## `.from`
type: `Simulation.CashType`

## `.cashIndex`
type: `int`

## `.source`
type: `Simulation.CashSource`

## `tower`
type: `Tower`