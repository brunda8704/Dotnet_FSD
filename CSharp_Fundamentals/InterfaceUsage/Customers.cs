using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUsage
{
    internal class Customers : ICustomerOne, ICustomerTwo
    {
        public void CustomerOneMethod()
        {
            Console.WriteLine("inside customer1 method");
        }
        public void CustomerTwoMethod()
        {
            Console.WriteLine("inside customer2 method");
        }

        //if both interfaces has same method,explicitly call the method by
        // =>interface name.method name()
        void ICustomerOne.Print()
        {
            Console.WriteLine("ICustomer1 print method");
        }
        void ICustomerTwo.Print()
        {
            Console.WriteLine("ICustomer2 print method");
        }
    }

}
