namespace OptionalParameters
{
    internal class Program
    {
        static void Print(string firstName, string lastName, string age, string company = "UST") //default values must be assigned at last
        {
            Console.WriteLine("{0},{1},{2},{3}", firstName, lastName, age, company);
        }


        static void Main(string[] args)
        {
            Print("Akash", "Shetty", "25", "TCS");
            Print("Akash", "Shetty", "25");// here it takes default values

            Console.ReadLine();

        }

    }
}