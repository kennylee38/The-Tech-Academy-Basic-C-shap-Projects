sing System;

public class Employee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the == operator to compare Employee objects by their Id property
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
            return true;

        if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            return false;

        return employee1.Id == employee2.Id;
    }

    // Overload the != operator based on the == operator
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }
}







