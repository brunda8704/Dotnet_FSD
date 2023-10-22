using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "Amma";
            var filter=Regex.Matches(text,"m").Count();
            Console.WriteLine(filter);

            //var word = "Hello C# 122345";
            //var replace= Regex.Replace(word, @"\d", "X");

            var sentence = "Hello Java";
            var replace = Regex.Matches(sentence, @"\bbrown\b", "red");

            Console.WriteLine(replace);
        }
    }
}