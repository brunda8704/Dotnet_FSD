using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Employee
    {
        public delegate void EmployeeDelegate1();
        public delegate void EmployeeDelegate2(string input);
        public static void Display()
        {
            Console.WriteLine("Display method");
        }

        public static void Show(string message)
        {
            Console.WriteLine($"{message} from show method");
        }

    }
}
