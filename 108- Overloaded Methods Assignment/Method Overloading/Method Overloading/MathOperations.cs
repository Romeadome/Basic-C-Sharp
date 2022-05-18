using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class MathOperations
    {
        

        public int Operation(int integerInput)
        {
            Console.WriteLine("Performing math operation on integer...");
            Console.Write("{0} minus 69 equals ", integerInput);
            return integerInput - 69;
        }

        public int Operation(decimal decimalInput)
        {
            Console.WriteLine("Performing math operation on decimal..."); 
            Console.Write("{0} plus 4321 equals ", decimalInput);
            return (int)decimalInput + 4321;
        }
        public int Operation(string stringInput)
        {
            int numVal = 0;
            try
            {
                numVal = Int32.Parse(stringInput);
                Console.WriteLine("Performing math operation on string...");
                Console.Write("{0} times 5 equals ", numVal);


            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert {0} to integer.", stringInput);
            }
            return numVal * 5;

        }
    }
}
