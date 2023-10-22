using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_StudentList
{
    internal class StudentValidation
    {
        public static void StudentValidationCheck(Student student)
        {
            if (string.IsNullOrEmpty(student.Name))
            {
                throw new StudentValidationException("Name should not be null or empty");

            }
            if(student.Age <=0)
            {
                throw new StudentValidationException("Age should be greater than zero");
            }
            if(student.Marks <=0)
            {
                throw new StudentValidationException("Marks should be greater than zero");
            }

        }

        public class StudentValidationException : Exception
        {
            public StudentValidationException(string message) : base(message)
            {

            }
        }
    }
}
