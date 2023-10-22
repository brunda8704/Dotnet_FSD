using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{

    [Serializable]
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\249079\Desktop\learning.txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            //serialization

            Student student = new Student { Id = 100, Name = "Thanu" };
            formatter.Serialize(fileStream, student);

            //deserialization

            //Student studentOne = (Student)formatter.Deserialize(fileStream);
            //Console.WriteLine("Student Id = " + studentOne.Id);
            //Console.WriteLine("Student Name = " + studentOne.Name);
            fileStream.Close();
        }
    }
}