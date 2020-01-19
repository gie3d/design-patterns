using System;

namespace strategy_pattern.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Muted. Sorry I can't Quack");
        }
    }
}
