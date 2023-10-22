namespace StaticKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static Variable
            //-> can be accessed using the class name
            Console.WriteLine("Department: " + StaticVariable.department);

            //Non-static Variable
            //-> for accessing non-static variable we need to create objects of the class 
            NonStaticVariable nonstatic = new NonStaticVariable();
            nonstatic.place = "Mysore";
            Console.WriteLine("Place: " + nonstatic.place);

            // Static Methods
            //-> Just like static variables, we can call the static methods using the class name.

            // Non-static Methods
            //-> Just like non-static variables, we need to create objects of the class

            // Static Class
            //-> when we declare a class as static, we cannot create objects of the class
            //-> we can only have static members inside the static class.
            //-> we cannot inherit a static class 

            /* example for static class:
             * 
             * static class Test {
               static int a = 5;
               static void display() 
             * {

                    Console.WriteLine("Static method");
               }
             * 
             */

            //private constructor-> we cannot create objects of the class

            // Main method is static-> so we can call it without creating the object.

        }
    }
}