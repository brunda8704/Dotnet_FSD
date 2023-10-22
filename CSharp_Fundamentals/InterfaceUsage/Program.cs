namespace InterfaceUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces usage");
            ICustomerOne customerOne = new Customers();//here only ICustomer1 methods are accessible
            customerOne.CustomerOneMethod();
            customerOne.Print();

            ICustomerTwo customerTwo = new Customers();//here both ICustomer1 & ICustomer2 are accessible
                                                   //bcz ICustomer1 implementing ICustomer2
            customerTwo.CustomerTwoMethod();
            customerTwo.CustomerOneMethod();
            customerTwo.Print();

            //for calling ICustomer1.Print() method from the main class
            //=> create a object of class which is implementing interface
            //=> do type casting 
            Customers customer3 = new Customers();
            ((ICustomerOne)customer3).Print();

            // for calling ICustomer2.Print() method from the main class
            //=> do same as above
            Customers customer4 = new Customers();
            ((ICustomerTwo)customer4).Print();

        }
    }
}