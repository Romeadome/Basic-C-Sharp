using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Add the following to your console app and perform these actions:
1. A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list. 
2. Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.
3. Add code to the loop that tells a user if they put in text that isn’t in the list.
4. Save and execute your code.
*/
namespace Loop_Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>() { "Cat", "Dog", "Bird", "Turtle","Rooster", "Hamster", "Ferret", "Bird", "Snake", "Spider", "Bird", "Rooster" };
            Console.WriteLine("Search for type of animal:");
            string userInput = Console.ReadLine();
            int count = 0;

            foreach (string animal in animals)
            {
                if (userInput.ToUpper() == animal.ToUpper())
                {
                    int index = 0;
                    foreach (string animal2 in animals )
                    //for (int k = 0; k < animals.Count; k++)
                    {
                         if (userInput.ToUpper() == animal2.ToUpper()) 
                        {
                            Console.WriteLine("Animal \"{0}\" was found at index: {1}", animal2, index);
                        }
                        index++;
                    }
                    break;
                }
                count++;
                if (count == animals.Count)
                {
                    Console.WriteLine("Your animal does not exist in the list");
                }
            }
            Console.Read();
        }
    }
}
