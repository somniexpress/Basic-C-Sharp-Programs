using System;
using System.Collections.Generic;

namespace DivisionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display application header with version information
            Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           INTEGER DIVISION WITH ERROR HANDLING          ║");
            Console.WriteLine("║                        Version 2.0                       ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
            
            // ========== CREATE A LIST OF INTEGERS ==========
            // Create a list of integers with diverse values for testing
            // These values are chosen to demonstrate various division scenarios
            List<int> numbers = new List<int> 
            { 
                100,    // Even number - divides cleanly by many numbers
                45,     // Odd number - shows integer division truncation
                27,     // Multiple of 3 - demonstrates exact division scenarios
                88,     // Even number - good for testing
                12,     // Small number - shows small results
                500,    // Large number - demonstrates scaling
                7,      // Prime number - shows non-even division
                36      // Perfect square - additional test case
            };
            
            // Display the list of numbers with formatting
            Console.WriteLine("\n📊 INTEGER LIST CONTENTS:");
            Console.WriteLine("   ┌─────┬─────────────┐");
            Console.WriteLine("   │ idx │    Value    │");
            Console.WriteLine("   ├─────┼─────────────┤");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"   │  {i}  │    {numbers[i],-7} │");
            }
            Console.WriteLine("   └─────┴─────────────┘");
            Console.WriteLine($"   Total numbers: {numbers.Count}");
            
            // ========== TRY/CATCH BLOCK FOR ERROR HANDLING ==========
            // The try block contains the code that might throw exceptions
            // This provides robust error handling for user input
            try
            {
                // Prompt user for divisor with clear instructions
                Console.WriteLine("\n" + new string('═', 60));
                Console.Write("🔢 Enter a number to divide each value by: ");
                
                // Read user input and attempt to convert to integer
                // Convert.ToInt32 can throw FormatException or OverflowException
                string userInput = Console.ReadLine();
                int divisor = Convert.ToInt32(userInput);
                
                // Validate that divisor is not zero before proceeding
                // This is an additional check beyond the catch block
                if (divisor == 0)
                {
                    // Manually throw a DivideByZeroException for demonstration
                    // This ensures consistent error handling through the catch block
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                
                // Display header for division results with formatting
                Console.WriteLine($"\n📊 DIVISION RESULTS (dividing by {divisor}):");
                Console.WriteLine("   ┌─────────────┬───────┬─────────────┐");
                Console.WriteLine("   │  Original   │   ÷   │   Result    │");
                Console.WriteLine("   ├─────────────┼───────┼─────────────┤");
                
                // Loop through each integer in the list
                // This loop demonstrates processing each element in a collection
                for (int i = 0; i < numbers.Count; i++)
                {
                    // Perform integer division
                    // Note: Integer division truncates decimal portion (floor for positive numbers)
                    int result = numbers[i] / divisor;
                    
                    // Display each calculation in a formatted table
                    // The remainder is calculated for additional context
                    int remainder = numbers[i] % divisor;
                    
                    // Format output based on whether division is exact
                    if (remainder == 0)
                    {
                        // Exact division - no remainder
                        Console.WriteLine($"   │  {numbers[i],-9} │  {divisor,-3}  │  {result,-9} │  ✓");
                    }
                    else
                    {
                        // Non-exact division - show remainder information
                        Console.WriteLine($"   │  {numbers[i],-9} │  {divisor,-3}  │  {result,-9} │  (remainder: {remainder})");
                    }
                }
                Console.WriteLine("   └─────────────┴───────┴─────────────┘");
                
                // Display completion message with timestamp
                Console.WriteLine($"\n✅ All divisions completed successfully at {DateTime.Now.ToShortTimeString()}!");
                Console.WriteLine($"   Processed {numbers.Count} calculations without errors.");
            }
            catch (DivideByZeroException ex)
            {
                // Handle division by zero errors
                // This occurs when attempting to divide by zero
                Console.ForegroundColor = ConsoleColor.Red; // Set text color to red for error
                Console.WriteLine("\n" + new string('═', 60));
                Console.WriteLine("❌ DIVISION BY ZERO ERROR");
                Console.WriteLine(new string('═', 60));
                Console.WriteLine($"Error Message: {ex.Message}");
                Console.WriteLine("Explanation: Division by zero is mathematically undefined.");
                Console.WriteLine("Solution: Please enter a non-zero number (e.g., 1, 2, 5, 10).");
                Console.ResetColor(); // Reset text color to default
            }
            catch (FormatException ex)
            {
                // Handle invalid input format errors
                // This occurs when user enters non-numeric text
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + new string('═', 60));
                Console.WriteLine("❌ INVALID INPUT FORMAT ERROR");
                Console.WriteLine(new string('═', 60));
                Console.WriteLine($"Error Message: {ex.Message}");
                Console.WriteLine("Explanation: You entered text that cannot be converted to a number.");
                Console.WriteLine("Solution: Please enter a valid integer (e.g., 2, 5, 10, -3).");
                Console.WriteLine("Examples of valid input: 7, 42, 100, -5");
                Console.ResetColor();
            }
            catch (OverflowException ex)
            {
                // Handle overflow errors
                // This occurs when user enters a number outside the int range
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + new string('═', 60));
                Console.WriteLine("❌ OVERFLOW ERROR");
                Console.WriteLine(new string('═', 60));
                Console.WriteLine($"Error Message: {ex.Message}");
                Console.WriteLine("Explanation: The number you entered is too large or too small.");
                Console.WriteLine("Valid range: -2,147,483,648 to 2,147,483,647");
                Console.WriteLine("Solution: Please enter a number within the valid integer range.");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                // This catch-all ensures no exception crashes the program
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + new string('═', 60));
                Console.WriteLine("❌ UNEXPECTED ERROR");
                Console.WriteLine(new string('═', 60));
                Console.WriteLine($"Error Type: {ex.GetType().Name}");
                Console.WriteLine($"Error Message: {ex.Message}");
                Console.WriteLine("Please contact support if this error persists.");
                Console.ResetColor();
            }
            finally
            {
                // Optional: Finally block executes regardless of whether an exception occurred
                // This is good for cleanup operations if needed
                Console.WriteLine("\n📋 Exception handling completed.");
            }
            
            // ========== CODE OUTSIDE THE TRY/CATCH BLOCK ==========
            // This code executes after the try/catch block completes
            // It demonstrates that program execution continues normally
            Console.WriteLine("\n" + new string('─', 60));
            Console.WriteLine("🔵 PROGRAM STATUS:");
            Console.WriteLine($"   ✓ Successfully emerged from try/catch block at {DateTime.Now.ToShortTimeString()}");
            Console.WriteLine("   ✓ Program execution has continued normally");
            Console.WriteLine("   ✓ Error handling completed - no crashes occurred");
            Console.WriteLine(new string('─', 60));
            
            // Display summary statistics based on whether errors occurred
            Console.WriteLine("\n📈 EXECUTION SUMMARY:");
            Console.WriteLine("   • The try/catch block protected the program from crashes");
            Console.WriteLine("   • All exceptions were handled gracefully");
            Console.WriteLine("   • User experience was maintained throughout");
            Console.WriteLine("   • Program continued executing after error handling");
            
            // Provide option to restart or exit
            Console.WriteLine("\n" + new string('═', 60));
            Console.WriteLine("Would you like to perform another division?");
            Console.WriteLine("   Type 'yes' to run again");
            Console.WriteLine("   Press any other key to exit");
            Console.Write("\nYour choice: ");
            string response = Console.ReadLine();
            
            // Check if user wants to restart the program
            if (response.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                // Clear console and restart
                Console.Clear();
                Main(args);
            }
            else
            {
                // Exit message
                Console.WriteLine("\n" + new string('★', 60));
                Console.WriteLine("   Thank you for using the Integer Division Application!");
                Console.WriteLine("   Goodbye!");
                Console.WriteLine(new string('★', 60));
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
}