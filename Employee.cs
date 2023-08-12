using System;

// Define the Employee class with properties Id, FirstName, and LastName.
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare Employee objects by their Id property.
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        if (ReferenceEquals(emp1, emp2))
            return true;

        if (emp1 is null || emp2 is null)
            return false;

        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator by using the opposite of the "==" operator.
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
}