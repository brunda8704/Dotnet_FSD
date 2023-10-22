namespace GenericsDemo
{
    internal class Program
    {
        public static bool AreEqual<T>(T firstNumber, T secondNumber)
        {
            return firstNumber.Equals(secondNumber);
        }
        static void Main(string[] args)
        {
            bool IsEqual = Program.AreEqual<int>(10, 10);
            //bool IsEqual =Program.AreEqual<string>("ABC", "ABC");
            //bool IsEqual = Program.AreEqual<double>(10.5, 20.5);
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }

        }

    }
}