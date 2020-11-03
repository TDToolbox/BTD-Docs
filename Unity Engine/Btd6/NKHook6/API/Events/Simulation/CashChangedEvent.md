# CashChangedEvent
EventGroup      |EventClass      |EventName
----------------|----------------|---------
SimulationEvents|CashChangedEvent|CashChangedEvent

access the instance using the `e` in

```cs
[EventAttribute("CashChangedEvent")]
public static void onEvent(SimulationEvents.CashChangedEvent e){
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