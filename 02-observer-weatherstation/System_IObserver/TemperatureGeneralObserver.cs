namespace _02_observer_weatherstation.System_IObserver
{
    public class TemperatureGeneralObserver : IObserver<Temperature>
    {
        private IDisposable _unsubscriber;
        private bool first = true;
        private Temperature last;

        public virtual void Subscribe(IObservable<Temperature> provider)
        {
            _unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("GeneralObserver Completed - Additional temperature data will not be transmitted.");
        }

        public virtual void OnError(Exception error)
        {
            Console.WriteLine("GeneralObserver Error");
        }

        public virtual void OnNext(Temperature value)
        {
            Console.WriteLine("GeneralObserver - The temperature is {0}°C at {1:g}", value.Degrees, value.Date);
                        
            if (first)
            {
                first = false;
            } else {

                var hours = (value.Date - last.Date).TotalHours;
                Console.WriteLine("   GeneralObserver - Change: {0}° in {1:g} hours", Math.Abs(value.Degrees - last.Degrees), hours);
            }

            last = value;
        }
    }
}
