using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
    class Sphere : Circle
    {
        public double _areaOfSphere;
        public override void Area()
        {
            base.Area();
            _areaOfSphere = (AreaOfCircle * 4);
        }
    }
}
