using System;
using Observer_Pattern.Interfaces;

namespace Observer_Pattern.Models
{
    public class Mobile : IObserver
    {
        private IObservable _weatherStation;
        
        public Mobile(IObservable observable)
        {
            _weatherStation = observable;
            _weatherStation.Add(this);
        }
        
        public void Update(int newState)
        {
            Console.WriteLine($"From Mobile: Update {newState} Received");
        }
    }
}