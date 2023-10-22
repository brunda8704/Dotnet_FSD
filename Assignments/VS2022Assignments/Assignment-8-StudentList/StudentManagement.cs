using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_StudentList
{
    internal class StudentManagement
    {
       

        public static bool AddStudent(Student student)
        {
            var checkId =Student.studentList.Count == 0 ? 1000 : Student.studentList.Max(studentList => student.Id) + 1;
            Student.studentList.Add(student);
            return true;

        }
        public List<Student> ViewAllStudents()
        {
            return Student.studentList;

        }

        public List <Student> ViewStudentsMarks()
        {
            var selectedStudents=Student.studentList.FindAll(studentMark=>studentMark.Marks>60);
            return Student.studentList;
        }


    }
}
