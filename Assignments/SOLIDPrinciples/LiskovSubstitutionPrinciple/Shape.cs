using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Shape
    {
        public virtual double AreaCalculator()
        {
            return 0;
        }
    }
}
