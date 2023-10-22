namespace ProductList
{
    public enum Choice
    { 
        Add=1,
        ViewAll,
        ViewWithPrice,
        RemoveAll

    };
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {

                Console.WriteLine("Flipko store");
                Console.WriteLine("1.Add product");
                Console.WriteLine("2.View all products");
                Console.WriteLine("3.View all products with price>1000");
                Console.WriteLine("4.Remove all products");

                Console.WriteLine("enter your choice");
                bool userChoice = int.TryParse(Console.ReadLine(), out choice);

                try
                {
                    switch((Choice)choice)
                    {
                        case Choice.Add:
                            break;

                        case Choice.ViewAll:
                            break;

                        case Choice.ViewWithPrice:
                            break;

                        case Choice.RemoveAll:
                            break;
                       
                        default: Console.WriteLine("Invalid input");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"error!-> {ex.Message}");
                }
            }
            while (choice != 4);

        }
            
        
    }
}