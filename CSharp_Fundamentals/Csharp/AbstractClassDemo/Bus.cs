using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Bus : Vehicle
    {
        public override int GetNumWheels()
        {
            return 8;
        }

        public override string GetEngineType()
        {
            return "Diesel";
        }
    }
}
