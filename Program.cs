using System;
using System.Collections.Generic;
using System.Linq; // Import the namespace for LINQ

namespace LamdaExpressionAssigment

class Program
{
    static void Main(string[] args)
    {
        //In the Main() method, create a list of at least 10 employees.
        //At least two employees should have the first name "Joe".
        List<Employee> campus = new List<Employee>()
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Schmo" },
            new Employee { Id = 2, FirstName = "Joe", LastName = "Thomas" },
            new Employee { Id = 3, FirstName = "JimBob", LastName = "Coot" },
            new Employee { Id = 4, FirstName = "Danny", LastName = "Dimes" },
            new Employee { Id = 5, FirstName = "SaQuads", LastName = "Barkley" },
            new Employee { Id = 6, FirstName = "George", LastName = "Title" },
            new Employee { Id = 7, FirstName = "Joe", LastName = "Joesephson" },
            new Employee { Id = 8, FirstName = "Maria", LastName = "Schmo" },
            new Employee { Id = 9, FirstName = "Maria", LastName = "Rodriguez" },
            new Employee { Id = 10, FirstName = "Stephanie", LastName = "Stevens" }
        };

        // Using foreach loop, create a new list of all employees with the first name "Joe".
        List<Employee> joes = new List<Employee>();
        foreach (Employee employee in campus)
        {
            if (employee.firstName == "Joe")
            {
                joes.Add(employee);
            }
        }

        //Do the same thing again, but this time with a lambda expression.
        List<Employee> joes2 = campus.Where(x => x.FirstName == "Joe").ToList();
        //Using a lambda expression, make a list of all employees with an Id number greater than 5
        List<Employee> bigId = campus.Where(x => x.Id > 5).ToList();
        Console.ReadLine();
       
        }
    }
}