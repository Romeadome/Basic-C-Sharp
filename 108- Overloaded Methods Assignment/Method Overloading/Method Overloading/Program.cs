using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
ASSIGNMENT 
Perform these actions and create a console app that includes the following:
1. Create a class. In that class, create a method that will take in an integer,
   create a math operation for this integer (addition, subtraction, etc.),
   then return the answer as an integer.
2. In the Main() method of the console app, instantiate the class and call the 
   one method, passing in an integer. Display the result to the screen.
3. Add a second method to the class with the same name that will take in a 
   decimal, create a different math operation for it, then return the answer 
   as an integer.
4. In the Main() method of the console app, instantiate the class and call 
   the second method, passing in a decimal. Display the result to the screen.
5. Add a third method to the class, with the same name, that will take in a 
   string, convert it to an integer if possible, do a different math operation to 
   it, then return the answer as an integer.
 */
namespace Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperation = new MathOperations();


            Console.WriteLine("Input an integer:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} minus 69 equals {1}\n", input, mathOperation.Operation(input));

            Console.WriteLine("\nInput a decimal:");
            decimal input2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("{0} plus 4321 equals {1}\n",input2, mathOperation.Operation(input2));

            Console.WriteLine("\nInput a string:");
            string input3 = Console.ReadLine();
            Console.WriteLine("{0} times 5 equals {1}", input3,mathOperation.Operation(input3));

            Console.ReadLine();
        }
    }
}
