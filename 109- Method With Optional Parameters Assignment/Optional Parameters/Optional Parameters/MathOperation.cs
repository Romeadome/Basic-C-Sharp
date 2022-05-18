using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    internal class MathOperation
    {
        public int Multiply(int a,int b = 25 )
        {
            return a * b;
        }
    }
}
