using System;
using Decorator_Pattern.Interfaces;

namespace Decorator_Pattern.Models
{
    class DecoratorB : IDecorator
    {
        private int _state;
        public int State
        {
            get { return _state; }
            set { _state = value; }
        }

        public DecoratorB(IDecorator decorator)
        {
            _state = decorator.State + 1;
        }
    }
}