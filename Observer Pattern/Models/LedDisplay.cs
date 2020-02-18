using System;
using Observer_Pattern.Interfaces;

namespace Observer_Pattern.Models
{
    public class LedDisplay : IObserver
    {
        private IObservable _weatherStation;
        
        public LedDisplay(IObservable observable)
        {
            _weatherStation = observable;
            _weatherStation.Add(this);
        }

        public void Update(int newState)
        {
            Console.WriteLine($"From Led Display: Update {newState} Received");
        }
    }
}