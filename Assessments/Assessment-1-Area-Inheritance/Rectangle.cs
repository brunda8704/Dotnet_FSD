using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1_Area_Inheritance
{
    internal class Rectangle
    {
       private int length, breadth;
       public virtual void CalculateArea(int length, int breadth)
        {
            Console.WriteLine($"Area of rectangle is {length*breadth}");
        }
        
    }
}
