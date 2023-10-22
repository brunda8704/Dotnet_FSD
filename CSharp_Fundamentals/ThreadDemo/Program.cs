namespace ThreadDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started!");
            Thread threadOne = new Thread(Display)
            {
                Name = "Thead One"
            };
            threadOne.Start();
            
            Thread threadTwo = new Thread(Show);
            threadTwo.Start();
            Console.WriteLine("Main thread ended!");
        }

        static void Display()
        {
            Console.WriteLine("Display method started using " + Thread.CurrentThread.Name);
            Console.WriteLine("Display method");
        }

        static void Show()
        {
            Thread.Sleep(1000); 
            Console.WriteLine("Show method");
        }
    }
}