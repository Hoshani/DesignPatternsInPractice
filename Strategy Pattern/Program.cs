using System;
using Strategy_Pattern.Interfaces;
using Strategy_Pattern.Models;
using Strategy_Pattern.Implementation;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDuck mySpecialDuck = new Duck(nameof(mySpecialDuck), new MuteQuack(), new NoWingsFly());
            mySpecialDuck.ShowOff();

            Console.WriteLine("a new challenger is approaching!");
            IDuck farFetched = new Duck(nameof(farFetched), new LoudQuack(), new WingsFly());
            farFetched.ShowOff();

        }
    }
}
