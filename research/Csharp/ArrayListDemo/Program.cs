using System.Collections;

namespace ArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList demo!");

            // Adding elements to ArrayList using Add() method
            ArrayList arrayListOne = new ArrayList();
            arrayListOne.Add(101);
            arrayListOne.Add("James");
            arrayListOne.Add("James");
            arrayListOne.Add(" ");
            arrayListOne.Add(true);
            arrayListOne.Add(4.5);
            arrayListOne.Add(null);

            foreach (var item in arrayListOne)
            {
                Console.WriteLine(item);
            }


            //Adding Elements to ArrayList using object initializer syntax
            var arrayListTwo = new ArrayList()
            {
                102, "Smith", "Smith", true, 15.6
            };

            //Insert "First Element" at First Position i.e. Index 0
            arrayListTwo.Insert(0, "First Element");
            arrayListTwo.Remove(true);
            arrayListTwo.RemoveRange(0, 2);
            arrayListTwo.Clear();

            foreach (var item in arrayListTwo)
            {
                Console.WriteLine(item);
            }


        }
    }
}