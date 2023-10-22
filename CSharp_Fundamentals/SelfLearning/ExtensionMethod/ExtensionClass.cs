

namespace ExtensionMethodDemo
{
    public static class ExtensionClass
    {
        public static void NewMethod(this Student student)
        {
            Console.WriteLine("NewMethod =>Extended method");
        }
    }
}