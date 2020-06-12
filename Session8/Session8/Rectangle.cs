using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
    class Rectangle : ICalculate
    {
        float _length;
        float _breadth;
        public Rectangle(float valOne, float valTwo)
        {
            _length = valOne;
            _breadth = valTwo;
        }

        public double Area()
        {
            return _length * _breadth;
        }

    }
}
