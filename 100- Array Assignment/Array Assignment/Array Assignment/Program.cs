using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = {"Roman", "Sally", "John", "Ruth", "Adam","Mike"};
            Console.WriteLine("Input an index from the string array (Between 0 - 5)");
            int selection = Convert.ToInt32(Console.ReadLine());
            bool isSelection = selection <= 5 && selection >= 0;

            while (!isSelection)
            {
                Console.WriteLine("You typed {0}, try again.", selection);
                Console.WriteLine("Input an index from the integer array (Between 0 - 5)");
                selection = Convert.ToInt32(Console.ReadLine());
                if (selection <= 5 && selection >= 0)
                { 
                   isSelection = true; 
                }

            }
            Console.WriteLine("The string at index {0} is \"{1}\"\n", selection, stringArray[selection]);


            int[] intArray = { 45, 1023, 4939, -20349, 365, 43023 };
            Console.WriteLine("Input an index the integer array (Between 0 - 5)");
            int selection2 = Convert.ToInt32(Console.ReadLine());
            isSelection = selection2 <= 5 && selection2 >= 0;

            while (!isSelection)
            {
                Console.WriteLine("You typed {0}, try again.", selection2);
                Console.WriteLine(" an index of the string array (Between 0 - 5)");
                selection2 = Convert.ToInt32(Console.ReadLine());
                if (selection2 <= 5 && selection2 >= 0)
                {
                    isSelection = true;
                }
            }
            Console.WriteLine("The integer at index {0} is {1}\n", selection2, intArray[selection2]);

            List<string> list = new List<string>();
            list.Add("Hello there!");
            list.Add("This is a random string of text");
            list.Add("John AppleSeed");
            list.Add("Roman is here to help!");
            list.Add("nice to meet you!");
            list.Add("Have a nice day");
            Console.WriteLine("Input an index the string list array (Between 0 - 5)");
            int selection3 = Convert.ToInt32(Console.ReadLine());
            isSelection = selection3 <= 5 && selection3 >= 0;
            while (!isSelection)
            {
                Console.WriteLine("You typed {0}, try again.", selection2);
                Console.WriteLine("Input an index of the string array (Between 0 - 5)");
                selection3 = Convert.ToInt32(Console.ReadLine());
                if (selection3 <= 5 && selection3 >= 0)
                {
                    isSelection = true;
                }
            }
            Console.WriteLine("The string at index {0} is \"{1}\"", selection3, list[selection3]);
            Console.Read();
            //do
            //{
            //    Console.WriteLine("You selected {0}, try again.", selection);
            //    Console.WriteLine("Select an index of the Array (Between 0 - 5)");
            //    selection = Convert.ToInt32(Console.ReadLine());
            //}
            //while (!isSelection);
            //Console.WriteLine("The string at index {0} is {1}",selection,stringArray[selection]);

            //int[] intArray = { 45, 1023, 4939, -20349, 365, 43023 };
            //Console.WriteLine("Select an index of the Array (Between 0 - 5)");
            //int selection2 = Convert.ToInt32(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine("You selected {0}, try again.", selection2);
            //    Console.WriteLine("Select an index of the Array (Between 0 - 5)");
            //    selection2 = Convert.ToInt32(Console.ReadLine());
            //}
            //while (!isSelection);
            //Console.WriteLine("The integer at index {0} is {1}", selection2, intArray[selection2]);
            //Console.Read();

        }
    }
}
