using System.Drawing;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LSP - can substitute any instance of base class with any instance of sub classes.
            Shape rectangle = new Rectangle { length = 10, breadth = 10 };
            Shape square = new Square { Side = 10 };
            Console.WriteLine($"Area of rectangle: {rectangle.AreaCalculator()}");
            Console.WriteLine($"Area of Square: {square.AreaCalculator()}");
        }
    }
}