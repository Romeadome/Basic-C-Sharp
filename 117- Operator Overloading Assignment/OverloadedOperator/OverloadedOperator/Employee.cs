using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOperator
{
    internal class Employee : Person
    {
        public int Id { get; set; }

        public static int operator ==(Employee id1, Employee id2)
        {

            return id1 == id2;
        }
        public static int operator !=(Employee id1, Employee id2)
        {

            return id1 != id2;
        }
    }
}
