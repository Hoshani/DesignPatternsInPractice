using System;
using Strategy_Pattern.Interfaces;

namespace Strategy_Pattern.Models
{
    public class Duck : IDuck
    {
        IQuackBehavior _quackBehavior;
        IFlyBehavior _flyBehavior;
        string _name;

        public Duck(string name, IQuackBehavior quackbehavior, IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackbehavior;
            _name = name;
        }

        public void ShowOff()
        {
            Console.WriteLine("this is my duck");
            Console.WriteLine($"I call it {_name}");
            Console.WriteLine("wanna hear it quack?");
            this._quackBehavior.Quack();
            Console.WriteLine("wanna see it fly?");
            this._flyBehavior.Fly();
        }

    }
}