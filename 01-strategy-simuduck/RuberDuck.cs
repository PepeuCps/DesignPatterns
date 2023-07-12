using _01_strategy_simuduck.Behaviors;

namespace _01_strategy_simuduck
{
    public class RuberDuck : DuckBase
    {
        public RuberDuck()
        {
            base.SetFlyBehavior(new FlyNoWay());
            base.SetQuackBehavior(new Squeak());
        }

        public override void Display()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("I'm a yellow ruber duck");
        }
    }
}
