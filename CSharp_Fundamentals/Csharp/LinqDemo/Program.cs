namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>()
            {
                1, 2, 3, 4, 5, 6
            };

            //Query syntax
            var querySyntax= from listElements in list //initialization
                         where listElements < 3  //condition
                         select listElements; //selection
            Console.WriteLine("Query syntax:");
            foreach (var item in querySyntax)
                Console.WriteLine(item);


            //Method syntax
            var methodSyntax = list.Where(arrayElements => arrayElements > 5).ToList();
            Console.WriteLine("\nMethod syntax:");
            foreach (var item in methodSyntax)
            {
                Console.Write(item + " ");
            }

            //Mixed syntax
            var mixedSyntax = (from listElements in list
                               where listElements < 7
                               select listElements).Sum(); //->method syntax
            Console.WriteLine("\n\nMixed syntax:");
            Console.WriteLine($"Sum is {mixedSyntax}");

        }
    }
}