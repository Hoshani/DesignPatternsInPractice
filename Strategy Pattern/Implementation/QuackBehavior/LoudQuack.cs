using System;
using Strategy_Pattern.Interfaces;

namespace Strategy_Pattern.Implementation
{
    public class LoudQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("QUAAAAAAAACK");
        }
    }
}