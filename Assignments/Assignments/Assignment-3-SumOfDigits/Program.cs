using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3_SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, remainder;
            Console.WriteLine("------Sum of digits-----");
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                remainder = number % 10;
                sum = sum + remainder;
                number = number / 10;
            }
            Console.WriteLine("Sum of digits: {0}", sum);

            Console.ReadLine();
        }
    }
}
