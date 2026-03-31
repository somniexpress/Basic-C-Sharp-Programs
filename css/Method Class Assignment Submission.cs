using System;

namespace MathOperationsApp
{
    // This class contains a void method that performs math operations
    class MathOperations
    {
        /// <summary>
        /// A void method that takes two integers as parameters
        /// Performs a math operation on the first integer
        /// Displays the second integer to the screen
        /// </summary>
        /// <param name="number1">First integer - will have math operation performed on it</param>
        /// <param name="number2">Second integer - will be displayed to screen</param>
        public void PerformMathOperation(int number1, int number2)
        {
            // Perform a math operation on the first integer
            // Here we multiply the first number by 10
            int result = number1 * 10;
            
            // Display the result of the math operation
            Console.WriteLine($"Math operation result: {number1} × 10 = {result}");
            
            // Display the second integer to the screen
            Console.WriteLine($"The second integer is: {number2}");
        }
    }
}

/////////////////////////////////////////////
using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a header
            Console.WriteLine("=== VOID METHOD DEMONSTRATION ===\n");
            
            // Instantiate the class (create an object)
            MathOperations mathOps = new MathOperations();
            
            // FIRST CALL: Call the method by passing in two numbers in order
            // This uses positional parameters (order matters)
            Console.WriteLine("FIRST CALL: Passing numbers in order (positional parameters)");
            Console.WriteLine("-----------------------------------------------------------");
            mathOps.PerformMathOperation(5, 20);
            
            // Add a blank line for spacing
            Console.WriteLine();
            
            // SECOND CALL: Call the method by specifying parameters by name
            // This uses named parameters (order doesn't matter)
            Console.WriteLine("SECOND CALL: Specifying parameters by name (named parameters)");
            Console.WriteLine("-----------------------------------------------------------");
            mathOps.PerformMathOperation(number2: 15, number1: 8);
            
            // Wait for user to press a key before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
