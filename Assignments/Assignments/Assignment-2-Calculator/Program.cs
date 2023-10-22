using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assignment_2_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
             int firstNumber, secondNumber;
             int choice,option;

             do
             {
                Console.WriteLine("-----------Calculator------------\n");
                Console.WriteLine("Enter first number");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your choice\n 1.Adding two integer numbers \n 2.Subtracting two integer numbers\n 3.Multiplying two integer numbers\n 4.Dividing two integer numbers");
                choice = Convert.ToInt32(Console.ReadLine());

                Program.Operation(firstNumber, secondNumber, choice); //Operation function calling
               
                Console.WriteLine("Do you want to continue?(1/0)");
                option =Convert.ToInt32(Console.ReadLine());
             }
             while(option == 1);

         } 


                
            static void Operation(int firstNumber,int secondNumber,int choice)
            {
                    
                int result;
                switch(choice)
                {
                        case 1:
                             result = Calculator.Addition(firstNumber,secondNumber);
                             Console.WriteLine("Addition of {0} and {1} = {2}", firstNumber, secondNumber, result);
                             break;

                        case 2:
                            result = Calculator.Subtraction(firstNumber,secondNumber);
                            Console.WriteLine("Subtraction of {0} and {1} = {2}", firstNumber, secondNumber, result);
                            break;
               
                        case 3:
                            result = Calculator.Multiplication(firstNumber, secondNumber);
                            Console.WriteLine("Multiplication of {0} and {1} = {2}", firstNumber, secondNumber, result);
                            break;

                        case 4:
                            if (secondNumber == 0)
                            {
                                Console.WriteLine("Number is not divisible by zero");
                                break;
                            }

                            else
                            {
                                result = Calculator.Division(firstNumber, secondNumber);
                                Console.WriteLine("Division of {0} and {1} = {2}", firstNumber, secondNumber, result);
                                break;
                            }

                      }
                }
                


           // Console.ReadLine();

        }

    }

