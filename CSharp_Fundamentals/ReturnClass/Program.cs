namespace ReturnClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DetailsOne detailsOne = new DetailsOne(10, 20);
            DetailsTwo detailsTwo = detailsOne.Display();
            Console.WriteLine(detailsTwo.firstNumber);
            Console.WriteLine(detailsTwo.secondNumber);

        }
    }
}