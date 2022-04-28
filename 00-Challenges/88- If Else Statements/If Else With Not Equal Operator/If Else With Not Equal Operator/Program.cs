using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Else_Statements_With_Not_Equals_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

             if (name != "Roman")
            {
                Console.WriteLine("Your name is not Roman");
            }
            if (name == "John")
            {
                Console.WriteLine("Your name is John");
            }

            else if (name == "Roman")
            {
                Console.WriteLine("Your name is Roman");
            }            
            
            else if (name == "Sam")
            {
                Console.WriteLine("Sam...that's a pretty common name.");
            }
            else 
            {
                Console.WriteLine("What kind of name is that?");
            }
            Console.ReadLine();
        }
    }
}
