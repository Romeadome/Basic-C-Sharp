using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).
2. Takes an input from the user, adds 25 to it, then prints the result to the console.
3. Takes an input from the user, divides it by 12.5, then prints the result to the console.
4. Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
5. Takes an input from the user, divides it by 7, then prints the remainder to the console (tip: think % operator).
*/

namespace User_Input_Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("{0}, please enter a number.", name);
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} multiplied by {1}, equals {2}.",input, 50, input*50);
            Console.WriteLine("{0} plus {1} equals {2}.", input,25, input+25);
            Console.WriteLine("{0} divided by {1} equals {2}.", input,12.5,input/12.5);
            Console.WriteLine("Is {0} greater than {1}? The answer is {2}", input, 50, input > 50);
            Console.WriteLine("The remainder of {0} divided by {1} is {2}", input, 7, input % 7);
            Console.ReadLine();
        }
    }
}
