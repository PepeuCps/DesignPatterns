using _02_observer_weatherstation.Interfaces;

namespace _02_observer_weatherstation
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            if (_weatherData.GetType() == typeof(WeatherDataProvider))
        {
                WeatherDataProvider wd = (WeatherDataProvider)_weatherData;
                Console.WriteLine("CurrentConditionsDisplay - Current Conditions: " + wd.GetTemperature() + "ºC and " + wd.GetHumidity() + "% humidity");
            }
        }

        public void Update(ISubject subject)
        {
            Console.WriteLine("CurrentConditionsDisplay.Update");
            _weatherData = subject;
            this.Display();
        }

        public void RemoveObserver()
        {
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("CurrentConditionsDisplay.RemoveObserver");
            Console.WriteLine("****************************************");
            Console.WriteLine();
            _weatherData.RemoveObserver(this);
        }
    }
}
