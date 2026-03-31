using System;

namespace MathOperationsApp
{
    /// <summary>
    /// This class contains three mathematical operation methods.
    /// Each method takes an integer parameter and returns an integer result.
    /// This class is in a separate .cs file for better code organization.
    /// </summary>
    public class MathOperations
    {
        /// <summary>
        /// Method 1: Doubles the input value
        /// </summary>
        /// <param name="number">The integer to be doubled</param>
        /// <returns>The result of multiplying the input by 2</returns>
        public int DoubleNumber(int number)
        {
            // Perform multiplication operation: multiply the input by 2
            // This is a basic arithmetic operation that returns twice the original value
            int result = number * 2;
            
            // Return the calculated result to the calling code
            return result;
        }
        
        /// <summary>
        /// Method 2: Squares the input value (multiplies it by itself)
        /// </summary>
        /// <param name="number">The integer to be squared</param>
        /// <returns>The result of multiplying the input by itself</returns>
        public int SquareNumber(int number)
        {
            // Perform exponentiation operation: multiply the number by itself
            // This calculates the square of the input (number^2)
            int result = number * number;
            
            // Return the squared result to the calling code
            return result;
        }
        
        /// <summary>
        /// Method 3: Adds 10 to the input value
        /// </summary>
        /// <param name="number">The integer to be increased</param>
        /// <returns>The result of adding 10 to the input</returns>
        public int AddTen(int number)
        {
            // Perform addition operation: add 10 to the input number
            // This increases the original value by 10
            int result = number + 10;
            
            // Return the incremented result to the calling code
            return result;
        }
        
        /// <summary>
        /// Bonus Method: Subtracts 5 from the input value
        /// (Additional method to demonstrate more math operations)
        /// </summary>
        /// <param name="number">The integer to be decreased</param>
        /// <returns>The result of subtracting 5 from the input</returns>
        public int SubtractFive(int number)
        {
            // Perform subtraction operation: subtract 5 from the input number
            int result = number - 5;
            
            // Return the decremented result
            return result;
        }
        
        /// <summary>
        /// Bonus Method: Divides the input by 2 (integer division)
        /// </summary>
        /// <param name="number">The integer to be divided</param>
        /// <returns>The result of integer division by 2</returns>
        public int DivideByTwo(int number)
        {
            // Perform division operation: divide the input by 2
            // Note: Integer division truncates (removes) any remainder
            int result = number / 2;
            
            // Return the division result
            return result;
        }
    }
}

//program.cs

using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display application header with formatting
            Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           MATH OPERATIONS WITH CUSTOM CLASS              ║");
            Console.WriteLine("║                     Demonstration                        ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
            
            // ========== CREATE INSTANCE OF THE MATHOPERATIONS CLASS ==========
            // To use the methods from our separate class, we need to create an object
            // This is called instantiating an object from the class blueprint
            MathOperations mathOps = new MathOperations();
            
            // ========== GET USER INPUT ==========
            // Ask the user what number they want to do the math operations on
            Console.Write("\n🔢 Please enter a whole number to perform math operations on: ");
            
            // Read the user's input as a string
            string userInput = Console.ReadLine();
            
            // Variable to store the parsed integer
            int userNumber;
            
            // Try to parse the user input to an integer
            // int.TryParse returns true if conversion succeeds, false if it fails
            // This provides error handling for invalid input (like letters or symbols)
            if (int.TryParse(userInput, out userNumber))
            {
                // Display a separator for better readability
                Console.WriteLine("\n" + new string('═', 60));
                Console.WriteLine($"📊 RESULTS for number: {userNumber}");
                Console.WriteLine(new string('═', 60));
                
                // ========== CALL EACH METHOD IN TURN ==========
                // Each method is called, passing the user input as the parameter
                // The returned integer is stored and then displayed
                
                // Method 1: Double the number
                // Call the DoubleNumber method, passing userNumber as the argument
                // The method returns the doubled value, which we store in a variable
                int doubledResult = mathOps.DoubleNumber(userNumber);
                
                // Display the result of the double operation
                // Using string interpolation ($"") for clean formatting
                Console.WriteLine($"✨ Double Operation:     {userNumber} × 2 = {doubledResult}");
                
                // Method 2: Square the number
                // Call the SquareNumber method, passing userNumber as the argument
                // This returns the number multiplied by itself
                int squaredResult = mathOps.SquareNumber(userNumber);
                
                // Display the result of the square operation
                Console.WriteLine($"🔲 Square Operation:     {userNumber} × {userNumber} = {squaredResult}");
                
                // Method 3: Add 10 to the number
                // Call the AddTen method, passing userNumber as the argument
                // This returns the number increased by 10
                int addedResult = mathOps.AddTen(userNumber);
                
                // Display the result of the addition operation
                Console.WriteLine($"➕ Addition Operation:   {userNumber} + 10 = {addedResult}");
                
                // ========== BONUS METHODS (Optional Demonstrations) ==========
                // These demonstrate additional math operations that could be added
                Console.WriteLine("\n" + new string('─', 60));
                Console.WriteLine("🎯 BONUS OPERATIONS:");
                Console.WriteLine(new string('─', 60));
                
                // Bonus Method 1: Subtract 5
                int subtractedResult = mathOps.SubtractFive(userNumber);
                Console.WriteLine($"➖ Subtraction:          {userNumber} - 5 = {subtractedResult}");
                
                // Bonus Method 2: Divide by 2
                int dividedResult = mathOps.DivideByTwo(userNumber);
                Console.WriteLine($"➗ Division:             {userNumber} ÷ 2 = {dividedResult} (integer division)");
                
                // Display a summary of all operations
                Console.WriteLine("\n" + new string('═', 60));
                Console.WriteLine("📋 OPERATION SUMMARY:");
                Console.WriteLine(new string('═', 60));
                Console.WriteLine($"   Original number:      {userNumber}");
                Console.WriteLine($"   Doubled:              {doubledResult}");
                Console.WriteLine($"   Squared:              {squaredResult}");
                Console.WriteLine($"   Added 10:             {addedResult}");
                Console.WriteLine($"   Subtracted 5:         {subtractedResult}");
                Console.WriteLine($"   Divided by 2:         {dividedResult}");
            }
            else
            {
                // Handle invalid input (non-integer values)
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n❌ ERROR: Invalid input! Please enter a valid whole number.");
                Console.WriteLine("   Example valid inputs: 5, 10, 42, -7");
                Console.ResetColor();
            }
            
            // ========== PROGRAM COMPLETION ==========
            // Display message indicating program has finished execution
            Console.WriteLine("\n" + new string('★', 60));
            Console.WriteLine("   Program execution completed!");
            Console.WriteLine("   Press any key to exit...");
            Console.WriteLine(new string('★', 60));
            
            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}