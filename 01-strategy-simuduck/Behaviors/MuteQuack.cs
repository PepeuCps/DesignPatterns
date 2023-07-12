using _01_strategy_simuduck.Interfaces;

namespace _01_strategy_simuduck.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
