using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 ASSIGNMENT 
Perform these actions and create a console app that includes the following:
1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property. 
*/
namespace OverloadedOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Roman", LastName = "Love", Id = 00031792};
            Employee employee2 = new Employee() { FirstName = "John" , LastName = "Smith", Id = 00102291};

            Console.WriteLine(employee.Id == employee2.Id);
            Console.ReadLine();

            
        }
    }
}
