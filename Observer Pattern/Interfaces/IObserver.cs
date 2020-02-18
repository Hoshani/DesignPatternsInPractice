using System;

namespace Observer_Pattern.Interfaces
{
    public interface IObserver
    {
        void Update(int newState);
    }
}