using System;
using strategy_pattern.Behaviors;

namespace strategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern Examples");
            Console.WriteLine("-------------");
            Duck duck1 = new MallarDuck();
            duck1.PerformFly();
            duck1.PerformQuack();

            Console.WriteLine("-------------");

            Duck duck2 = new ReadheadDuck();
            duck2.PerformFly();
            duck2.PerformQuack();
            
            Console.WriteLine("-------------");

            Duck duck3 = new RubberDuck();
            duck3.PerformFly();
            duck3.PerformQuack();

            duck3.FlyBehavior = new FlyWithWing();
            duck3.PerformFly();
        }
    }
}
