using ClassLibraryOne;
namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1 parameter
            //Employee emp1 = new Employee("Rakshith");
            //emp1.Display();

            ////2 parameter
            //Employee emp2 = new Employee("Rohith", "Sharma"); 
            //emp2.Show();


            ////Area of circle 
            //AreaOfCircle area = new AreaOfCircle(12);


            //float result = area.AreaDisplay();
            //Console.WriteLine("Area of circle= {0}", result);

            ////circumference
            //float circum= area.CircumferenceDisplay();
            //Console.WriteLine("Circumference of circle= {0}", circum);



            //CircleLibrary calling
            ClassOne classOne = new ClassOne(10);
            float circleLibrary1 = classOne.AreaDisplay();
            float circleLibrary2 = classOne.CircumferenceDisplay();

            Console.WriteLine("Area of circle= {0}", circleLibrary1);
            Console.WriteLine("Circumference of circle= {0}", circleLibrary2);


            Console.ReadLine();


        }
    }
}