using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword
{
    internal class Elephant:Animal
    {
        string color = "black";

        public void showColor()
        {
            Console.WriteLine(base.color);
            //Console.WriteLine(color);
        }

    }
}
