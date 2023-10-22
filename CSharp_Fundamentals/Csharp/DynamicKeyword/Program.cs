namespace DynamicKeyword
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            //It's not mandatory to initialise at declaration time.
            // dynamic value;
             
            //dynamic someValue = "Dynamic keyword";
            //Console.WriteLine(someValue);
            //someValue++;

            Customer customer = new Customer()
            {
                Name = "Anu",
                Location = "Japan"
            };
            
           
            // Customer type to dynamic conversion
            dynamic dynamicCustomer = customer;
            Console.WriteLine($"Name = {dynamicCustomer.Name}");
            Console.WriteLine($"Location = {dynamicCustomer.Location}");
            


        }
    }

}