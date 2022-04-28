using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 BRANCHING ASSIGNMENT 
Your job is to create a console-based application for getting a shipping quote for a package.
REQUIREMENTS:
1. The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
2. The user must then be prompted for the package weight.
3. If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.
4. The user must then be prompted for the package width.
5. Then the package height.
6. Then the package length.
7. If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
8. Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.
9. The result of that calculation is the quote.
10. Display the quote to the user as a dollar amount.
For example: 
Welcome to Package Express. Please follow the instructions below.
Please enter the package weight:
40
Please enter the package width:
10
Please enter the package height:
 12
Please enter the package length:
 11
Your estimated total for shipping this package is: $528.00
Thank you!

 */
namespace Branching_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"Welcome to Package Express. Please follow the instructions below.\"\n");
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            string weightResult = weight > 50.0 ? "\"Package too heavy to be shipped via Package Express. Have a good day.\"" : "Please enter the package width:";
            Console.WriteLine(weightResult);
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            double quote = weight * (width * length * height) / 100;

            string dimensions = width + height + length > 50 ? "\"Package too big to be shipped via Package Express.\"" : "Your estimated total for shipping this package is "
                + quote.ToString("C2");
            Console.WriteLine(dimensions);
            Console.ReadLine();
        }
    }
}
