using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 CHALLENGE 
NOTE: To complete this challenge, you will need to do some online research on how to parse enums.
Perform these actions and create a console app that includes the following:
1. Create an enum for the days of the week.
2. Prompt the user to enter the current day of the week.
3. Assign the value to a variable of that enum data type you just created.
4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
*/
namespace EnumConsoleAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                
            Console.WriteLine("Enter the current day of the week:");
            string input = Console.ReadLine();
                if (input.Length > 1)
                {
                    input= char.ToUpper(input[0]) + input.Substring(1);
                }
            DaysOfTheWeek dayOfWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                Console.WriteLine("The current day of the week is {0}", dayOfWeek);

                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.WriteLine(ex.Message);
                Console.WriteLine("This program will now close.");
            }
            finally
            {
                
                Console.ReadLine();
            }
        }

public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
    }
}
