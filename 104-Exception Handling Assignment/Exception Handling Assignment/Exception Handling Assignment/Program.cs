using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
ASSIGNMENT 
Perform these actions and create a console app that includes the following:
1. Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop that takes each integer in the list, divides it by the number 
   the user entered, and displays the result to the screen.
2. Run the code, entering in non-zero numbers as the user. Look at the displayed results.
3. Run the code again, entering in zero as the number to divide by. Note any error messages you get.
4. Run the code once again, entering in a string as the number to divide by. Note any error messages you get.
5. Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program print a message to the display to let you know the 
   program has emerged from the try/catch block and continued on with program execution. In the catch block, display the error message to the screen. 
   Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after 
   the try/catch block gets executed.
*/

namespace Exception_Handling_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 };
                Console.WriteLine("Input a number to divide the numbers in the list");
                int input = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numbers.Count; i++)
                {
                    int dividedNum = numbers[i] / input;
                    Console.WriteLine("{0} divided by {1} equals {2}", numbers[i], input, dividedNum);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please only use whole numbers.");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please use a non-zero whole number.");
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try\\catch block and will now close.");
                Console.ReadLine();
            }
            
        }
    }
}
