using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name,
    as well as an Id. At least two employees should have the first name "Joe".
2. Using a foreach loop, create a new list of all employees with the first name "Joe".
3. Perform the same action again, but this time with a lambda expression.
4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
*/
namespace LambaExpressionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a list of at least 10 employees

            List<Employee> employees = new List<Employee>
            {
                new Employee() { FirstName = "Roman", LastName = "Love", EmployeeID = 01 },
                new Employee() { FirstName = "Jane", LastName = " Doe", EmployeeID = 02 },
                new Employee() { FirstName = "John", LastName = " Smith", EmployeeID = 03 },
                new Employee() { FirstName = "Joe", LastName = " Rogan", EmployeeID = 04 },
                new Employee() { FirstName = "Sally", LastName = " Benson", EmployeeID = 05 },
                new Employee() { FirstName = "Ron", LastName = " Adams", EmployeeID = 06 },
                new Employee() { FirstName = "Joe", LastName = " Coffman", EmployeeID = 07 },
                new Employee() { FirstName = "Peter", LastName = " Griffin", EmployeeID = 08 },
                new Employee() { FirstName = "Bobby", LastName = " Buey", EmployeeID = 09 },
                new Employee() { FirstName = "Ashley", LastName = " Coates", EmployeeID = 10 }
            };

            //Using a foreach loop to create a list of all employees with the first name "Joe"
            Console.WriteLine("Employees with the name starting with \"Joe\"....");
            foreach (Employee employee in employees)
            {                       
                
                if (employee.FirstName == "Joe")
                {

                    Console.WriteLine(employee.FirstName + employee.LastName);
                }
            }

            //Performing a lambda expression to make a list of all employees with an ID greater than 5
            List<Employee> newList = employees.Where(x => x.EmployeeID > 5).ToList();
            Console.WriteLine(newList);
            Console.WriteLine("\nEmployees ID's greater than 5....");
            foreach (Employee employee in newList)
            {

                Console.WriteLine(employee.FirstName + employee.LastName + ", Badge ID: " + employee.EmployeeID);
            }
            Console.ReadLine();

        }
    }
}
