namespace ReadAndWriteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read and Write data from file!\n");

            //1. Using the StreamReader and StreamWriter Classes
            // Writing data to a file
            using (StreamWriter streamWriter = new StreamWriter("FileOne.txt"))
            {
                streamWriter.WriteLine("Hello!");
                streamWriter.Write("Greetings for the day!");
            }
            // Reading data from a file
            Console.WriteLine("Using the Stream class:");
            using (StreamReader streamReader = new StreamReader("FileOne.txt"))
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }


            //2. using the filestream class
            // writing data to a file
            Console.WriteLine("\nUsing the file class:");
            File.WriteAllText("FileTwo.txt", "C# programming!");
            // reading data from a file
            string[] fileContent = File.ReadAllLines("FileTwo.txt");
            foreach (string line in fileContent)
            {
                Console.WriteLine(line);
            }


            //3.Using the BinaryReader and BinaryWriter Classes
            // Writing binary data to a file
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open("FileThree.txt", FileMode.Create)))
            {
                binaryWriter.Write(42);
                binaryWriter.Write("Hello World!");

            }

            // Reading binary data from a file
            using (BinaryReader binaryReader = new BinaryReader(File.Open("FileThree.txt", FileMode.Open)))
            {
                int number = binaryReader.ReadInt32();
                string text = binaryReader.ReadString();
                Console.WriteLine("\nUsing the binary class:");
                Console.WriteLine("Number: " + number);
                Console.WriteLine("Text: " + text);
            }


        }
    }
}