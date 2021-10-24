using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Hello my name is Roman Love.\n";
            string phrase2 = "I am practicing concatenating strings and using stringbuilder.\n";
            string phrase3 = "I hope this works as intended!\n";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hello! this is my attempt to use the stringbuilder function. ");
            sb.Append("Is this working?? ");
            sb.AppendLine("Wow! I can't believe this is going as intended!");
            Console.WriteLine(sb);
            Console.WriteLine(phrase.ToUpper() + phrase2.ToUpper() + phrase3.ToUpper());
            Console.ReadLine();
        }
    }
}
