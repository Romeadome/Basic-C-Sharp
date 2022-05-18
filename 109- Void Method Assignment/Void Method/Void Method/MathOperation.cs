using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method
{
    internal class MathOperation
    {
        public void Add(int num1, int num2)
        {
           int result = num1 + num1;
           Console.WriteLine("{0} plus {1} equals {2}",num1, num1, result);
           Console.WriteLine("The value of the second number is {0}",num2);
        }
    }
}
