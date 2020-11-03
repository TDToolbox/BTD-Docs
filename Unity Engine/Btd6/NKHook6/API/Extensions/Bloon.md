# Bloon extension methods
```cs
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Simulation.Bloons;
using NKHook6.Api.Extensions;
```

# `Bloon`

(can be from an instance of a `BloonEvents` event group or from `.getBloons()`)

## `.getId()`

returns the id of the bloon

```cs
Bloon.getId(Bloon bloon); // note you need to put an actual bloon here
```


## `.setBloonModel()`
Takes in a BloonModel and sets the bloon instance's model to the given model.

```cs
Bloon.setBloonModel(Bloon bloon, BloonModel model); // note you need to put an actual bloon/bloonModel here
```

## `.getDamage()`

Returns the amount of damage a bloon instance will deal when leaked.

```cs
float dmg = Bloon.getDamage(Bloon bloon); // note you need to put an actual bloon here
```

type: `float`

## `.isCamo()`

Returns whether the bloon has camo or not


```cs
bool isCamo = Bloon.isCamo(Bloon bloon); // note you need to put an actual bloon here
```

type: `boolean`

## `.setCamo()`

```cs
Bloon.setCamo(Bloon bloon, bool isCamo); // note you need to put an actual bloon here
```

## `.isRegrow()`

Returns whether the bloon has camo or not


```cs
bool isRegrow = Bloon.isRegrow(Bloon bloon); // note you need to put an actual bloon here
```

type: `boolean`

## `.setRegrow()`

```cs
Bloon.setRegrow(Bloon bloon, bool isCamo); // note you need to put an actual bloon here
```

## `.isFortified()`

Returns whether the bloon has camo or not


```cs
bool isFortified = Bloon.isFortified(Bloon bloon); // note you need to put an actual bloon here
```

type: `boolean`

## `.setFortified()`

```cs
Bloon.setFortified(Bloon bloon, bool isCamo); // note you need to put an actual bloon here
```

## `.getNextStrongest()`

Returns the bloonmodel of the next (stronger) bloon

## `.getNextWeakest()`

Returns the bloonmodel of the next (weaker) bloon