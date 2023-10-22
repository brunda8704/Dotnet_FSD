namespace Assignment_4_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("*******Checks if a given string is palindrome or not******\n");
            do
            {
                Console.WriteLine("Enter the String");
                Palindrome.Display();

                Console.WriteLine("Do you want to continue?(1/0)\n Press 1 for continue\n 0 for exit\n");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1);
        }
    }
}