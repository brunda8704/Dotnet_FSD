using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_Factors
{
    internal class Factors
    {
        public static int Display(int number)
        {
            for (int i = 1; i<=number; i++)
            {
                if(number%i==0)
                {
                    Console.Write(i +"\t");
                }
            }
            return number;
        }
    }
}
