using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Method_Assignment
{
     class MathOperation
    {
        public void DivideBy2(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine("{0} divided by 2 equals {1}", num1, result);
        }

        public void DivideBy2(int num1, int num2)
        {
            int result = (num1+(num2+5)) / 2;
            Console.WriteLine("{0} plus {1} divided by 2 equals {2}", num1,num2+5, result);
        }


    }
}
