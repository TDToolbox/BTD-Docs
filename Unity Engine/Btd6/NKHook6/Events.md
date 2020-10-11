# Events
Not too long ago, we re-created the event system. This new event system is meant to replace the use of Harmony patches in a simple, version-indepentant manner. The problem with this, is that because the event system is unique to the game and meant to be easy, it doesn't have *every* feature. In cases like that, you'll have to use Harmony.

However, on this page you will see what events are available, how to use them, and more.

## Using events
Before you can use the event system, you have to register a class to it. To do this, simply copy this line of code into your main class and method:
```
EventRegistry.subscriber.register(typeof(<Class>));
```
and simply replace "<Class>" with your class name. For example, your class might look like this:
```
public class MyMod : MelonMod
{
    public override void OnApplicationStart()
    {
        base.OnApplicationStart();
        EventRegistry.subscriber.register(typeof(MyMod));
    }
}
```

To use events now is very simple, just follow this format in your mod class:
```
[EventAttribute("<EventName>")]
public static void onEvent(<EventGroup>.<EventClass> e){

}
```
Now this may seem a little confusing, however as you'll soon see, it is actually quite elegant and simple.

Lets say you wanted to use the "BloonLeakedEvent", so that you can execute code whenever a bloon escapes and makes you take damage. Your code would look like this:
```
[EventAttribute("BloonLeakedEvent")]
public static void onEvent(BloonEvents.LeakedEvent e){
    //Code here
}
```

## All events
Now that you know the format events are created in, here are all of the events with their corresponding name and class

|    EventGroup    | EventClass       | EventName              |
|:----------------:|------------------|------------------------|
|    BloonEvents   | CreatedEvent     | BloonCreatedEvent      |
|    BloonEvents   | DamagedEvent     | BloonDamagedEvent      |
|    BloonEvents   | DeletedEvent     | BloonDeletedEvent      |
|    BloonEvents   | LeakedEvent      | BloonLeakedEvent       |
|    BloonEvents   | MoveEvent        | BloonMoveEvent         |
|    BloonEvents   | RotateEvent      | BloonRotateEvent       |
|   InGameEvents   | VictoryEvent     | VictoryEvent           |
|  MainMenuEvents  | LoadedEvent      | MainMenuLoadedEvent    |
| ProjectileEvents | CreatedEvent     | ProjectileCreatedEvent |
| ProjectileEvents | DeletedEvent     | ProjectileDeletedEvent |
| SimulationEvents | CashChangedEvent | CashChangedEvent       |
| SimulationEvents | CashGainedEvent  | CashGainedEvent        |
| SimulationEvents | CashLostEvent    | CashLostEvent          |
| SimulationEvents | DefeatedEvent    | DefeatedEvent          |
| SimulationEvents | RoundEndEvent    | RoundEndEvent          |
| SimulationEvents | RoundStartEvent  | RoundStartEvent        |
| TowerEvents      | CreatedEvent     | TowerCreatedEvent      |
| TowerEvents      | DeletedEvent     | TowerDeletedEvent      |
| TowerEvents      | DeselectedEvent  | TowerDeselectedEvent   |
| TowerEvents      | SelectedEvent    | TowerSelectedEvent     |
| TowerEvents      | SoldEvent        | TowerSoldEvent         |
| TowerEvents      | UpgradeEvent     | TowerUpgradeEvent      |
| WeaponEvents     | CreatedEvent     | WeaponCreatedEvent     |
| WeaponEvents     | DeletedEvent     | WeaponDeletedEvent     |