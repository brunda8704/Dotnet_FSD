using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1_Area_Inheritance
{
    internal class Square:Rectangle
    {
        private int sideLength;
        public override void CalculateArea(int sideLength)
        {
            Console.WriteLine($"Area of Square is {sideLength*sideLength}");
        }

    
    }
}
