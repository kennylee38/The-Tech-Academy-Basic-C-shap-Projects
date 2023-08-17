using System;

namespace MethodClassAssignment
{
     class Program
    {
    static void Main(string[] args)

        {
        // Instantiate the MathOperation class
        MathOperation mathOperation = new MathOperation();

        // Call the method in the class, passing in two numbers
        mathOperation.PerformMathOperation(10, 20);

        // Call the method in the class, specifying the parameters by name
        mathOperation.PerformMathOperation(firstNumber: 15, secondNumber: 25);
        }
    }

}

