using System;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Singleton.GetObject();
            var y = Singleton.GetObject();
            if (x == y)
            {
                System.Console.WriteLine("Singleton");
            }
            else
            {
                System.Console.WriteLine("ERROR");
            }
        }
    }
}
