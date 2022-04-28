using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number is your birthday month?");
            int birthday = Convert.ToInt32(Console.ReadLine());
            switch (birthday)
            {
                case 1:
                    Console.WriteLine("Your birth month is Janurary");
                    break;
                case 2:
                    Console.WriteLine("Your birth month is Feburary");
                    break;
                case 3:
                    Console.WriteLine("Your birth month is March");
                    break;
                case 4:
                    Console.WriteLine("Your birth month is April");
                    break;
                case 5:
                    Console.WriteLine("Your birth month is May");
                    break;
                case 6:
                    Console.WriteLine("Your birth month is June");
                    break;
                case 7:
                    Console.WriteLine("Your birth month is July");
                    break;
                case 8:
                    Console.WriteLine("Your birth month is August");
                    break;
                case 9:
                    Console.WriteLine("Your birth month is September");
                    break;
                case 10:
                    Console.WriteLine("Your birth month is October");
                    break;
                case 11:
                    Console.WriteLine("Your birth month is November");
                    break;
                case 12:
                    Console.WriteLine("Your birth month is December");
                    break;

                    // input = 3
                    // Outputs "Your birth month is March

            }
            Console.ReadLine();
        }
    }
}
