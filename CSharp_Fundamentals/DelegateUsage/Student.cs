using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUsage
{
    internal class Student
    {
        public delegate bool IsEligibleForPromotion(Student student);
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        //passing delegate as a parameter to this function
        //=> IsEligibleForPromotion isEligibleForPromotion = new IsEligibleForPromotion(IsPromoted);
        //=> behind the scene the above thing will be happening
        public void GetPromotedStudents(Student[] students, IsEligibleForPromotion isEligibleForPromotion)
        {
            foreach (Student student in students)
            {
                if (isEligibleForPromotion(student))
                {
                    Console.WriteLine($"{student.Id}, {student.Name} is promoted");
                }

            }
        }

    }
}
