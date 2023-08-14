using System;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the current date and time to the console
            Console.WriteLine("The current time is: " + DateTime.Now);
            //Ask the user for a number
            Console.WriteLine("\nEnter a number to see what the time will be in that many hours:");
            float answer = float.Parse(Console.ReadLine());
            //Print what time it will be in the amount of hours the user input
            Console.WriteLine("{0} + {1} hours(s) = {2}", DateTime.Now, answer, DateTime.Now.AddHours(answer));
        }
    }
}
        
    

