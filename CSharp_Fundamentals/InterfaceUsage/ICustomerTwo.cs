using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUsage
{
    public interface ICustomerTwo:ICustomerOne
    {
        void CustomerTwoMethod();
        void Print();

    }
}
