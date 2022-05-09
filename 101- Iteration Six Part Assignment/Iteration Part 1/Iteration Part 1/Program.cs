using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
CONSOLE APP ASSIGNMENT PART ONE 
Create a console app the does/contains the following:
1. A one-dimensional array of strings. 
2. Ask the user to input some text. 
3. A loop that iterates through each string in the array and adds the user's text input to the end of each string.
4. Then create a loop that prints off each string in the array on a separate line.
5. Save and execute your code.
*/

namespace Iteration_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] poem = 
                { 
                "A buzzlebop lives on a bumpy bubble over a bunk of babbling ",
                "A buzzlebop eats bumble bees that buzz, bunches of bananas, bamboo and buttered ",
                "A buzzlebop like to bamboozle babies, bite bark, and big black ",
                "A buzzlebop did a back flip wearing binoculars into a bicycle and bumped the ",
                "My buzzlebop bagged a bunch of balls and bounced them down the back of my "
            };
            Console.WriteLine("Be a part of my buzzlebop poem! \nEnter a singular noun that begins with the letter \"B\":");
            string input = Console.ReadLine();
            for (int i = 0; i < poem.Length; i++)
                Console.WriteLine(poem[i] + input + "s.");
            Console.ReadLine();                   
        }
    }
}
