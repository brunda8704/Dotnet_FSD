using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    //A class can inherit only 1 abstract class
    internal class Car : Vehicle//,AbstractClass   
    {
        public override int GetNumWheels()
        {
            return 4;
        }

        public override string GetEngineType()
        {
            return "Petrol";
        }
    }
}
