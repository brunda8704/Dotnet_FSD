namespace Test
{
    internal class Program
    {
        public static bool debug(string npi)
        {
            int sum = 0; // Error : int sum=1;
            int len = npi.Length;
            if (len != 10) // Error : if(len==10)
            {
                return false;
            }
            for (int i = len - 1; i >= 0; i--) // Error : for(int i = len; i < 0; i--)
            {
                if (!Char.IsDigit(npi[i]))
                {
                    return false;
                }
                int digit = npi[i] - '0'; // Error : digit = npi[i]-'9'
                if (i % 2 == 0)
                {
                    digit *= 2;
                    if (digit > 9) // Error : if(digit<9)
                    {
                        digit -= 9; // Error : digit=9;
                    }
                }
                sum += digit;
            }
            return sum % 2 == 0; // Error : return sum%2!=0
        }
        static void Main(string[] args)
        {
            string npi = Console.ReadLine();
            Console.WriteLine(debug(npi));
        }
    }
}