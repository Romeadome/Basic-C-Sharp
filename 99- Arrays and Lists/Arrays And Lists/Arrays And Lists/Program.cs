using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Arrays_And_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5];
            numArray[0] = 1;
            numArray[1] = 20;
            numArray[2] = 300;    
            numArray[3] = 4000;
            numArray[4] = 500000;

            int[] numArray1 = new int[] { 1, 20, 300, 4000, 5000};
            Console.WriteLine(numArray1[3]);
            Console.Write(numArray[4]);
            Console.ReadLine();
            
        }
    }
}
