namespace AnonymousMethodRealTimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = squareOfNumber(10);
            Console.WriteLine(result);
        }

        public static Func<int, int> squareOfNumber = delegate (int number)
        {
            return number * number;
        };

    }
}


    
