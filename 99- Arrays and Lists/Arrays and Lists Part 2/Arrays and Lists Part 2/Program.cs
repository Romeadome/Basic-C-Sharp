using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Arrays_And_Lists_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Add(20);
            intList.Remove(20);

            List<string> stringList = new List<string>();
            stringList.Add("Hello World");

            Console.WriteLine(intList[0]);
            Console.ReadLine();












            //int[] numArray = new int[5];
            //numArray[0] = 1;
            //numArray[1] = 20;
            //numArray[2] = 300;
            //numArray[3] = 4000;
            //numArray[4] = 500000;

            //int[] numArray1 = new int[] { 1, 20, 300, 4000, 5000 };

            ////easiest method to create array
            //int[] numArray2 = { 2, 4, 56, 456, 32 };

            //numArray2[3] = 3049;

            //Console.WriteLine(numArray2[3]);
            //Console.Write(numArray[4]);
            //Console.ReadLine();



        }
    }
}
