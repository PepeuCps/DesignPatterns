namespace _02_observer_weatherstation.System_IObserver
{    
    public struct Temperature
    {
        private float temp;
        private DateTime tempDate;

        public Temperature(float temperature, DateTime dateAndTime)
        {
            this.temp = temperature;
            this.tempDate = dateAndTime;
        }

        public float Degrees
        { get { return this.temp; } }

        public DateTime Date
        { get { return this.tempDate; } }
    }
}
