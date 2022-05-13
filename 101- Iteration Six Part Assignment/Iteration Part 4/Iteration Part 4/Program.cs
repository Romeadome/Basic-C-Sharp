using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
CONSOLE APP ASSIGNMENT PART FOUR 
and if you want to understand the o=>o == input syntax better
Lambda expressions - C# reference
Learn about C# lambda expressions that are used to create anonymous functions.
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
basically it does foreach(o in animaltypes) if(o == input) return true;
https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.getrange?view=net-5.0

Add the following to your console app and perform these actions:
1. A list of strings where each item in the list is unique. 
2. Ask the user to input text to search for in the list. 
3. A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
4. Add code to the loop that tells a user if they put in text that isn’t in the list.
5. Add code to the loop that stops it from executing once a match has been found.
6. Save and execute your code.
*/
namespace Iteration_Part_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() { "Apples", "Oranges", "Pears", "Bananas", "Strawberries", "Peaches"};
            Console.WriteLine("Type a name of a fruit");
            string fruitInput = Console.ReadLine();
  
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruitInput.ToLower() == fruits[i].ToLower())
                {
                    Console.WriteLine("\"{0}\" was found in the list! Location: Index {1}", fruitInput, i);
                    break;
                }
                if (!fruits.Contains(fruitInput) && i == fruits.Count-1)
                {
                    Console.WriteLine("Sorry, \"{0}\" was not in the list. This program will now close.", fruitInput);
                }
            }
            Console.ReadLine();
        }
    }
}
