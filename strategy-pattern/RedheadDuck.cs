using System;
using strategy_pattern.Behaviors;

namespace strategy_pattern
{
    class ReadheadDuck : Duck
    {
        public ReadheadDuck()
        {
            Console.WriteLine("Readhead Duck");
            this.FlyBehavior = new FlyWithWing();
            this.QuackBehavior = new MuteQuack();
        }
    }
}
