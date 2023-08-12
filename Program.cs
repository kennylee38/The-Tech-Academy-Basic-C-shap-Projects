using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate two Employee objects and assign values to their properties.
        Employee emp1 = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };

        Employee emp2 = new Employee
        {
            Id = 2,
            FirstName = "Jane",
            LastName = "Smith"
        };

        // Compare the Employee objects using the overloaded operators.
        if (emp1 == emp2)
        {
            Console.WriteLine("Employee objects are equal.");
        }
        else
        {
            Console.WriteLine("Employee objects are not equal.");
        }

        // Compare the Employee objects using the overloaded operators.
        if (emp1 != emp2)
        {
            Console.WriteLine("Employee objects are not equal.");
        }
        else
        {
            Console.WriteLine("Employee objects are equal.");
        }
    }
}


