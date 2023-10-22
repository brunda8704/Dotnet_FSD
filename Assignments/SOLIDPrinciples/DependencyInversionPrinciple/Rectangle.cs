using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Rectangle : IShape
    {
        public double length { get; set; }
        public double breadth { get; set; }
        public double AreaCalculator()
        {
            return length * breadth;
        }
    }

}
