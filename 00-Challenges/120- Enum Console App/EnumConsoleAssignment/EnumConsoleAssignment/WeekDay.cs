using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumConsoleAssignment
{
    internal class WeekDay
    {
        public void DayOfWeek(string input)
        {
            try
            {


                if (input.Length > 1)
                {
                    input = char.ToUpper(input[0]) + input.Substring(1);
                }
                DaysOfTheWeek dayOfWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                Console.WriteLine("The current day of the week is {0}", dayOfWeek);


            }
            catch (Exception ex)
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
