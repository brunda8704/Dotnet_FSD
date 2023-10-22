using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ComputerScience : Department
    {
        public ComputerScience() : base("Message from computerScience")
        {
            Console.WriteLine("I'm a child class");
        }
    }

}
