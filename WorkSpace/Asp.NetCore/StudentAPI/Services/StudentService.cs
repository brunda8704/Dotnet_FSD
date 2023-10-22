using Microsoft.AspNetCore.Mvc;
using StudentAPI.Controllers;
using StudentAPI.Model;

namespace StudentAPI.Services
{
    public class StudentService : IStudentService
    {
        public static List<Student> students = new List<Student>();

        public IReadOnlyList<Student> GetAllStudents()
        {
            return students;
        }
        public void AddStudent(Student student)
        {
            student.Id = students.Count == 0 ? 1 : students.Max(studentId => studentId.Id) + 1;
            students.Add(student);
        }

        public Student GetStudentById(int id)
        {
            var getById = students.Find(studentId => studentId.Id == id);
            return getById;
        }

        public bool DeleteStudentById(int id)
        {
            var deleteById = students.Remove(students.Find(student=>student.Id==id));
            return deleteById;
            
        }

        public bool UpdateStudent(int id, Student student)
        {
            var update= students.Find(studentId => studentId.Id == id);
            if(update != null)
            {
                update.FirstName = student.FirstName;
                update.LastName = student.LastName;
                update.Age = student.Age;

                return true;
            }
            return false;
            
        }



    }
}
