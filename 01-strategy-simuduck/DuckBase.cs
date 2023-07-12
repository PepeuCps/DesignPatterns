using _01_strategy_simuduck.Interfaces;

namespace _01_strategy_simuduck
{
    public abstract class DuckBase
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;

        public abstract void Display();

        public void PerformFly()
        {
            this._flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            this._quackBehavior.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            this._flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            this._quackBehavior = qb;
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float!");
        }

    }
}
