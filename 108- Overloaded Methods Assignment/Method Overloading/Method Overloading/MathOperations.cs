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
            Console.WriteLine("\nPerforming math operation on integer...");
            return integerInput - 69;
        }

        public decimal Operation(decimal decimalInput)
        {
            Console.WriteLine("\nPerforming math operation on decimal..."); 
            return decimalInput + 4321;
        }
        public int Operation(string stringInput)
        {
            int stringInput2Int;
            int result = 0;
            try
            {
                Console.WriteLine("\nPerforming math operation on string...");
                stringInput2Int = Int32.Parse(stringInput);
                result = stringInput2Int * 5;
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert {0} to integer.", stringInput);
            }
            return result;
        }
    }
}
