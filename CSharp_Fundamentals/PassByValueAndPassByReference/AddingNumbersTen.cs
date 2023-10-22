using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValueAndPassByReference
{
    internal class AddingNumbersTen
    {
        public void Display(ref int number)
        {
            number = number + 10;
            //Console.WriteLine("Variable value inside display method: " + number);
        }

    }
}
