namespace ScoreArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {-26,71,6,-3,-69};
            int score= ScoreArray(arr);
            Console.WriteLine("Score: "+score);
        }

        public static int ScoreArray(int[] arr)
        {
            int score = 0;

            for (int i = 0;i<arr.Length-1; i++)
            {
                
                if (arr[i] + arr[i + 1] % 2 == 0)
                    score += 5;
            }
            for (int j = 0; j < arr.Length - 2; j++)
            {
                if ((arr[j] + arr[j + 1] + arr[j + 2] % 2 != 0) &&
                    (arr[j] * arr[j + 1] * arr[j + 2] % 2 == 0))
                    score += 10;
            }
            return score;

        }
         
    }
}