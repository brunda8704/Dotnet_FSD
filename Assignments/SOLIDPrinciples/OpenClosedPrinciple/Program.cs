using System.Drawing;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle { length = 20, breadth = 10 };
            Circle circle = new Circle { Radius = 10 };

            Shape[] shapes = { rectangle, circle };
            AreaCalculator areaCalculator = new AreaCalculator();
            double totalArea = areaCalculator.TotalArea(shapes);
            Console.WriteLine($"Total area: {totalArea}");
        }
    }
}