namespace Assignment_6_Delegates_FuncDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee { Id = 1, Name = "Thomas", Salary = 50000, Experience = 3 };
            employees[1] = new Employee { Id = 2, Name = "Jerry", Salary = 10000, Experience = 2 };
            employees[2] = new Employee { Id = 3, Name = "Veena", Salary = 40000, Experience = 5 };


            Employee employee = new Employee();
            employee.GetPromotedEmployees(employees, IsPromoted);
        }
        public static bool IsPromoted(Employee employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            return false;
        }
    }
}