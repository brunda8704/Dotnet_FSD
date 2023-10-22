namespace InheritanceOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Display();

            Child.Show(); //static function calling

        }
    }
}