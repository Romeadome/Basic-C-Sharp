using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. The program must start by printing “Anonymous Income Comparison Program” to the screen.
2. It must then print “Person 1” to the screen and get the following details:
•	Hourly Rate
•	Hours worked per week
3. It must then print “Person 2” to the screen and then get the following details:
•	Hourly rate
•	Hours worked per week
4. It must then print to the screen “Annual salary of Person 1:” and display the exact salary below it.
5. It must then print to the screen “Annual salary of Person 2:” and display the exact salary below it.
6. It must then print to the screen “Does Person 1 make more money than Person 2?” and write the true or false value of this statement below it.
*/
namespace Math_and_Comparision_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparision Program\n");
            Console.WriteLine("Person 1:\n");
            Console.WriteLine("What is your hourly rate?\n");
            decimal rate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nHow many hours you work a week?\n");
            int workHours1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPerson 2:\n");
            Console.WriteLine("What is your hourly rate?\n");
            decimal rate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nHow many hours you work a week?\n");
            int workHours2 = Convert.ToInt32(Console.ReadLine());

            decimal annualSal1 = (rate1 * workHours1) * 52;
            decimal annualSal2 = (rate2 * workHours1) * 52;
            /*
             The number after the C and N indicates upto how many decimals you need string formatted.
             C formats the number as a currency string, which includes a currency symbol, default symbol is "$', 
             you can use Culture Info as shown above for any other currency type.
            */
            Console.WriteLine("Annual salary of Person 1:\n{0}\n", annualSal1.ToString("C2"));
            Console.WriteLine("Annual salary of Person 1:\n{0}\n", annualSal2.ToString("C2"));

            Console.WriteLine("Does Person 1 make more money than Person 2?\nThe answer is {0}", annualSal1 > annualSal2);
            Console.ReadLine();
        }
    }
}
