using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOne
{
    public class ClassOne
    {
        int radius;
        static float pi;

        static ClassOne()
        {
            pi = 3.14f;
        }

        public ClassOne(int radius)
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
