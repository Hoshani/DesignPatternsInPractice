using System;
using Strategy_Pattern.Interfaces;

namespace Strategy_Pattern.Implementation
{
    public class NoWingsFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("...");
        }
    }
}