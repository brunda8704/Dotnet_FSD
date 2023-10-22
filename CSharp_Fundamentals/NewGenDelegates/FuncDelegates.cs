using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGenDelegates
{
    internal class FuncDelegates
    {
        public static int Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Display()
        {
            Console.WriteLine("function with only return type");
            return 1;
        }

    }
}
