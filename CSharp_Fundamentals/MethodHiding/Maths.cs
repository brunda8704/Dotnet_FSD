using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MethodHiding
{
    //child class

    class Maths : Subject
    {
        public new void PrintSubjectName() //"new" keyword is to hide parent function purpose fully 
        {
            Console.WriteLine("I'm from child");
        }


        // to get parent class functions from child
        public void GetPrintSubjectName()
        {
            base.PrintSubjectName();
        }

    }

}
