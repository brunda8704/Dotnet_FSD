namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>()
            {
                new Student{Id = 4,Name = "Ajay", Marks = 50 },
                new Student{Id = 3,Name = "Sam", Marks=80 },
                new Student{Id = 1,Name = "Ashmi", Marks=70}

            };

            
            //Displays all students
            foreach (var student in studentsList)
            {
                Console.WriteLine($"Id:{student.Id}, Name:{student.Name}, Marks:{student.Marks}");
            }

            //find all students marks<80
            var failedStudentList = studentsList.FindAll(student => student.Marks < 80);
            Console.WriteLine($"\nTotal number of failed students: {failedStudentList.Count}");
            foreach (var student in failedStudentList)
            {
                Console.WriteLine($"Id:{student.Id}, Name:{student.Name}, Marks:{student.Marks}");
            }

            //finds students name starts with 'A' and marks less than 70
            var specificLetterStudentList = studentsList.FindAll(student => student.Name.StartsWith('A') && student.Marks < 70);
            Console.WriteLine($"\nName starting with 'A' and marks lessthan 70");
            foreach (var student in specificLetterStudentList)
            {
                Console.WriteLine($"Id:{student.Id}, Name:{student.Name}, Marks:{student.Marks}");
            }


        }
    }
}