namespace ToStringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int x = Convert.ToString(null);
            //string data = null;
            //Console.WriteLine(data.ToString());

            //Console.WriteLine(Convert.ToString(data));

            ////ToString=>default it prints namespace.object name

            //int number1 = 100;
            //string stringNumber1 = number1.ToString();
            //Console.WriteLine(stringNumber1);

            ////Convert.ToString
            //object myObject = null;
            //string myString = Convert.ToString(myObject);
            //Console.WriteLine(myString);

            //string myString1 = myObject.ToString();
            //Console.WriteLine(myString1);

            //Object object = new Object();
            Employee employee = new Employee { Id = 1, Name = "Sam" };
            Console.WriteLine(employee);

        }
    }
}