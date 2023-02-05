using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 C# DATA TYPES 
•	decimal: represents any number up to 28 or 29 digits in length. Its 128-bit length makes it very precise and perfect for anything related to money.

NOTE: The “m” doesn’t stand for million: it’s a required suffix character for decimal data types to help the compiler differentiate it from other similar types.

•	double: represents any number up to 15 or 16 digits in length.
 
•	float: represents any number up to 7 digits in length.

NOTE: To differentiate between other numbers that utilize decimals, an “f” is required immediately following the value of any float.

The difference between float, double, and decimal is a difference of size: 
a. Float (32-bits), 
b. Double (64-bits)
c. Decimal (128-bits)

•	int: represents a whole number between roughly -2,000,000,000 and 2,000,000,000.
 
•	uint (unsigned integer): represents a whole number between 0 and about 4,000,000,000.

•	long: represents a whole number between roughly negative 9 quintillion (-9,000,000,000,000,000,000) and positive 9 quintillion (9,000,000,000,000,000,000).
    The long data type is the 64-bit version of int (which is 32-bits).

•	ulong (unsigned long): represents a whole number between 0 and 18 quintillion (18,000,000,000,000,000,000).
    The ulong data type is the 64-bit version of uint (which is 32-bits).

•	short: represents a whole number between -32,678 and 32,767.
    The short data type is the 16-bit version of int.

•	ushort (unsigned short): represents a whole number between 0 and 65,535.
    The ushort data type is the 16-bit version of uint.

•	string: represents a set of 0 or more Unicode characters. Strings are delimited by double-quotation marks.

•   byte: represents an integer between 0 and 255.
 
•	sbyte (signed byte): represents an integer between -128 and 127.

 
CASTING 

a. Convert.ToBool(myNumber);
b. Convert.ToString(myNumber);
c. Convert.ToInt32(myNumber); 
*/
namespace Variables_And_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ctrl + k + c to comment
            // ctrl + k + u to uncomment
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //Console.WriteLine("Your favorite number is: " + favoriteNumber + 7);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int convertFav = Convert.ToInt32(favoriteNumber);
            //int total = convertFav + 10;
            //Console.WriteLine("Your favorite number plus 10 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;

            byte hoursWorked = 42;

            sbyte currentTemperature = -23;

            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimenters = 211.3020202;

            float secondsLeft = 2.4534f;

            short temperatureOnMars = -243;

            int currentAge = 30;

            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

            Console.WriteLine(questionMark);
            Console.ReadLine();
        }
    }
}
