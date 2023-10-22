namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a dictionary to store employee data
            Dictionary<int, string> employees = new Dictionary<int, string>();

            // Adding some employees to the dictionary
            employees.Add(1, "Alice");
            employees.Add(2, "Bob");
            employees.Add(3, "Charlie");

            // Print the employee names
            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"Employee ID: {employee.Key}, Name: {employee.Value}");
            }

            // Removing an employee with ID 1 from the dictionary
            employees.Remove(1);
            Console.WriteLine("\nRemoving an employee with ID 1");
            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"Employee ID: {employee.Key}, Name: {employee.Value}");
            }

        }
    }
}