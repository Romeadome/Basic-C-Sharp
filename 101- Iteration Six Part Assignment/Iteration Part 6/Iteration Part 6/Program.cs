using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
CONSOLE APP ASSIGNMENT PART SIX 
Add the following to your console app and perform these actions:
1. Create a list of strings that has at least two identical strings in the list. 
2. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
3. Save and execute your code.
 */
namespace Iteration_Part_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>() { "Cat", "Dog", "Ferret", "Cat", "Turtle", "Pig", "Snake", "Bird", "Hamster", "Horse", "Dog" };
            List<string> duplicates = new List<string>();
            int i = 1;
            foreach (string animal in animals)
            {
                if (duplicates.Contains(animal))
                {
                    Console.WriteLine(i + ". " + animal);
                    Console.WriteLine(animal + " already appeared in the list");
                }
                else
                {
                    Console.WriteLine(i + ". " + animal);
                    duplicates.Add(animal);
                }
                i++;
    
            }
            Console.ReadLine();
        }
    }
}
