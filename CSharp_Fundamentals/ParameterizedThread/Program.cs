namespace ParameterizedThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ParameterizedThread!");
            Program program = new Program();
            Thread thread = new Thread(program.Display);
            thread.Start();
        }
        void Display(object input)
        {

        }

    }
}