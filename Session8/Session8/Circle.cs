using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
    class Circle : IMath
    {
        public const float PI = 3.14F;
        public float Radius;
        public double AreaOfCircle;

        public virtual void Area()
        {
            AreaOfCircle = (PI * Radius * Radius);
        }
    }

    
    
}
