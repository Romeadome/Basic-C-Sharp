using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operation_Functions
{
    public class Math_Operation
    {
        public int Multiply(int input)
        {
            int result = input * input;
            return result;
        }

        public int Subtract(int input)
        {
            int result = 2 * input - input;
            return result;
        }

        public int Divide(int input)
        {
            if (input == 0)
            {
                return 0;
            }
            else
            {
                int result = 3 * input / input;
                return result;
            }

        }
    }
}
