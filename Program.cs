using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user for their age
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                // Validate the age
                if (age <= 0)
                {
                    throw new ArgumentException("Age must be a positive number.");
                }

                // Calculate birth year
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;

                // Display the birth year
                Console.WriteLine($"You were born in {birthYear}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
            }
        }
    }
}
