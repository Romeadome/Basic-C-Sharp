using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConsoleAssignment
{
    internal class Employee : Person , IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            SayName();
            Console.WriteLine("Are you sure you want to quit {0} {1}?", FirstName, LastName);
        }


    }
}
