namespace ThisKeyword
{
    internal class Program
    {

        //constructor overloading
        //Calling one constructor from another constructor-> constructor chaining

        Program()
        {
            Console.WriteLine("default constructor");
        }
        Program(int number1, int number2)
        {
            Console.WriteLine("Constructor with two parameter");
        }


        Program(int number) : this(33, 22)    //1st it invokes the constructor with 2 parameters
        {
            Console.WriteLine("Constructor with one parameter");
        }


        static void Main(string[] args)
        {
            Program program = new Program(10);
            Console.ReadLine();
        }

    }
}
 
