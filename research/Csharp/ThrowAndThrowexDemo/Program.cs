namespace ThrowAndThrowexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestingThrow.ExceptionMethod();
            }
            catch (Exception ex)
            {
                //throw ex;
                throw;
            }
        }
    }
}