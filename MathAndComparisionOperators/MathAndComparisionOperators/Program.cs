using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //addition
            //int total = 5 + 10;
            //int othertotal = 12 + 22;
            //int combined = total + othertotal;
            //console.writeline("five plus ten = " + total.tostring());
            //console.writeline(combined);
            //console.readline();

            //subtraction
            //int difference = 10 - 5;
            //console.writeline("ten minus five = " + difference.tostring());
            //console.readline();

            //multiplication
            //int product = 10 * 5;
            //console.writeline(product);
            //console.readline();

            //quotient
            //double quotient = 100.0 / 17.0;
            //console.writeline(quotient);
            //console.readline();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //int output = 200 / 3;
            //Console.WriteLine(output);
            //Console.ReadLine();

            //bool trueOrfalse = 12 > 5;
            //Console.WriteLine(trueOrfalse.ToString());

            int roomTemperature = 72;
            int currentTemperature = 75;

            bool isWarm =currentTemperature >= roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
