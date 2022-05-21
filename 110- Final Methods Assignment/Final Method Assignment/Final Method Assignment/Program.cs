using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Perform these actions and create a console app that includes the following:
1. Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.
2. In the Main() method, instantiate that class.
3. Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two. 
4. Create a method with output parameters.
5. Overload a method.
6. Declare a class to be static.
*/

namespace Final_Method_Assignment
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();
            //output variables from static method
            int num1;
            int result;

            Console.WriteLine("Enter a number to be divided by 2");
            int input = Convert.ToInt32(Console.ReadLine());
            //Takes input and divides by 2
            mathOperation.DivideBy2(input);

            //Overloaded method that takes 2 inputs and divides by 2
            mathOperation.DivideBy2(input,input);
            


            Add(out num1, out result);
           
            Console.ReadLine();
        }

        //Static method with output parameters
        public static void Add(out int num1, out int result)
        {
            num1 = 45;
            result = num1 + num1;
            Console.WriteLine("{0} plus its self equals {1}",num1, result);
        }

    }
}
