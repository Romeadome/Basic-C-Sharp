using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Exception handling allows you to put custom messages for your error messages and help with logging in a database
namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a second number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dividing the two numbers.......");
                int number3 = number1 / number2;
                Console.WriteLine("{0} divided by {1} equals {2}", number1, number2, number3);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            catch (Exception ex)
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
