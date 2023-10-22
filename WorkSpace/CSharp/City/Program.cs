namespace City
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter the city to search: ");
            string city = Console.ReadLine();

            var path = "textFile.txt";
            using (StreamReader streamReader = new StreamReader(path))
            {
                string line = streamReader.ReadLine();
                //string[] str = lines.Split(" ");
                if (line.Contains(city))
                {
                    Console.WriteLine(line);
                }
                else
                {
                    Console.WriteLine("No city found!!");
                }

            }
        }
    }
}