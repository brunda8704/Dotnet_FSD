namespace MethodHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths maths = new Maths();
            maths.PrintSubjectName();


            //parent class function
            // maths.GetPrintSubjectName();

            Subject subject = new Maths();

            Console.ReadLine();

        }
    }
}