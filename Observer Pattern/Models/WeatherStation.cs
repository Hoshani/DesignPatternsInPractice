using System;
using System.Collections.Generic;
using System.Linq;
using Observer_Pattern.Interfaces;

namespace Observer_Pattern.Models
{
    public class WeatherStation : IObservable
    {
        private int _currentState = 25;

        private List<IObserver> _notifyList = new List<IObserver>();

        public WeatherStation()
        {

        }

        public void Add(IObserver observer)
        {
            _notifyList.Add(observer);
            observer.Update(_currentState);
        }

        public void GetState()
        {
            Console.WriteLine("current");
        }

        public void Notify()
        {
            if (_notifyList.Any())
            {
                foreach (var item in _notifyList)
                {
                    item.Update(_currentState);
                }
            }
        }

        public void Remove(IObserver observer)
        {
            _notifyList.Remove(observer);
        }

        public void SetState(int newState)
        {
            _currentState = newState;
            Notify();
        }
    }
}