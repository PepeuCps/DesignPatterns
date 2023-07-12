using _01_strategy_simuduck.Behaviors;

namespace _01_strategy_simuduck
{
    public class ModelDuck : DuckBase
    {
        public ModelDuck()
        {
            base.SetFlyBehavior(new FlyNoWay());
            base.SetQuackBehavior(new QuackSound());
        }

        public override void Display()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("I'm a model duck");
        }
    }
}
