using System;
using Decorator_Pattern.Interfaces;

namespace Decorator_Pattern.Models
{
    class DecoratorA : IDecorator
    {
        private int _state;
        public int State
        {
            get { return _state; }
            set { _state = value; }
        }

        public DecoratorA(IDecorator decorator)
        {
            _state = decorator.State + 5;
        }
    }
}