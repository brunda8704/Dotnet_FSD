using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Rectangle : Shape
    {
        public double length { get; set; }
        public double breadth { get; set; }

        public override double AreaCalculator()
        {
            return length * breadth;
        }
    }
}
