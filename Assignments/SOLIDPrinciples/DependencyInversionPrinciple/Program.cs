namespace DependencyInversionPrinciple
{
    internal class Program
    {
        //High level classes should not depend on low level classes instead both should depend upon abstraction.
        //Abstraction should not depend upon details infact details should depend upon abstraction
        static void Main(string[] args)
        {
            var circle = new Circle { Radius = 3 };
            var circleManager = new ShapeManager(circle);
            circleManager.PrintArea();

            var rectangle = new Rectangle { length = 10, breadth = 2 };
            var rectangleManager = new ShapeManager(rectangle);
            rectangleManager.PrintArea();

        }
    }
}