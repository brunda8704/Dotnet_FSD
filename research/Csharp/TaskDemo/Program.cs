namespace TaskDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started...");
            ////Create a task instance
            //Task<int> task = new Task<int>(PrintNumber);
            //task.Start();
            //Console.WriteLine($"Task result-> {task.Result}");
            //Console.WriteLine("Main thread ended...");


            int[] arrNum = new int[] { 13, 14, 25, 30, 56, 11, 20, 29 };

            //Create a Task<TResult> instance, return type is int
            Task<int> task = Task<int>.Run(() => {
                int tempSum = 0;
                for (int i = 0; i < arrNum.Length; i++)
                    tempSum = tempSum + arrNum[i];
                return tempSum;
            });

            //Get the return value from Task
            //int sum = task.Result;
            Console.WriteLine($"Sum of all numbers in array : {task.Result}");
            Console.WriteLine("In Main Method, Finished work on thread Id: {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
        

        }

        public static int PrintNumber()
        {
            return 10;
           
        }
    }
}