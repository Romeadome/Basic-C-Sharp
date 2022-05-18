using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Make a program that takes 2 dumbers and divide

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number:");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number:");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two numbers...");
                int number3 = number1 / number2;
                Console.WriteLine("{0} divided by {1} equals {2}", number1, number2, number3);

                Console.ReadLine();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by zero.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
