using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Repository;
using StudentAPI.ViewModel;

namespace StudentAPI.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("getallstudents")]
        public async Task<IActionResult> Get()
        {
            var students = await _studentRepository.GetAllStudentsAsync();
            return Ok(students);
        }

        [HttpPost]
        [Route("addstudent")]
        public async Task<IActionResult> Post([FromBody] AddStudentViewModel addStudentViewModel)
        {
            var student = new Student
            {
                FirstName = addStudentViewModel.FirstName,
                LastName = addStudentViewModel.LastName,
                TotalMarks = addStudentViewModel.TotalMarks,
                Age = addStudentViewModel.Age,

            };
            var addStudent = await _studentRepository.AddStudent(student);
            return Ok(addStudent);
        }

        [HttpPut]
        [Route("updatestudentbyid")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateStudentViewModel updateStudentViewModel)
        {
            var student = new Student
            {
                FirstName = updateStudentViewModel.FirstName,
                LastName = updateStudentViewModel.LastName,
                TotalMarks = updateStudentViewModel.TotalMarks,
                Age = updateStudentViewModel.Age
            };
            var updateStudent = await _studentRepository.UpdateStudent(id, student);
            return Ok(updateStudent);

        }

        [HttpDelete]
        [Route("deletestudentbyid")]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _studentRepository.DeleteStudentById(id);
            if(student)
            {
                return Ok($"Student deleted successfully");
               
            }
             return NotFound($"Student with id {id} not found");
           
        }


    }
}
