using System;
using strategy_pattern.Behaviors;

namespace strategy_pattern
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            Console.WriteLine("Rubber Duck");
            this.FlyBehavior = new FlyNoWay();
            this.QuackBehavior = new MuteQuack();
        }
    }
}
