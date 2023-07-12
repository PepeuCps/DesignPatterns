using _02_observer_weatherstation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_observer_weatherstation
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private ISubject _weatherData;
        private float _maxTemp;
        private float _minTemp;
        private float _sumTemp;
        private int _numReadings;

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);

            _minTemp = float.MaxValue;
            _maxTemp = float.MinValue;
            _numReadings = 0;
        }

        public void Update(ISubject subject)
        {
            if (subject.GetType() == typeof(WeatherDataProvider))
            {
                Console.WriteLine("StatisticsDisplay.Update");
                _weatherData = subject;
                WeatherDataProvider wd = (WeatherDataProvider)subject;

                float temp = wd.GetTemperature();
                if (temp < _minTemp)
                    _minTemp = temp;

                if (temp > _maxTemp)
                    _maxTemp = temp;

                _sumTemp += temp;
                _numReadings++;

                this.Display();
            }
        }

        public void Display()
        {
            WeatherDataProvider wd = (WeatherDataProvider)_weatherData;
            Console.WriteLine(String.Format("StatisticsDisplay - Temperature Min/Max/Avg: {0}/{1}/{2}", _minTemp, _maxTemp, (_sumTemp / _numReadings)));
        }
    }
}
