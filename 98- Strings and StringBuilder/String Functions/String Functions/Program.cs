using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Roman";
            string quote = "The man said \"Hello\" Roman. \nHello on a new line. \n\tHello on a tab";
            string fileName = @"C:\Users\Jesse";

            string concatenate1 = "This string" + " is concatenated" + " in three places";
            string concatenate2 = "and it added to a appended String builder" + " to demonstrate" + " it's usefulness";
            string concatenate3 = "coding is " + "sure" + " fun.";

            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.EndsWith("n");
            int lenth = name.Length;
            name = name.ToUpper();

            //string builder is a dynamic object that allows you to change the string in memory
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(concatenate1);
            sb.AppendLine(concatenate2);
            sb.AppendLine(concatenate3);
            Console.WriteLine(sb);

            Console.WriteLine(name);
            Console.WriteLine(lenth);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(quote);
            Console.ReadLine();
        }
    }
}
