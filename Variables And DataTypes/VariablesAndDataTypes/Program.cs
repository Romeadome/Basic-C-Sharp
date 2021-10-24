using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourname = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourname);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //Console.WriteLine("Your favorite number is: " + favoriteNumber + "\n");

            //Console.WriteLine("What is your favorite number?");
            //string secondFavoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(secondFavoriteNumber);
            //int plus10 = favNum + 10;
            //Console.WriteLine("Your favorite number plus 10 is: " + plus10);
            //Console.ReadLine();


            bool isStudying = false;
            // btye is 0 - 255
            byte hoursWorked = 42;
            // sbyte (signed byte) is -128 to 127
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.30202292;

            // float is 7 decimals in length
            float secondsLeft = 2.62f;

            short temperatureOnMars = -341;

            string myName = "Jesse";

            int currentAge = 29;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();
            Console.WriteLine(questionMark);
            Console.ReadLine();

        }
    }
}
