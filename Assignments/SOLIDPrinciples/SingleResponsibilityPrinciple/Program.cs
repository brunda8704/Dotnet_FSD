namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = 10.5;
            double breadth = 5.0;
            RectangleArea rectangleArea = new RectangleArea();
            double area = rectangleArea.AreaOfRectangle(length, breadth);

            AreaPrinter areaPrinter = new AreaPrinter();
            areaPrinter.PrintArea(area);
        }
    }
}