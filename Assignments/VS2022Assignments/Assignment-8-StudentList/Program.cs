using static Assignment_8_StudentList.StudentValidation;

namespace Assignment_8_StudentList
{
    internal class Program
    {

        public enum Choice
        { 
            Add=1,
            ViewAll,
            ViewMarks,
            RemoveAll,
            Exit
        };
        static void Main(string[] args)
        {
            int choice;
            
            
            StudentManagement studentManagement = new StudentManagement();

            Console.WriteLine("*********Student Management*******\n");
            try
            {
                do
                {
                    Display();
                    Console.WriteLine("Enter your choice");
                    choice=Convert.ToInt32(Console.ReadLine());
                    Student student = new Student();

                    switch ((Choice)choice)
                    {
                        case Choice.Add:
                            Console.WriteLine("Enter student name");
                            student.Name = Console.ReadLine();

                            Console.WriteLine("Enter student age");
                            int.TryParse(Console.ReadLine(), out int studentAge);
                            student.Age = studentAge;

                            Console.WriteLine("Enter student marks");
                            int.TryParse(Console.ReadLine(), out int studentMarks);
                            student.Marks = studentMarks;


                            StudentValidation.StudentValidationCheck(student);
                            var studentAdded = StudentManagement.AddStudent(student);
                            if (studentAdded)
                            {
                                Console.WriteLine("Student details added successfully\n");

                            }
                            break;

                        case Choice.ViewAll:
                            var studentDetails = studentManagement.ViewAllStudents();
                            if (studentDetails.Count == 0)
                            {
                                Console.WriteLine("No students to display\n");
                            }
                            else
                            {
                                Console.WriteLine("Student Details\n----------------");
                                foreach (var studentOne in studentDetails)
                                {
                                    Console.WriteLine($"Id:{studentOne.Id}, Name:{studentOne.Name}, Age:{studentOne.Age}, Marks:{studentOne.Marks}\n");

                                }

                            }
                            break;

                        case Choice.ViewMarks:
                            var selectedStudent = studentManagement.ViewStudentsMarks();
                            if (selectedStudent.Count == 0)
                            {
                                Console.WriteLine("No students with marks>60\n");
                            }
                            else
                            {

                                foreach (var checkMark in selectedStudent)
                                {
                                    Console.WriteLine($"Id:{checkMark.Id}, Name:{checkMark.Name}, Age:{checkMark.Age} ,Marks:{checkMark.Marks}\n");
                                }
                            }
                             
                            
                            break;


                        case Choice.RemoveAll:
                            var removeStudents = studentManagement.ViewAllStudents();
                            if(removeStudents.Count==0)
                            {
                                Console.WriteLine("No students to remove\n");
                            }
                            else
                            {
                                removeStudents.Clear();
                                Console.WriteLine("All students record deleted successfully\n");
                            }
                            
                            break;


                        case Choice.Exit:
                            Console.WriteLine("Exited successfully!!\n");
                            break;

                        default:
                            Console.WriteLine("Invalid Input\n");
                            break;
                    }

                    
                }
                while (choice!=5);
            }
            catch(StudentValidationException ex)
            { 
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error!!\n");
            }
        }
        public static void Display()
        {
           Console.WriteLine("1.Add student\n2.View all students\n3.View all students marks>60\n4.Remove all students\n5.Exit\n");
        }

        
    }
}