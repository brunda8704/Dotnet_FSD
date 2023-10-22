namespace RefAndOutKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            IncrementRef(ref firstNumber); //The variable must be initialized before it is passed to the method because the method expects a reference to an existing variable
            Console.WriteLine($"Ref: {firstNumber}");

            int secondNumber;
            IncrementOut(out secondNumber); //The variable does not need to be initialized before it is passed to the method because the method will assign a value to it.
            Console.WriteLine($"Out: {secondNumber}");

        }
        static void IncrementRef(ref int number)
        {
            number++;
        }

        static void IncrementOut(out int number)
        {
            number = 0;
            number++;
        }
    }
}