using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Department
    {
        public Department()
        {
            Console.WriteLine("I'm a parent class");
        }

        public Department(string message)
        {
            Console.WriteLine(message);
        }

    }
}
