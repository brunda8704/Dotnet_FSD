using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class AreaCalculator
    {
        public double TotalArea(Shape[] shapes)
        {
            double totalArea = 0;
            foreach (Shape shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }
            return totalArea;
        }
    }
}
