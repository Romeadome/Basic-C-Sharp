using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Your assignment is to build a welcome screen for new accounting software your company is developing.
REQUIREMENTS:
•	When the program is run, Welcome to Acme Accounting Systems is printed to the console.
•	Below that, Remember, we’re “accounting” on you! is printed to the console.
*/

namespace Acme_Accounting_Systems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Acme Accounting Systems \nRemember, we're \"accounting\" on you!");
            Console.ReadLine();
        }
    }
}
