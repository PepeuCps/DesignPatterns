using _01_strategy_simuduck.Interfaces;

namespace _01_strategy_simuduck.Behaviors
{
    public class QuackSound : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack, Quack, Quack");
        }
    }
}
