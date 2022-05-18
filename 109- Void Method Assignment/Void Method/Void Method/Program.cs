using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();

            mathOperation.Add(num1: 22, num2: 345);
            Console.ReadLine();

        }
    }
}
