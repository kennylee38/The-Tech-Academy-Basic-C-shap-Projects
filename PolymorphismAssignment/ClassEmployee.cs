using System;
    
namespace PolymorphismAssignment
{

    // Define a class 'Employee' that inherits from 'Person' and implements 'IQuittable'
    class Employee : Person, IQuittable
    {
        // Implement the Quit() method from the IQuittable interface
        public void Quit()
    }
        Console.WriteLine("Employee has quit the job.");
}


