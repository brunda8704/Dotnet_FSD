namespace VarKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //must be initialized at the time of declaration 
            //var value;
            var someValue = "hello";
            Console.WriteLine($"Type-> {someValue.GetType()} and value->{someValue}");

        }
    }
}