using System;

namespace MethodOverloadingApp
{
    // Class containing overloaded methods
    public class MathOperations
    {
        // Method 1: Takes integer, multiplies by 5
        public int PerformMathOperation(int number)
        {
            return number * 5;
        }
        
        // Method 2: Takes decimal, adds 15.75, returns as integer (truncated)
        public int PerformMathOperation(decimal number)
        {
            return (int)(number + 15.75m);
        }
        
        // Method 3: Takes string, parses to integer, subtracts 8
        public int PerformMathOperation(string numberString)
        {
            if (int.TryParse(numberString, out int parsedNumber))
            {
                return parsedNumber - 8;
            }
            return 0; // Return 0 if parsing fails
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== METHOD OVERLOADING DEMONSTRATION ===\n");
            
            // Instantiate the class
            MathOperations mathOps = new MathOperations();
            
            // Call first method with integer
            int intResult = mathOps.PerformMathOperation(12);
            Console.WriteLine($"Integer method (12 × 5): {intResult}");
            
            // Call second method with decimal
            int decimalResult = mathOps.PerformMathOperation(22.35m);
            Console.WriteLine($"Decimal method (22.35 + 15.75, truncated): {decimalResult}");
            
            // Call third method with string that equates to integer
            int stringResult = mathOps.PerformMathOperation("45");
            Console.WriteLine($"String method (45 - 8): {stringResult}");
            
            // Test with invalid string to show error handling
            int invalidResult = mathOps.PerformMathOperation("ABC");
            Console.WriteLine($"Invalid string method (returns 0): {invalidResult}");
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}