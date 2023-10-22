namespace PresentDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime presentDay = DateTime.Today; // prints date and time
            DayOfWeek presentDay = DateTime.Today.DayOfWeek;// prints only day
            Console.WriteLine($"Today is {presentDay}");
        }
    }
}