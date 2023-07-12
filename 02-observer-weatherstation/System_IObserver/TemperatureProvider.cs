namespace _02_observer_weatherstation.System_IObserver
{
    public class TemperatureProvider : IObservable<Temperature>
    {
        private List<IObserver<Temperature>> _observers;
        private List<Temperature> _temperatures;

        private float _lastTemperature;

        public TemperatureProvider()
        {
            _observers = new List<IObserver<Temperature>>();
            _temperatures = new List<Temperature>();
        }

        public IDisposable Subscribe(IObserver<Temperature> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);


            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);

                foreach (var item in _temperatures)
                {
                    observer.OnNext(item);
                }
            }

            return new Unsubscriber(_observers, observer);
        }

        public void SetMeasurements(float temperature, DateTime date)
        {
            if (_lastTemperature != temperature)
            {
                Console.WriteLine("TemperatureProvider: My data has changed to: " + temperature + "ºC at " + date.ToString("dd/MM/yyyy"));

                Temperature tempData = new Temperature(temperature, date);
                _temperatures.Add(tempData);

                foreach (var observer in _observers)
                    observer.OnNext(tempData);

                _lastTemperature = temperature;
            }
            else
            {
                Console.WriteLine("TemperatureProvider: Temperature not changed");
            }
        }

        public void ClearMeasurements()
        {
            _temperatures.Clear();
        }
    }
}
