using _02_observer_weatherstation.Interfaces;

namespace _02_observer_weatherstation
{
    public class WeatherDataProvider : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Provider Subject: Registered an observer.");
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Provider Subject: Removed an observer.");
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Provider Subject: Notifying observers...");
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void MeasurementsChanged()
        {
            this.NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            Console.WriteLine("Provider Subject: My data has changed to: " + _temperature + "ºC and " + _humidity + "% humidity and Pressure " + _pressure);

            MeasurementsChanged();
        }

        public float GetTemperature()
        {
            return _temperature;
        }

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }
    }
}
