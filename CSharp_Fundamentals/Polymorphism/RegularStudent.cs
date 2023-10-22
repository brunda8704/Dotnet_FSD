using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class RegularStudent : Student
    {

        //this values will not be printed
        public string firstName = "Akshay";
        public string lastName = "Shetty";
        public void PrintStudentName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

}
