namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //integer maxvalue
            int maxValue = int.MaxValue;
            Console.WriteLine("max value of integer is " + maxValue);
            Console.WriteLine("max value of integer is {0}", maxValue);

            //interger minvalue
            int minValue = int.MinValue;
            Console.WriteLine("min value of integer is: " + minValue);
            // console.readline();

            string name;
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("hello " + name);

            ////bool cont;

            ////do
            ////{

            ////    Console.Write("What is your name? ");
            ////    string name = Console.ReadLine();
            ////    Console.Write("What is your age? ");
            ////    int age = Convert.ToInt32(Console.ReadLine());
            ////    //Console.WriteLine("{0} {1}" ,name ,age);

            ////    if (age > 18)
            ////    {
            ////        Console.WriteLine("{0} you are major", name);
            ////    }
            ////    else
            ////        Console.WriteLine("{0} you are minor", name);

            ////        Console.WriteLine("Do you want to continue:");
            ////        cont = Convert.ToBoolean(Console.ReadLine());

            ////}

            ////while (cont == true);



            //int.Parse("12");

            int result;
            bool isconvertable = int.TryParse("123.4", out result);
            if (isconvertable)
            {
                Console.WriteLine("success");
            }
            else
            {
                Console.WriteLine("fail");
            }


            //Array

            //bool ch = true;
            //do
            //{
            //    int[] numbers = new int[5];
            //    Console.WriteLine("Enter 5 numbers to check whether even or odd");
            //    for (int i = 0; i < numbers.Length; i++)
            //    {

            //        numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    }


            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] % 2 == 0)
            //        {
            //            Console.WriteLine("{0} number is even", numbers[i]);
            //        }

            //        //else
            //        //    Console.WriteLine("{0} number is odd", numbers[i]);
            //    }

            //    Console.WriteLine("Do you want to continue:");
            //    ch = Convert.ToBoolean(Console.ReadLine());


            //}
            //while (ch == true);

            Console.ReadLine();

        }
    }
}