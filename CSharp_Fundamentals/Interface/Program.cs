namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface");
            Student student = new Student();
            student.Print();
            student.Display();//here we can see both interface & class methods

            IStudent student1 = new Student();
            student1.Print();// here we will see only interface methods

        }
    }
}