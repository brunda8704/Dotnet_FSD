using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public double AreaCalculator()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
