using static Delegates.Employee;
using static Delegates.Number;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=>Delegate is a type safe function pointer
            //=> It is a reference type variable that holds the reference to a method
            Console.WriteLine("***Delegates***");
            EmployeeDelegate1 employeeDelegate1 = new EmployeeDelegate1(Display);
            employeeDelegate1();

            EmployeeDelegate2 employeeDelegate2 = new EmployeeDelegate2(Show);
            employeeDelegate2("hello");

            NumberDelegate numberDelegate = new NumberDelegate(Display);
            int output = numberDelegate(10, 12);
            Console.WriteLine(output);


        }
    }
}