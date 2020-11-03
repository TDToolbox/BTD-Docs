# BloonDamagedEvent
EventGroup |EventClass	|EventName
-----------|------------|---------
BloonEvents|DamagedEvent|BloonDamagedEvent

access the instance using the `e` in

```cs
[EventAttribute("BloonDamagedEvent")]
public static void onEvent(BloonEvents.DamagedEvent e){
    //Code here
}
```

## `.bloon`
type: `bloon`
## `.damageTaken `
type: `float`
## `.damageTypes `
type: `Array<string>` (Il2CppStringArray)
## `.projectile`
type: `Projectile`
## `.distrubuteToChildren`
type: `boolean`
## `.overrideDistributeBlocker`
type: `boolean`
## `.createEffect`
type: `boolean`
## `.tower`
type: `Tower`
## `.canDestroyProjectile`
type: `boolean`
## `ignoreImmunityForBloonTypes`
type: `Array<string>` (Il2CppStringArray)
## `.ignoreNonTargetables`
type: `boolean`
## `.blockSpawnChildren`
type: `boolean`