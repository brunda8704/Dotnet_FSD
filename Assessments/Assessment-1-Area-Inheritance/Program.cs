using System.Security.Cryptography.X509Certificates;

namespace Assessment_1_Area_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  shapeSelection=0, option=0;
            int length, breadth,sideLength;
           
            do
            {
                Console.WriteLine("*****Finding Area of Square and Rectangle*****\n");
                Console.WriteLine("Select a shape\n 1->Rectangle\n 2->Square");
                shapeSelection = Convert.ToInt32(Console.ReadLine());
                if (shapeSelection==1)
                {
                    Console.WriteLine("enter the length");
                    length= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the breadth");
                    breadth = Convert.ToInt32(Console.ReadLine());
                    //Rectangle.CalculateArea(length,breadth);     
                }
                else
                {
                    Console.WriteLine("enter the side length");
                    sideLength = Convert.ToInt32(Console.ReadLine());
                    //Square.CalculateArea(sideLength);
                }
                Console.WriteLine("Do you want to continue?\n Press 1 for continue\n 0 for exit\n ");
                option = Convert.ToInt32(Console.ReadLine());

            }    
            while (option==1);
        }
    }
}