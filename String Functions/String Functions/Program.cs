using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //// the main sequences are \n, \t, \" and \\
            //string name = "Roman";
            //string quote = "\"I can do all things through Christ!\"";

            //bool trueOrFalse = name.Contains("s");
            //bool trueOrFalse2 = name.EndsWith("n");
            //int length = name.Length;
            //name = name.ToUpper();
            //name = name.ToLower();

            ////strings are immutable
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(trueOrFalse2);
            //Console.WriteLine(length);
            //Console.Read();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Roman");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
