using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_MobileManagement
{
    internal class Validation
    {

        public static void CheckValidName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new MobileException("enter a valid name");
            }
        }

        public static void CheckValidDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new MobileException("enter a valid description");
            }
        }

        public static void CheckValidManufacturedBy(string manufacturedBy)
        {
            if (string.IsNullOrEmpty(manufacturedBy))
            {
                throw new MobileException("enter a valid manufacturer name");
            }
        }

        public static void CheckValidPrice(double price)
        {
            if (double.IsNaN(price) || price<=0)
            {
                throw new MobileException("enter a valid price");
            }
        }
            
            
      

    }

    public class MobileException:Exception
    {
        public MobileException (string message) : base(message)
        { 
        }
    }
}
