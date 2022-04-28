using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name2 = "Roman";
            string name1 = "Johnny";

            string result = name1.Length > name2.Length ? "The first name is a longer name than the second name" : "The second name is longer than the first name";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
