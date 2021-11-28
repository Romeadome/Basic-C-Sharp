using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. Create a class. In that class, create a method that takes two integers as parameters. 
   Make one of them optional. Have the method do a math operation and return an integer result.
2. In the Main() method of the console app, instantiate the class.
3. Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
4. Call the method in the class, passing in the one or two numbers entered.
5. Try various combinations of numbers on the code, including having no second number.
*/
namespace Overloaded_Optional_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math_Operation Operation = new Math_Operation();

            Console.Write("Enter first number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("(Optional) Enter a second number or leave blank: ");
            int input2;
            if (int.TryParse(Console.ReadLine(), out input2))
            {
                Console.WriteLine("{0} multiplied by {1} equals {2}.", input1, input2, Operation.Multiply(input1, input2));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} multiplied by 3 equals {1}.", input1, Operation.Multiply(input1));
                Console.ReadLine();
            }

        }
    }
}
