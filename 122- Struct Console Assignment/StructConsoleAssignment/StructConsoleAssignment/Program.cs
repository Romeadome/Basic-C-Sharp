﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
ASSIGNMENT 
Perform these actions and create a console app that includes the following:
1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.
2. In the Main() method, create an object of data type Number and assign an amount to it.
3. Print this amount to the console.
*/
namespace StructConsoleAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 12345.6m;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
