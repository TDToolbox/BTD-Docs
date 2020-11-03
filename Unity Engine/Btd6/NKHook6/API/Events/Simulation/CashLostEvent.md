# CashLostEvent
EventGroup      |EventClass   |EventName
----------------|-------------|---------
SimulationEvents|CashLostEvent|CashLostEvent

access the instance using the `e` in

```cs
[EventAttribute("CashLostEvent")]
public static void onEvent(SimulationEvents.CashLostEvent e){
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
