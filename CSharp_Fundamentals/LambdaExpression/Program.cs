namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lamda Expression!");

            Action action = () => Console.WriteLine("Dotnet");
            action();

            Action<string> action1 = (string message) => Console.WriteLine(message);
            action1("hiii");

            Func<int, int, int> func = (int firstNumber, int secondNumber) => firstNumber + secondNumber;
            int addition = func(10, 20);
            Console.WriteLine(addition);

            Predicate<string> predicate = (message) => true;
            bool result = predicate("hello");

            Predicate<int> predicate1 = (int number) =>
            {
                if (number == 1)
                {
                    return true;
                }
                return false;

            };
            bool output = predicate1(1);

        }
    }
}