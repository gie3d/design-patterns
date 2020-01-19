using System;

namespace strategy_pattern.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Do nothing. Sorry I can't fly");
        }
    }
}
