using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] stringArray = {"One ", "Two ", "Three ", "Four ", "Five ", "Six "};

        Console.WriteLine("Input a string of text");
        string userInput = Console.ReadLine();

        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine(stringArray[i] + userInput);
        }
        Console.ReadLine();
    }
}
