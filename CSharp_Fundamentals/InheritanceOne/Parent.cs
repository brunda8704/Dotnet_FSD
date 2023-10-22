using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOne
{
    internal class Parent
    {
        public int number = 10;
        public void Display()
        {
            Console.WriteLine(number);
        }

        static int number1 = 20;

        //static function
        public static void Show()
        {
            Console.WriteLine(number1);
        }

    }
}
