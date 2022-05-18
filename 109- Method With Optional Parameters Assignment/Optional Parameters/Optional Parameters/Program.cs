using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Perform these actions and create a console app that includes the following:
1. Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. 
   Have the method do a math operation and return an integer result.
2. In the Main() method of the console app, instantiate the class.
3. Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
4. Call the method in the class, passing in the one or two numbers entered.
5. Try various combinations of numbers on the code, including having no second number.
*/
namespace Optional_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation twoNumbers = new MathOperation();

            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the a second number (This is optional).");
            int num2;
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                int result = twoNumbers.Multiply(num1, num2);
                Console.WriteLine("{0} times {1} equals {2}", num1, num2,result);
                Console.ReadLine();
            }
            else
            {
                int result = twoNumbers.Multiply(num1);
                Console.WriteLine("{0} times {1} equals {2}",num1,result);
                Console.ReadLine();
            }
        }
    }
}
