# Events
Not too long ago, we re-created the event system. This new event system is meant to replace the use of Harmony patches in a simple, version-independent manner. The problem with this, is that because the event system is unique to the game and meant to be easy, it doesn't have *every* feature. In cases like that, you'll have to use Harmony.

However, on this page you will see what events are available, how to use them, and more.

## Using events
Before you can use the event system, you have to register a class to it. To do this, simply copy this line of code into your main class and method:
```cs
EventRegistry.subscriber.register(typeof(<Class>));
```
and simply replace "\<Class\>" with your class name. For example, your class might look like this:
```cs
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
```cs
public class MyMod : MelonMod
{
    public override void OnApplicationStart()
    {
        base.OnApplicationStart();
        EventRegistry.subscriber.register(typeof(MyMod));
    }
    [EventAttribute("<EventName>")]
    public static void onEvent(<EventGroup>.<EventClass> e){
    }
}
```
Now this may seem a little confusing, however as you'll soon see, it is actually quite elegant and simple.

Lets say you wanted to use the "BloonLeakedEvent", so that you can execute code whenever a bloon escapes and makes you take damage. Your code would look like this:
```cs
public class MyMod : MelonMod
{
    public override void OnApplicationStart()
    {
        base.OnApplicationStart();
        EventRegistry.subscriber.register(typeof(MyMod));
    }
    [EventAttribute("BloonLeakedEvent")]
    public static void onEvent(BloonEvents.LeakedEvent e){
        //Code here
    }
}
```

## All events
Now that you know the format events are created in, here are all of the events with their corresponding name and class

|   EventGroup    |EventClass       |EventName              
|-----------------|-----------------|--------------------------------------------------------------------
|BloonEvents      |CreatedEvent     |[BloonCreatedEvent](./API/Events/BloonEvents/CreatedEvent.md)
|BloonEvents      |DamagedEvent     |[BloonDamagedEvent](./API/Events/BloonEvents/DamagedEvent.md)
|BloonEvents      |DeletedEvent     |[BloonDeletedEvent](./API/Events/BloonEvents/LeakedEvent.md)
|BloonEvents      |LeakedEvent      |[BloonLeakedEvent](./API/Events/BloonEvents/LeakedEvent.md)
|BloonEvents      |MoveEvent        |[BloonMoveEvent](./API/Events/BloonEvents/MoveEvent.md)
|BloonEvents      |RotateEvent      |BloonRotateEvent
|InGameEvents     |VictoryEvent     |[VictoryEvent](./API/Events/InGameEvents/VictoryEvent.md)
|MainMenuEvents   |LoadedEvent      |[MainMenuLoadedEvent](./API/Events/MainMenuEvents/LoadedEvent.md)
|ProjectileEvents |CreatedEvent     |[ProjectileCreatedEvent](API/Events/Projectile/CreatedEvent.md)
|ProjectileEvents |DeletedEvent     |[ProjectileDeletedEvent](./API/Events/Projectile/DeletedEvent.md)
|SimulationEvents |CashChangedEvent |[CashChangedEvent](./API/Events/Simulation/CashChangedEvent.md)
|SimulationEvents |CashGainedEvent  |[CashGainedEvent](./API/Events/Simulation/CashGainedEvent.md)
|SimulationEvents |CashLostEvent    |[CashLostEvent](./API/Events/Simulation/CashLostEvent.md)
|SimulationEvents |DefeatedEvent    |[DefeatedEvent](./API/Events/Simulation/DefeatedEvent.md)
|SimulationEvents |RoundEndEvent    |[RoundEndEvent](./API/Events/Simulation/RoundEndEvent.md)
|SimulationEvents |RoundStartEvent  |[RoundStartEvent](./API/Events/Simulation/RoundStartEvent.md)|
|TowerEvents      |CreatedEvent     |[TowerCreatedEvent](./API/Events/Towers/CreatedEvent.md)|
|TowerEvents      |DeletedEvent     |[TowerDeletedEvent](./API/Events/Towers/DeletedEvent.md)|
|TowerEvents      |DeselectedEvent  |[TowerDeselectedEvent](API/Events/Towers/DeselectedEvent.md)|
|TowerEvents      |SelectedEvent    |[TowerSelectedEvent](./API/Events/Towers/SelectedEvent.md)|
|TowerEvents      |SoldEvent        |[TowerSoldEvent](./API/Events/Towers/SoldEvent.md)|
|TowerEvents      |UpgradeEvent     |TowerUpgradeEvent
|WeaponEvents     |CreatedEvent     |WeaponCreatedEvent
|WeaponEvents     |DeletedEvent     |WeaponDeletedEvent
