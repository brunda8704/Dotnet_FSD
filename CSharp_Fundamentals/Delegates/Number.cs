using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Number
    {
        public delegate int NumberDelegate(int number1, int number2);
        public static int Display(int number1, int number2)
        {
            return number1 + number2;
        }

    }
}
