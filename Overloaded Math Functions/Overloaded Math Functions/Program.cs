using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloaded_Math_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Math_Method operation = new Math_Method();
            //int method1 = ;
            Console.WriteLine(operation.Math(6));
            Console.WriteLine(operation.Math(4.5m));
            Console.WriteLine(operation.Math("5"));
            Console.ReadLine();
        }
    }
}
