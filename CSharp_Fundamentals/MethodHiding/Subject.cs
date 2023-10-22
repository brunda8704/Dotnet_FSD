using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    internal class Subject
    {
        string subjectHandler = "Akaash";


        //private Subject()                //if we create parent class constructor as private-> child class can't inherit
        //{
        //}

        public void PrintSubjectName()
        {
            Console.WriteLine(subjectHandler);
        }

    }
}
