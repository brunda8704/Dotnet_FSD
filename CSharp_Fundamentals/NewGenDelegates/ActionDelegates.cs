using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGenDelegates
{
    internal class ActionDelegates
    {
        public static void Display()
        {
            Console.WriteLine("Display method");

        }

        public static void Show(string message)
        {
            Console.WriteLine(message);
        }

        public static void ShowDetails(int number, string name)
        {
            Console.WriteLine(number + " " + name);

        }

    }
}
