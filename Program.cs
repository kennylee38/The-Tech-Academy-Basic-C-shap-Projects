using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate two Employee objects
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

        // Compare the Employee objects using the overloaded == operator
        bool areEqual = employee1 == employee2;
        bool areNotEqual = employee1 != employee2;

        // Display the comparison results
        Console.WriteLine($"Are employee1 and employee2 equal? {areEqual}");
        Console.WriteLine($"Are employee1 and employee2 not equal? {areNotEqual}");
    }
}


