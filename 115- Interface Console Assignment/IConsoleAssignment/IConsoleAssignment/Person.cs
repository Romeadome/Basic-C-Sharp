using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConsoleAssignment
{
    internal abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Welcome {0} {1}\n", FirstName, LastName);
        }
    }
}
