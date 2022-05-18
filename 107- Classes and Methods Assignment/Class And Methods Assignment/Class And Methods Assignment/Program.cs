using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Methods_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperation = new MathOperations();

            Console.WriteLine("Enter a number to do math operations on:");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} plus {1} equals {2}",input, input, mathOperation.Add(input));
            Console.WriteLine("{0} times {1} equals {2}", input, input, mathOperation.Multiply(input));
            Console.WriteLine("3 times {0} minus {1} equals {2}", input, input, mathOperation.Subtract(input));
            Console.ReadLine();
        }
    }
}
