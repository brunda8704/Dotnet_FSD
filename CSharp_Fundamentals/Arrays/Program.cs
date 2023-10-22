namespace Arrays
{
     class Program
    {
        static void Main(string[] args)
        {
            int len = 0;
            int sumOfArray = 0;

            Console.WriteLine("Enter length of array");
            len = Convert.ToInt32(Console.ReadLine());
            int[] sum = new int[len];

            for (int i = 0; i < len; i++)
            {
                sum[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < len; i++)
            {
                sumOfArray = sumOfArray + sum[i];
            }
            Console.WriteLine("Sum of array: " + sumOfArray);
            Console.ReadLine();

            

        }
    }
}