using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Add the following to your console app and perform these actions:
1. A list of strings where each item in the list is unique. 
2. Ask the user to input text to search for in the list. 
3. A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
4. Add code to the loop that tells a user if they put in text that isn’t in the list.
5. Add code to the loop that stops it from executing once a match has been found.
6. Save and execute your code.*/

class Program
{
    static void Main(string[] args)
    {


        List<string> animals = new List<string>() { "Cat", "Dog", "Bird", "Turtle", "Hamster", "Ferret" };
        Console.WriteLine("Search for type of animal:");
        string userInput = Console.ReadLine();
        int count = 0;

        foreach (string animal in animals)
        {
            if (userInput.ToUpper() == animal.ToUpper())
            {
             
                Console.WriteLine("Index of \"{0}\" was found! at index: {1}", animal, count);
                break;
            }
            count++;
            if(count == animals.Count )
            {
                Console.WriteLine("Your animal does not exist in the list");
            }
            
        }


        Console.ReadLine();
    }

}

