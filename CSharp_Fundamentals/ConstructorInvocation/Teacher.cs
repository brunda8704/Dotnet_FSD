using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInvocation
{
    internal class Teacher
    {
        // static constructor
        static Teacher()
        {
            Console.WriteLine("Static constructor of teacher");
        }

        // Non-static constructor
        public Teacher() : base()
        {
            Console.WriteLine("Non-static constructor of teacher");
        }

    }
}
