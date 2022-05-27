using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Perform these actions and create a console app that includes the following:
1. Make the Employee class take a generic type parameter.
2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
3. Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things.
4. Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things.
5. Create a loop that prints all of the Things to the Console.
*/
namespace GenericsConsoleAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "Roman", "John", "Sally", "Matt", "Bobby" };

            Employee<int> daysWorked = new Employee<int> ();
            daysWorked.Things = new List<int>() { 45, 46, 204, 220, 553 };

            for (int i = 0; i < daysWorked.Things.Count; i++)
            { 
            Console.WriteLine("Employee: {0}", employee.Things[i]);
            Console.WriteLine ("Days Worked: {0}\n",daysWorked.Things [i]);
            }
              Console.ReadLine();  
        }
    }
}
