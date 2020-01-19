using System;

namespace strategy_pattern.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
