using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Object o= new object;
            int targetNumber, choice;

            Console.WriteLine("--------Checks odd/even numbers--------\n");
            Console.WriteLine("Enter a target Number");
            targetNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your choice \n1.Odd 2.Even");
            choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine("Odd numbers are:");
                for (int i = 0; i < targetNumber; i++)
                {
                    if (i % 2 != 0) //checking odd
                    {
                        Console.WriteLine(i);
                    }
                }

            }


            else if (choice == 2)
            {
                Console.WriteLine("Even numbers are:");
                for (int i = 0; i < targetNumber; i++)
                {
                    if (i % 2 == 0) //checking even
                    {
                        Console.WriteLine(i);
                    }
                }

            }

            else
            {
                Console.WriteLine("Invalid input");
            }


            Console.ReadLine();

        }
    }
}
