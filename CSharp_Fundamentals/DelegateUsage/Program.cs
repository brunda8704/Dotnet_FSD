namespace DelegateUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            students[0] = new Student { Id = 1, Name = "Ajay", Score = 50 };
            students[1] = new Student { Id = 2, Name = "Sanjay", Score = 40 };
            students[2] = new Student { Id = 3, Name = "Anu", Score = 80 };


            static bool IsPromoted(Student student)
            {
                if (student.Score > 50)
                {
                    return true;
                }
                return false;
            }

            static bool IsPromoted1(Student student)
            {
                if (student.Id > 1)
                {
                    return true;
                }
                return false;
            }

            Student student = new Student();
            student.GetPromotedStudents(students, IsPromoted);

        }
    }
}