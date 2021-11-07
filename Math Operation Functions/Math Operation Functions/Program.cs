using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operation_Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            Math_Operation math = new Math_Operation();
            Console.WriteLine("Enter a number to perform a math operation on.");
            int input = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("{0} multiplied by {1} equals {2}.", input, input, math.Multiply(input));
            Console.WriteLine("The difference of {0} and {1} equals {2}.", 2 * input, input, math.Subtract(input));
            if (math.Divide(input) == 0)
            {
                Console.WriteLine("{0} divided by {1} equals {2}.", 3 * input, input, "undefined");
            }
            else
            {
                Console.WriteLine("{0} divided by {1} equals {2}.", 3 * input, input, math.Divide(input));
            }
            Console.ReadLine();

        }


    }
}
