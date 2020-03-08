using System;

namespace Singleton_Pattern
{
    public class Singleton
    {
        private static Singleton _singleton;
        public Singleton()
        {
        }

        public static Singleton GetObject()
        {
            return _singleton ??= new Singleton();
        }
    }
}