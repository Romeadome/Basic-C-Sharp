using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Array_Project
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] stringArray = { "Roman", "Jesse", "John", "Sally", "Elizabeth", "Beth" };
               Console.WriteLine("Select an index value between 0 and 5 of the string array: ");
               int stringIndex = Convert.ToInt32(Console.ReadLine());
            while (stringIndex > 5 || stringIndex < 0 )
            {
                Console.WriteLine("Error! Value doesn't exist!");
                Console.WriteLine("Select an index value between 0 and 5 of the string array: ");
                stringIndex = Convert.ToInt32(Console.ReadLine());
            }

            int[] intArray = { 40, 35, 5060, 110, 334, 6000 };
            Console.WriteLine("Select an index value between 0 and 5 of the int array:");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            while (intIndex > 5 || intIndex < 0)
            {
                Console.WriteLine("Error! Value doesn't exist!");
                Console.WriteLine("Select an index value between 0 and 5 of the int array: ");
                intIndex = Convert.ToInt32(Console.ReadLine());
            }

            List<string> stringList = new List<string>();
            stringList.Add("Roman");
            stringList.Add("Hello");
            stringList.Add("Today is the day");
            stringList.Add("Goodbye");
            Console.WriteLine("Select an index value between 0 and 3 of the string list:");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            while (listIndex > 3 || listIndex < 0)
            {
                Console.WriteLine("Error! Value doesn't exist!");
                Console.WriteLine("Select an index value between 0 and 3 of the string list: ");
                intIndex = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The value inputted for the string array was: " + stringIndex + " This resulted a output string of: "
                + stringArray[stringIndex] + "\n");
            Console.WriteLine("The value inputted for the int array was: " + intIndex + " This resulted a output string of: "
                + intArray[intIndex] + "\n");
            Console.WriteLine("The value inputted for the string array was: " + listIndex + " This resulted a output string of: "
                + stringList[listIndex] + "\n");
            Console.Read();
        }
    }
}
