using System;
using strategy_pattern.Behaviors;

namespace strategy_pattern
{
    public class Duck
    {
        public IFlyBehavior FlyBehavior {get;set;}
        public IQuackBehavior QuackBehavior {get;set;}
        public Duck()
        {

        }

        public void PerformFly()
        {
            if (this.FlyBehavior != null)
            {
                FlyBehavior.Fly();
            }
        }

        public void PerformQuack()
        {
            if (this.QuackBehavior != null)
            {
                QuackBehavior.Quack();
            }
        }

        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
}
