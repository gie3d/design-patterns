# Strategy Pattern

We separate what changes from what stays the same. In this example, we have different type of ducks and each type has their own way of flying and quacking. However, it all can swim.

Mallar Duck

-   fly with wing
-   can quack (squeak)
-   can swim

Redhead Duck

-   fly with wing
-   cannot quack
-   can swim

Rubber Duck

-   cannot fly
-   cannot quack
-   can swim

Mallar Duck and Redhead Duck can share the same code on flying (assume that it flies exactly the same)
Redhead Duck and Rubber Duck can share the same code on quacking
Since they all can swim and assuming that all ducks can swim. So I don't pull the swim code from the Duck super class. Later if ducks have different way of swimming, we can use this pattern to extract swimming behavior out of the super class.

These ducks are assigned behaviors in its constructor.

```csharp
public MallarDuck()
{
    this.FlyBehavior = new FlyWithWing();
    this.QuackBehavior = new Squeak();
}
```

```csharp
public RedheadDuck()
{
    this.FlyBehavior = new FlyWithWing();
    this.QuackBehavior = new MuteQuack();
}
```

```csharp
public RubberDuck()
{
    this.FlyBehavior = new FlyNoWay();
    this.QuackBehavior = new MuteQuack();
}
```

And all of them inherit Duck super class. So it can be used like this.

```csharp
Duck duck1 = new MallarDuck();
duck1.PerformFly();
duck1.PerformQuack();
```

```csharp
Duck duck1 = new RedheadDuck();
duck1.PerformFly();
duck1.PerformQuack();
```

```csharp
Duck duck1 = new RubberDuck();
duck1.PerformFly();
duck1.PerformQuack();
```

In this behavior, it's also possible to change behavior during run time.

```csharp
Duck duck3 = new RubberDuck();
duck3.PerformFly();
duck3.PerformQuack();

duck3.FlyBehavior = new FlyWithWing();
duck3.PerformFly();
```
