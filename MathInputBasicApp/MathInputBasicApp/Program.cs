using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathInputBasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            long convertInput = Convert.ToInt64(input);
            long multiplied = convertInput * 50;
            long added = convertInput + 25;
            double divided = convertInput / 12.5;
            long modulo = convertInput % 7;
            Console.WriteLine("Your input multiplied by 50 is: " + multiplied);
            Console.WriteLine("Your input plus twenty-five is: " + added);
            Console.WriteLine("Your input divided by 12.5 is: " + divided);
            bool boolResult = convertInput >= 50;
            Console.WriteLine("Your input being greater than 50 is: " + boolResult);
            Console.WriteLine("You remainder of your input divided by 7 is: " + modulo);
            Console.ReadLine();
        }
    }
}
