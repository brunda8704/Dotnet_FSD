using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3_SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            Console.WriteLine("Swapping of 2 numbers without using third variable\n");
            Console.WriteLine("Enter firstnumber");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secondnumber");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Before swapping:" + firstNumber + " " + secondNumber);
            firstNumber= firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("After swapping:" + firstNumber + " " + secondNumber);

            Console.ReadLine();

        }
    }
}
