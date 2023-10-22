using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RepeatedNumberSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1,1,2,2,3,3,4,4,4,5
            };

            var sumlist = list.GroupBy(x => x)
                .Where(c => c.Count() == 2);
                

            foreach ( var item in sumlist )
            {
                if (item.Count() == 2)
                    Console.WriteLine($"key={item.Key},count={item.Count()},sum={item.Sum()}");
                else if (item.Count() == 3)
                    Console.WriteLine($"key={item.Key},count={item.Count()},sum={item.Sum()},product={item.Key*3}");
            }

            List<List<int>> setOfThree = new();
            for (int i = 0; i < list.Count; i += 3)
            {
                var threeElements = list
                    .Skip(i)
                    .Take(3)
                    .ToList();

                setOfThree.Add(threeElements);
            }

            foreach ( var item in setOfThree )
            {
                Console.WriteLine(item.Sum());
            }





        }
    }
}