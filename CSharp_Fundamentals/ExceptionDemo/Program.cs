namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader? streamReader = null;
            try
            {
                //string path = @"C:\Users\249079\Desktop\lear.txt"; =>
                string path = "C:\\Users\\249079\\Desktop\\learning.txt";
                streamReader = new StreamReader(path);
                Console.WriteLine(streamReader.ReadToEnd());

                //StreamReader streamReader1 = new StreamReader("sample1.txt");
                //Console.WriteLine(streamReader1.ReadToEnd());

            }

            //catch (FileNotFoundException ex)
            //{ 
            //    Console.WriteLine(ex.Message);
            //}
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType()); //GetType() method returns the type of the exception
                Console.WriteLine(ex.GetType().Name);
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();
                // streamReader?.Close();=> above is same as this
            }


        }
    }
}