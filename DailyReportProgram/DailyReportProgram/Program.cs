using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\n" + "Student Daily Report\n");
            Console.Write("What is your name? ");
            string yourName = Console.ReadLine();
            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine();
            Console.Write("What page number are you on? ");
            string pageNumber = Console.ReadLine();
            int page = Convert.ToInt32(pageNumber);
            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\". ");
            string needHelp = Console.ReadLine();
            bool answer = Convert.ToBoolean(needHelp);
            Console.Write("Were there any positive experiences you'd like to share? Please give us specifics. ");
            string positiveResponse = Console.ReadLine();
            Console.Write("Is there any other feedback you'd like to provide? Please be specific. ");
            string feedback = Console.ReadLine();
            Console.Write("How many hours did you study? Numeric values only: ");
            string hoursStudied = Console.ReadLine();
            int studyHours = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.\n"
                + "Have a great day!");
            Console.Read();
        }
    }
}
