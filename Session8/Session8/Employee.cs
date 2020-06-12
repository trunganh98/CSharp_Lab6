using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
    class Employee :ISet
    {
        int _empID;
        string _empName;
        public void AcceptDetails(int valOne, string valTwo)
        {
            _empID = valOne;
            _empName = valTwo;
        }
    }
}
