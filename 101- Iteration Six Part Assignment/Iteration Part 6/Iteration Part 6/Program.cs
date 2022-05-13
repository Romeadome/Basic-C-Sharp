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

            foreach (string animal in animals)
            {
                int count = 0;
                bool hasAppeared = false;
                for (int i = 0; i < animals.Count; i++)
                {
                    if (animal == animals[i])
                    {
                        Console.WriteLine(animal);
                        hasAppeared = true;
                        count++;
                    }
                    if (hasAppeared && count > 1)
                    {
                        Console.WriteLine("{0} has already appeared on the list", animal);
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
