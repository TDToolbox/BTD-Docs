# ProjectileCreatedEvent
EventGroup      |EventClass  |EventName
----------------|------------|---------
ProjectileEvents|CreatedEvent|ProjectileCreatedEvent

access the instance using the `e` in

```cs
[EventAttribute("ProjectileCreatedEvent")]
public static void onEvent(ProjectileEvents.CreatedEvent e){
    //Code here
}
```

## `.model` 
type: `Model`

## `.entity`
type: `Entity`

## `instance`
type: `Projectile`