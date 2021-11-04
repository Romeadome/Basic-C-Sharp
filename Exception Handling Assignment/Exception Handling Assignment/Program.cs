using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Perform these actions and create a console app that includes the following:
1. Create a list of integers. Ask the user for a number to divide each number in the list by. 
2.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
3. Run the code, entering in non-zero numbers as the user. Look at the displayed results.
4. Run the code again, entering in zero as the number to divide by. Note any error messages you get.
5. Run the code once again, entering in a string as the number to divide by. Note any error messages you get.
6. Now put the loop in a try/catch block. Below and outside of the try/catch block, 
   make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution. 
7. In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string.
   Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
*/

namespace Exception_Handling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 987, 720, 350, 1457, 28786, 49435, 6967, 8645 };
                Console.WriteLine("Enter a number to divide each number in the list.");
                int userInput = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    int dividedNumber = number / userInput;

                    Console.WriteLine("{0} divided by {1} equals {2}", number, userInput, dividedNumber);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.\n");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type numbers only.\n");
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution.");
                Console.ReadLine();
            }



        }
    }
}
