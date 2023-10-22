namespace Assignment_5_SumOfNaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Sum of n natural numbers\n");
            do
            {
                Console.WriteLine("enter the target number");
                int targetNumber = Convert.ToInt32(Console.ReadLine());

                int sum = NaturalNumbers.SumOfNaturalNumbers(targetNumber);//method calling
                Console.WriteLine($"Sum of {targetNumber} natural number is {sum}");

                Console.WriteLine("Do you want to continue?(1/0)\n Press 1 for continue\n 0 for exit\n");
                option= Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1);
        }
    }
}