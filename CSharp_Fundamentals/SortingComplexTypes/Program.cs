namespace SortingComplexTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SortingComplexTypes!\n");

            List<Student> students = new List<Student>()
            { new Student{ID=1,Name="Dhanush",Marks=80},
            new Student{ID=2,Name="Anu",Marks=60}
            };
            Student student = new Student();

            Console.WriteLine("Before Sorting");
            foreach (Student student1 in students)
            {
                Console.WriteLine($"Id:{student1.ID},Name:{student1.Name},Marks:{student1.Marks}");
            }

            //SortByMarks sortByMarks = new SortByMarks();
            //students.Sort(sortByMarks);

            students.Sort();
            Console.WriteLine("\nAfter Sorting");
            foreach (Student student1 in students)
            {
                Console.WriteLine($"Id:{student1.ID},Name:{student1.Name},Marks:{student1.Marks} ");
            }

        }
    }
}