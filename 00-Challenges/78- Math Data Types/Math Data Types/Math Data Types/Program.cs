using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Add two numbers and display the output in the console.
2. Subtract two numbers and display the output in the console.
3. Multiply two numbers and display the output in the console.
4. Divide two numbers and display the output in the console.
*/

namespace MathDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 45;
            int num2 = 23;
            int addTotal = num1 + num2;
            int subTotal = num1 - num2;
            int multiplyTotal = num1 * num2;
            decimal divideTotal = num1 / (decimal)num2;
            Console.WriteLine("{0} plus {1} equals {2}.", num1, num2, addTotal);
            Console.WriteLine("{0} minus {1} equals {2}.", num1, num2, subTotal);
            Console.WriteLine("{0} times {1} equals {2}.", num1, num2, multiplyTotal);
            Console.WriteLine("{0} didived by {1} equals {2}.", num1, num2, Math.Round(divideTotal, 3));
            Console.ReadLine();
        }
    }
}
