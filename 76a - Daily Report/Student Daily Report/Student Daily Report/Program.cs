using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
A. The program must start by printing “The Tech Academy.”
B. The next line must be “Student Daily Report.”
C. You must ask and save your data according to its proper data type and with clearly labeled variables.
D. The DR must contain the following questions:
•	What is your name?
•	What course are you on?
•	What page number?
•	Do you need help with anything? Please answer “true” or “false.”
•	Were there any positive experiences you’d like to share? Please give specifics.
•	Is there any other feedback you’d like to provide? Please be specific.
•	How many hours did you study today?
E. After all of the questions are asked, print, “Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This is the end of the program.
*/
namespace Student_Daily_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"The Tech Academy\" \n\"Student Daily Report\" \nWhat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int page = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveFeedback = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specifc.");
            string positiveFeedback2 = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
