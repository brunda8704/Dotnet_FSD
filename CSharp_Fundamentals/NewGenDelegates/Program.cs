namespace NewGenDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NewGen Delegates");

            Action action = ActionDelegates.Display;
            action();

            Action<string> actionWithParams1 = ActionDelegates.Show;
            actionWithParams1("helllo");

            Action<int, string> actionWithParams2 = ActionDelegates.ShowDetails;
            actionWithParams2(12, "ajay");

            //it takes 2 parameters as input & returns 1 output
            Func<int, int, int> func = FuncDelegates.Addition;
            int sum = func(10, 20);
            Console.WriteLine(sum);

            Func<int> func1 = FuncDelegates.Display;
            func1();

            Predicate<string> predicate = PredicationDelegates.DisplayMethod;


            Func<string, bool> funcPredicate = PredicationDelegates.DisplayMethod;

        }
    }
}