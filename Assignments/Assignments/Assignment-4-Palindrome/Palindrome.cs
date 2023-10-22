using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment_4_Palindrome
{
    internal class Palindrome
    {
        public static void Display()
        {

            string inputString = Console.ReadLine();
            string reverseString = string.Empty;

            for (int i = inputString.Length-1; i >= 0; i--)
            {
                reverseString = reverseString + inputString[i];
            }

            if (reverseString == inputString)
            {
              Console.WriteLine("{0} is palindrome",reverseString);
                    
            }
            else
            {
                    Console.WriteLine("{0} is not palindrome",reverseString);
            }


        }
    }

}
        

        
        
    

