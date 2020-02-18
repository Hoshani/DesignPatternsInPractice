using System;
using Observer_Pattern.Interfaces;
using Observer_Pattern.Models;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IObservable weatherStation = new WeatherStation();

            IObserver ledDisplay = new LedDisplay(weatherStation);
            IObserver mobile = new Mobile(weatherStation);


            weatherStation.SetState(44);
        }
    }
}
