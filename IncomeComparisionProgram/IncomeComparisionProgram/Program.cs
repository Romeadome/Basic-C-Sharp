using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparision Program");
            Console.WriteLine("Person 1");

            Console.Write("Hourly Rate: ");
            string hourlyRate = Console.ReadLine();
            decimal decHourlyRate = Convert.ToDecimal(hourlyRate);

            Console.Write("Hours worked per week: ");
            string hoursWorked = Console.ReadLine();
            int intHoursWorked = Convert.ToInt32(hoursWorked);

            Console.WriteLine("Person 2");

            Console.Write("Hourly Rate: ");
            string hourlyRate2 = Console.ReadLine();
            decimal decHourlyRate2 = Convert.ToDecimal(hourlyRate2);

            Console.Write("Hours worked per week: ");
            string hoursWorked2 = Console.ReadLine();
            int intHoursWorked2 = Convert.ToInt32(hoursWorked2);

            
            decimal salary1 = decHourlyRate * intHoursWorked * 52;
            Console.WriteLine("Annual Salary of Person 1:\n " + salary1);
            decimal salary2 = decHourlyRate2 * intHoursWorked2 * 52;
            Console.WriteLine("Annual Salary of Person 1:\n " + salary2);
            bool isOneMoreThanTwo = salary1 > salary2;
            Console.WriteLine("Does Person 1 make more money than Person 2? \n" + isOneMoreThanTwo);
            Console.ReadLine();
        }
    }
}
