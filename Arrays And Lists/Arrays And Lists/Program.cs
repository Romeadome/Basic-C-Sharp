using System;
using System.Collections.Generic;//Used for creating lists
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
        {
        /*-------------------------------   list fundamentals---------------------------------*/

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);
        //you can create list for any kind of data type
        List<string> stringList = new List<string>();
        stringList.Add("Roman");
        stringList.Add("Hello");
        stringList.Remove("Hello");

        Console.WriteLine(stringList[0]);
        Console.WriteLine(intList[0]);
        Console.ReadLine();

        /*------------------------ARRAY FUNDAMENTALS----------------------------------------*/
        ////one approach to initialize array
        //    int[] numArray = new int[5];
        //    numArray[0] = 5;
        //    numArray[1] = 2;
        //    numArray[2] = 10;
        //    numArray[3] = 200;
        //    numArray[4] = 5000;
        ////second approach
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        ////third approach, easiest way
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        ////if u want to change an value in the index of the array
        //numArray2[5] = 650;
        //Console.WriteLine(numArray2[3]);
        //Console.ReadLine();

        }
    }

