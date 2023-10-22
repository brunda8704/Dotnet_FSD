namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dynamic polymorphism!!!");
            Student[] students = new Student[4];
            students[0] = new Student();
            students[1] = new RegularStudent();
            students[2] = new IrregularStudent();


            foreach (Student student in students)
            {
                student.PrintStudentName();
            }


        }
    }
}