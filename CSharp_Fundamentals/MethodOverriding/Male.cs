using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Male : Gender
    {
        public override void Display()
        {
            Console.WriteLine("Male child class");
        }
    }

}
