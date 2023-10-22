using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Palindrome
{
    internal class Palindrome
    {
        public static void Display()
        {

            string inputString = Console.ReadLine();
            string reverseString = string.Empty;

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + inputString[i];
            }

            if (reverseString == inputString)
            {
                Console.WriteLine($"{reverseString} is palindrome");

            }

            else
            {
                Console.WriteLine($"{reverseString} is not palindrome");
            }
        }

    }
}
