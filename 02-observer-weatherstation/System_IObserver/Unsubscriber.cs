namespace _02_observer_weatherstation.System_IObserver
{
    public class Unsubscriber : IDisposable
    {
        private List<IObserver<Temperature>> _observers;
        private IObserver<Temperature> _observer;

        public Unsubscriber(List<IObserver<Temperature>> observers, IObserver<Temperature> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (!(_observer == null)) _observers.Remove(_observer);
        }
    }
}
