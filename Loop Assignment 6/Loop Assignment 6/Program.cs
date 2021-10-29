using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Add the following to your console app and perform these actions:
1. Create a list of strings that has at least two identical strings in the list. 
2. Create a foreach loop that evaluates each item in the list, and displays a
message showing the string and whether or not it has already appeared in the list.
3. Save and execute your code.

 */
namespace Loop_Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>() { "Cat", "Dog", "Bird", "Turtle", "Hamster", "Ferret", "Bird", "Snake", "Spider", "Bird" };
            Console.WriteLine("Search for type of animal:");
            string userInput = Console.ReadLine();
            int count = 0;

            foreach (string animal in animals)
            {
                if (userInput.ToUpper() == animal.ToUpper())
                {
                    int index = 1;
                    foreach (string animal2 in animals)
                    //for (int k = 0; k < animals.Count; k++)
                    {
                        if (userInput.ToUpper() == animal2.ToUpper())
                        {
                            Console.WriteLine("Animal \"{0}\" was found. This appears {1} time(s) in the list.", animal2, index);
                            index++;
                        }
                        
                    }
                    break;
                }
                count++;
                if (count >= animals.Count)
                {
                    Console.WriteLine("Your animal does not exist in the list");
                }
            }
            Console.Read();
        }
    }
}
