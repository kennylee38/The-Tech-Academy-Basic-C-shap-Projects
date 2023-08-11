using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type IQuittable using polymorphism
            IQuittable quittableEmployee = new Employee();

            // Call the Quit() method on the IQuittable object
            quittableEmployee.Quit();

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}
