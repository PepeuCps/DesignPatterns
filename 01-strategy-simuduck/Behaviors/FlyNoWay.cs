using _01_strategy_simuduck.Interfaces;

namespace _01_strategy_simuduck
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }
}
