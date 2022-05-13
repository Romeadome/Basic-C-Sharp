using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
CONSOLE APP ASSIGNMENT PART FIVE 
Add the following to your console app and perform these actions:
1. A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list. 
2. Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.
3. Add code to the loop that tells a user if they put in text that isn’t in the list.
4. Save and execute your code.
*/

namespace Iteration_Part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Roman", "John", "Marc", "Steven", "Jake", "Khonshu", "Roman" };
            Console.WriteLine("Enter a name to search in the list: ");
            string searchedName = Console.ReadLine();
            bool nameFound = false;
            for (int j = 0; j < names.Count; j++)
            {
                for (int k = 0; k < names.Count; k++)
                {
                    if (searchedName.ToLower() == names[j].ToLower())
                    {
                        Console.WriteLine("\"{0}\" found! At indice {1}",names[j], j );
                        nameFound = true;
                        break;
                    }
                }
                if (j == names.Count-1 && nameFound == false)
                {
                    Console.WriteLine("\"{0}\" was not found in the list, this program will now close.", searchedName);
                }
            }
            Console.ReadLine();
        }
    }
}
