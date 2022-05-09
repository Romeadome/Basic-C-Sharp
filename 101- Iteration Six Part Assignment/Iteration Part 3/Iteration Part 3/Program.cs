using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
CONSOLE APP ASSIGNMENT PART THREE 
Add the following to your console app and perform these actions:
1. A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
2. Save and execute your code.
3. A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
4. Save and execute your code.
*/
namespace Iteration_Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i*10);
            }

            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine(j*5);
            }
            Console.ReadLine();
        }
    }
}
