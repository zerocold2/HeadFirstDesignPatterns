using System.Collections.Generic;

namespace DesignPatterns.Behavioral_Pattern.Observer
{
    /// <summary>
    /// The Concrete Subject
    /// </summary>
    public class WeatherData : ISubject
    {
        private float _temp;
        private float _humidity;
        private float _pressure;
        private List<IObserver> _listOfObservers;

        public WeatherData()
        {
            _listOfObservers = new List<IObserver>();
        }

        public float GetTemperature()
        {
            return _temp;
        }
        public float GetHumidity()
        {
            return _humidity;
        }
        public float GetPressure()
        {
            return _pressure;
        }


        public void Register(IObserver observer)
        {
            _listOfObservers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _listOfObservers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _listOfObservers)
            {
                observer.Update();
            }
        }
    }
}
