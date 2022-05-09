using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 CONSOLE APP ASSIGNMENT PART TWO 
Add the following to your console app and perform these actions:
1. An infinite loop.
2. Save your code.
3. Fix the infinite loop so that it will execute properly.
4. Save and execute your code.
*/
namespace Iteration_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INFINITE LOOP
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            // PROPER LOOP
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
               
            }
            Console.ReadLine();
        }
    }
}
