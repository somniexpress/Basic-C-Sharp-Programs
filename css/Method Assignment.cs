using System;

namespace OptionalParameterApp
{
    // Class with method that has an optional parameter
    public class MathOperations
    {
        /// <summary>
        /// Multiplies two numbers. The second number is optional and defaults to 1.
        /// </summary>
        /// <param name="firstNumber">Required first number</param>
        /// <param name="secondNumber">Optional second number (defaults to 1)</param>
        /// <returns>Product of the two numbers</returns>
        public int MultiplyNumbers(int firstNumber, int secondNumber = 1)
        {
            // Multiply the two numbers and return the result
            return firstNumber * secondNumber;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== OPTIONAL PARAMETER DEMONSTRATION ===\n");
            
            // Instantiate the class
            MathOperations mathOps = new MathOperations();
            
            // Ask user for first number (required)
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            
            // Ask user for second number (optional)
            Console.Write("Enter the second number (or press Enter to skip): ");
            string secondInput = Console.ReadLine();
            
            int result;
            
            // Call the method based on whether second number was provided
            if (string.IsNullOrEmpty(secondInput))
            {
                // Call with only the required parameter
                // The optional parameter will use its default value (1)
                Console.WriteLine("\nCalling method with 1 argument (using default value)...");
                result = mathOps.MultiplyNumbers(firstNumber);
                Console.WriteLine($"Result: {firstNumber} × 1 = {result}");
            }
            else
            {
                // Parse the second number and call with both parameters
                int secondNumber = int.Parse(secondInput);
                Console.WriteLine("\nCalling method with 2 arguments...");
                result = mathOps.MultiplyNumbers(firstNumber, secondNumber);
                Console.WriteLine($"Result: {firstNumber} × {secondNumber} = {result}");
            }
            
            Console.WriteLine($"\nFinal Result: {result}");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}