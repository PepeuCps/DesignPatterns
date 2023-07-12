using _01_strategy_simuduck.Behaviors;

namespace _01_strategy_simuduck
{
    public class MallardDuck : DuckBase
    {
        public MallardDuck()
        {
            base.SetFlyBehavior(new FlyWithWings());
            base.SetQuackBehavior(new QuackSound());
        }

        public override void Display()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("I'm a real Mallard Duck");
        }
    }
}
