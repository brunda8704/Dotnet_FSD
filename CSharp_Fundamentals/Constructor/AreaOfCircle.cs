using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class AreaOfCircle
    {
        int radius;
        static float pi;

        static AreaOfCircle()
        {
            pi = 3.14f;
        }

        public AreaOfCircle(int radius)
        {
            this.radius = radius;
        }


        public float AreaDisplay()
        {
            return pi * radius * radius;
        }


        public float CircumferenceDisplay()
        {
            return 2 * pi * radius;
        }



    }
}
