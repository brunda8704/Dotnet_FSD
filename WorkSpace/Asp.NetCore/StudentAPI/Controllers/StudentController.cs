using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Model;
using StudentAPI.Services;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;


        public StudentController(IStudentService studentService)
        { 
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var students = _studentService.GetAllStudents();
            if (students.Count == 0)
            {
                return NotFound("No student records");
            }

            return Ok(students);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            _studentService.AddStudent(student);
            return Ok(student);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student==null)
            {
                return NotFound("No student record found with this Id");
            }
            return Ok(student);
        }

        [HttpDelete("{id}")]
       public IActionResult Delete(int id)
        {
            var student =_studentService.DeleteStudentById(id);
            if (student == false)
            {

                return NotFound("No student record found with this Id to delete");
            }
            
            return Ok("Student record deleted successfully");

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] Student student)
        {
            var students = _studentService.UpdateStudent(id, student);
            if(students==false)
            {
                return NotFound("No student record found with this Id to update");
            }
            return Ok("Student record updated successfully" );
        }
    }
}
