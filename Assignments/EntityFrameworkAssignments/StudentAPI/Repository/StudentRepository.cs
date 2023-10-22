using Microsoft.EntityFrameworkCore;
using StudentAPI.DBContext;
using StudentAPI.Models;
using StudentAPI.ViewModel;

namespace StudentAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDBContext _context;
        public StudentRepository(StudentDBContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> AddStudent(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return student;

        }

        public async Task<bool> UpdateStudent(int id, Student student)
        {
            var updateStudent = await _context.Students.FindAsync(id);
            if (updateStudent != null)
            {
                updateStudent.FirstName = student.FirstName;
                updateStudent.LastName = student.LastName;
                updateStudent.TotalMarks = student.TotalMarks;
                updateStudent.Age = student.Age;
            }
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteStudentById(int id)
        {
            return await _context.Students.Where(x=>x.Id == id).ExecuteDeleteAsync()>0;
            
        }
    }
}
