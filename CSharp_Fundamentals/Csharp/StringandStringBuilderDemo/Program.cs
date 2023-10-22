using System.Text;

namespace StringandStringBuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Employee.firstName);
            Console.WriteLine(Employee.lastName);

            StringBuilder stringValue = new StringBuilder(10);
            stringValue.Append("hello,");
            stringValue.Append("Team");
            Console.WriteLine(stringValue.ToString());
        }
    }
}