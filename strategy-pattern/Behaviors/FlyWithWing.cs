using System;

namespace strategy_pattern.Behaviors
{
    public class FlyWithWing : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with Wing");
        }
    }
}
