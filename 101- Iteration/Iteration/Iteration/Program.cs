using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> testScores = new List<int>() { 98, 99 , 12, 74, 23, 99};
            List<int> passingScores = new List<int>() { };

            foreach (int score in testScores)
            {
                if(score > 85)
                {
                    Console.WriteLine("This is a passing score: {0}",score);
                    passingScores.Add(score);
                }
            }
            Console.WriteLine("{0} people passed.", passingScores.Count);
            Console.ReadLine();
            //-------------------------------------------------------------------------------------------------------------------------------
            //List<string> names = new List<string>() { "Jesse", "Erik", "Roman", "Donald"};

            //foreach (string name in names)
            //{
                
               
            //        Console.WriteLine(name);
                
            //}
            //Console.ReadLine();
            //-----------------------------------------------------------------------------------------------------------------------------
            //List<int> testScores = new List<int>();
            //testScores.Add(1);
            //testScores.Add(98);
            //testScores.Add(95);
            //testScores.Add(71);
            //testScores.Add(70);
            //testScores.Add(99);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: {0}",score);
            //    }
            //}
            //Console.ReadLine();
            
            //------------------------------------------------------------------------------------------------------------------------
            //string[] names = { "Erik", "Tommy", "Roman", "Daniel" };

            //for (int j = 0; j < names.Length; j++)
            //{
             
            //        Console.WriteLine(names[j]);
                
            //}
            //Console.ReadLine();
            //----------------------------------------------------------------------------------------------------------------------
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("You Passed with a score of {0}", testScores[i]);

            //    }
            //}
            //Console.ReadLine();
        }
    }
}
