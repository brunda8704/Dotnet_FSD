namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract class Demo!");

            Car car = new Car();
            Console.WriteLine($"Car has {car.GetNumWheels()} wheel and of type {car.GetEngineType()}");


            Bus bus = new Bus();
            Console.WriteLine($"Bus has {bus.GetNumWheels()} wheel and of type {bus.GetEngineType()}");

        }
    }
}