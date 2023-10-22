using StudentAPI.Models;

namespace StudentAPI.Repository
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();

        Task<Student> AddStudent(Student student);

        Task<bool> UpdateStudent(int id,Student student);

        Task<bool> DeleteStudentById(int id);
    }
}
