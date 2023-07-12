using _01_strategy_simuduck.Interfaces;

namespace _01_strategy_simuduck.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying!");
        }
    }
}
