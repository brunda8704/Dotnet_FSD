using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Delegates
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }


        public void GetPromotedEmployees(Employee[] employees, Predicate<Employee> isEligibleForPromotion)
        {
            foreach (Employee employee in employees)
            {
                if (isEligibleForPromotion(employee))
                {
                    Console.WriteLine($"{employee.Id},{employee.Name} is promoted");
                }
            }
        }

    }
}
