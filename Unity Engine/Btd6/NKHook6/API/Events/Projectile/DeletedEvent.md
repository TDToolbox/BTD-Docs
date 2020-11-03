# ProjectileDeletedEvent
EventGroup      |EventClass  |EventName
----------------|------------|---------
ProjectileEvents|DeletedEvent|ProjectileDeletedEvent

access the instance using the `e` in

```cs
[EventAttribute("ProjectileDeletedEvent")]
public static void onEvent(ProjectileEvents.DeletedEvent e){
    //Code here
}
```


## `.instance`
type: `Projectile`