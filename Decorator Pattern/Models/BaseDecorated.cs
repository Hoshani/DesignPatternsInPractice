using System;
using Decorator_Pattern.Interfaces;

namespace Decorator_Pattern.Models
{
    class BaseDecorated : IDecorator
    {
        private int _state;
        public int State
        {
            get { return _state; }
            set { _state = value; }
        }

        public BaseDecorated()
        {
            _state = 3;
        }
        
    }
}