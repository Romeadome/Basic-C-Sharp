using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 ASSIGNMENT
Perform these actions and create a console app that includes the following:
1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. 
The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.

2. In the Main() program, ask the user what number they want to do the math operations on.

3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.
*/
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
