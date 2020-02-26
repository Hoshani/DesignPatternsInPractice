using System;
using Decorator_Pattern.Interfaces;
using Decorator_Pattern.Models;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDecorator decorator = new BaseDecorated();
            IDecorator decoratorA = new DecoratorA(decorator);
            IDecorator decoratorB = new DecoratorB(decoratorA);

            Console.WriteLine(decoratorB.State);
        }
    }
}
