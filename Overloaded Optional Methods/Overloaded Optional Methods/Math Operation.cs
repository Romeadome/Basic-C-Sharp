using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloaded_Optional_Methods
{
    class Math_Operation
    {
        public int Multiply(int param1, int param2 = 3)
        {
           
            int result = param1 * param2;
            return result;
        }
    }
}
