using System;
using strategy_pattern.Behaviors;

namespace strategy_pattern
{
    class MallarDuck : Duck
    {
        public MallarDuck()
        {
            Console.WriteLine("Mallar Duck");
            this.FlyBehavior = new FlyWithWing();
            this.QuackBehavior = new Squeak();
        }
    }
}
