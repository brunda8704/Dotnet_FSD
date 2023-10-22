using Microsoft.AspNetCore.Mvc;
using StudentAPI.Model;

namespace StudentAPI.Services
{
    public interface IStudentService
    {
        IReadOnlyList<Student> GetAllStudents();
        void AddStudent(Student student);

        Student GetStudentById(int id);

        bool DeleteStudentById(int id);

        bool UpdateStudent(int id,Student student);
    }

}
