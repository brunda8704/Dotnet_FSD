using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Circle:Shape
    {
        public double Radius { get; set; }
        static double pi = 3.14;
        public override double CalculateArea()
        {
            double area = pi * Radius * Radius;
            Console.WriteLine($"Area of square: {area}");
            return area;
        }
    }
}
