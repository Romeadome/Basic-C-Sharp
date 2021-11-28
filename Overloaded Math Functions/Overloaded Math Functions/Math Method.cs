using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloaded_Math_Functions
{
    public class Math_Method
    {
      
        public int Math(int input)
        {
            int result = 3*input * input;
            return result;
        }
        public int Math(decimal input)
        {
            int result = Decimal.ToInt32(input) + Decimal.ToInt32(input);
            return result;
        }
        public int Math(string input)
        {
            int result = Int32.Parse(input) * Int32.Parse(input);
            return result;
        }


    }
}
