namespace Assignment_5_Factors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Factors of a given number\n");
            do
            {
                Console.WriteLine("enter a number");
                int number = Convert.ToInt32(Console.ReadLine());  
                Console.WriteLine($"Factors of {number}:");
                Factors.Display(number);//function calling
                Console.WriteLine("\nDo you want to continue?(1/0)\n Press 1 for continue\n 0 for exit\n");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1);
        }
    }
}