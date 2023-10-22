using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Square : Shape
    {
        public double Side { get; set; }
        public override double AreaCalculator()
        {
            return Side * Side;
        }
    }
}
