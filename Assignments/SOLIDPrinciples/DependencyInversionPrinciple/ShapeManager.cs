namespace DependencyInversionPrinciple
{
    //high level class
    public class ShapeManager
    {
        private IShape _shape;
        public ShapeManager(IShape shape)
        {
            _shape = shape;
        }
        public void PrintArea()
        {
            Console.WriteLine($"Area:{_shape.AreaCalculator()}");
        }
    }

}
