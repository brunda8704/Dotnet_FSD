using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Rectangle:Shape
    {
        public double length { get; set; }
        public double breadth { get; set; }
        public override double CalculateArea()
        {
            double area = length * breadth;
            Console.WriteLine($"Area of square: {area}");
            return area;
        }
    }
}
