namespace PassByValueAndPassByReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 20;
            Console.WriteLine("Variable value before calling the display method: " + value);

            AddingNumbersTen addingNumbersTen = new AddingNumbersTen();
            addingNumbersTen.Display(ref value);
            Console.WriteLine("Variable value after calling the display method: " + value);

            Console.ReadLine();

        }
    }
}