using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // First operation: Multiply input by 50
            Console.WriteLine("Enter a number to multiply by 50:");
            
            // Use decimal data type to handle very large numbers and maintain precision
            string input1 = Console.ReadLine();
            decimal number1;
            
            // Parse the input with error handling
            if (decimal.TryParse(input1, out number1))
            {
                // Multiply by 50 and store the result
                decimal result1 = number1 * 50;
                
                // Display the result to the console
                Console.WriteLine($"Result: {number1} × 50 = {result1}\n");
            }
            else
            {
                // Inform user of invalid input
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }

            // Second operation: Add 25 to input
            Console.WriteLine("Enter a number to add 25 to:");
            
            // Get user input for second operation
            string input2 = Console.ReadLine();
            decimal number2;
            
            // Parse the input with error handling
            if (decimal.TryParse(input2, out number2))
            {
                // Add 25 to the input and store the result
                decimal result2 = number2 + 25;
                
                // Display the result to the console
                Console.WriteLine($"Result: {number2} + 25 = {result2}\n");
            }
            else
            {
                // Inform user of invalid input
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }

            // Third operation: Divide input by 12.5
            Console.WriteLine("Enter a number to divide by 12.5:");
            
            // Get user input for third operation
            string input3 = Console.ReadLine();
            decimal number3;
            
            // Parse the input with error handling
            if (decimal.TryParse(input3, out number3))
            {
                // Divide by 12.5 and store the result
                decimal result3 = number3 / 12.5m;
                
                // Display the result to the console
                Console.WriteLine($"Result: {number3} ÷ 12.5 = {result3}\n");
            }
            else
            {
                // Inform user of invalid input
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }

            // Fourth operation: Check if input is greater than 50
            Console.WriteLine("Enter a number to check if it's greater than 50:");
            
            // Get user input for fourth operation
            string input4 = Console.ReadLine();
            decimal number4;
            
            // Parse the input with error handling
            if (decimal.TryParse(input4, out number4))
            {
                // Check if the number is greater than 50 (boolean comparison)
                bool isGreaterThan50 = number4 > 50;
                
                // Display the boolean result to the console
                Console.WriteLine($"Result: {number4} > 50 = {isGreaterThan50}\n");
            }
            else
            {
                // Inform user of invalid input
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }

            // Fifth operation: Find remainder when divided by 7
            Console.WriteLine("Enter a number to find remainder when divided by 7:");
            
            // Get user input for fifth operation
            string input5 = Console.ReadLine();
            decimal number5;
            
            // Parse the input with error handling
            if (decimal.TryParse(input5, out number5))
            {
                // Calculate remainder using modulus operator (%)
                // Note: modulus operator works differently with decimal types in C#
                // For decimals, we use the remainder operator
                decimal remainder = number5 % 7;
                
                // Display the remainder to the console
                Console.WriteLine($"Result: {number5} % 7 = {remainder}\n");
            }
            else
            {
                // Inform user of invalid input
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }

            // Keep console window open until user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}