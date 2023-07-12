namespace _02_observer_weatherstation.System_IObserver
{
    public class TemperatureAlertObserver : IObserver<Temperature>
    {
        private IDisposable _unsubscriber;
        
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
            Console.WriteLine("AlertObserver - Completed - Additional temperature data will not be transmitted.");
        }

        public virtual void OnError(Exception error)
        {
            Console.WriteLine("AlertObserver Error");
        }

        public virtual void OnNext(Temperature value)
        {
            if(value.Degrees > 30)
                Console.WriteLine("AlertObserver - The temperature is higher than 30°C - Is {0}°C at {1:g} - Drink water", value.Degrees, value.Date);
        }
    }
}
