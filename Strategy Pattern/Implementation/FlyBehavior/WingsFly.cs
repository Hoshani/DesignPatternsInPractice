using System;
using Strategy_Pattern.Interfaces;

namespace Strategy_Pattern.Implementation
{
    public class WingsFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("WHOOOSH");
        }
    }
}