using System;

struct Number
{
    public decimal Amount { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of data type Number
        Number numberObject = new Number();

        // Assign an amount to the Number object's Amount property
        numberObject.Amount = 123.45m;

        // Print the amount to the console
        Console.WriteLine($"The amount is: {numberObject.Amount}");
    }
}
