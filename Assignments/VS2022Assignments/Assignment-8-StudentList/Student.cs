using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_StudentList
{
    internal class Student
    {
        public static List<Student> studentList = new List<Student>();
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Marks { get; set; }

    }
}
