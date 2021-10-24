using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            ////evaluates to false
            Console.WriteLine(true && false);
            //evaluates to true
            Console.WriteLine(true && true);
            //evaluates to false
            Console.WriteLine(false && false);
            //evalutes to true
            Console.WriteLine(true || false);
            //evaluates to true
            Console.WriteLine(true || true);
            //evaluates to false
            Console.WriteLine(false || false);
            //evaluates true
            Console.WriteLine(false || true);
            //evaluates true
            Console.WriteLine(true == true);
            //evaluates false
            Console.WriteLine(true == false);
            //false
            Console.WriteLine(false == false);
            //evaluates false
            Console.WriteLine(true != true);
            //evaluates true
            Console.WriteLine(true != false);
            //evaluates false
            Console.WriteLine(false != false);
            //evaluates false
            Console.WriteLine(true ^ true);
            //evaluates true
            Console.WriteLine(true ^ false);
            //evaluatesfalse
            Console.WriteLine(false ^ false);

            /*The XOR (^) operator will evaluates to true if one is true but not both */


            Console.ReadLine();
        }
    }
}
