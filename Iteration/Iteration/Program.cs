using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {

        /*-------------------INT ARRAY----------------------------------------*/
        //int[] testScores = {98, 99 , 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing Test Score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        /*--------------------------- STRING ARRAY---------------------------------*/
        //string[] names = { "Jesse", "Sally", "Bob", "Rome", "Erik", "Adam" };

        //for (int i = 0; i< names.Length; i++)
        //{
        //    if (names[i] == "Jesse")
        //    {
        //        Console.WriteLine(names[i]);
        //    }
        //}
        //Console.ReadLine();
        ///*---------------------LIST int ITERATION----------------------------------------*/

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);
        //testScores.Add(45);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing Test Score: " + score);
        //    }
        //}
        //Console.ReadLine();

        /*--------------------------list string interation---------------------------------------*/

        //List<string> names = new List<string>() { "Roman", "Jesse", "Adam", "Erik", "Sally" };

        //    foreach (string name in names)

        //{
        //    if (name == "Jesse")
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        //Console.ReadLine();

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine();
    }
}
