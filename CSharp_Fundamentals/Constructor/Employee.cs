using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Employee
    {
        string empFirstName, empLastName;

        //constructor with 1 parameter
        public Employee(string firstname)
        {
            empFirstName = firstname;
        }

        public void Display()
        {
            Console.WriteLine("Employee Name is {0}", empFirstName);
        }



        //constructor with 2 parameters
        public Employee(string firstname, string lastname)
        {
            empFirstName = firstname;
            empLastName = lastname;
        }

        public void Show()
        {
            Console.WriteLine("Employee Name is {0} {1}", empFirstName, empLastName);
        }


    }
}
