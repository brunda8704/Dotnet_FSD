using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_SumOfNaturalNumbers
{
    internal class NaturalNumbers
    {
        public static int SumOfNaturalNumbers(int targetNumber)
        {
            int sum = 0;
            for (int i = 1;i <=targetNumber; i++)
            { 
                sum += i;
            }
            return sum;    
        }
    }
}
