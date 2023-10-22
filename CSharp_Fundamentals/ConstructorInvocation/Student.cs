using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInvocation
{
   
        class Student : Teacher
        {
            // static constructor
            static Student()
            {
                Console.WriteLine("Static constructor of student");
            }

            // Non-static constructor
            public Student()
            {
                Console.WriteLine("Non-static constructor of student");
            }

       // private Student() { }
        private Student(string name)
        { 
        }

        private Student(string name,string message)
        {
        }
    }

    
}
