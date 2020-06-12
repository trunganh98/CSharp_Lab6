using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
    interface ISet
    {
        void AcceptDetails(int valOne, string valTwo);
    }

    interface IGet
    {
        void Display();
    }
}
