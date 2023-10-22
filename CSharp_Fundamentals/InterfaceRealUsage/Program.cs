namespace InterfaceRealUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface real usage");
            Student student = new Student();
            student.Id = 1;
            student.Name = "Test";
            ProcessPlayer processPlayer = new ProcessPlayer(student);
            processPlayer.PlayData();

            Employee employee = new Employee();
            employee.Id = 2;
            employee.Name = "Test1";
            ProcessPlayer processPlayer1 = new ProcessPlayer(employee);
            processPlayer1.PlayData();

        }
    }
}