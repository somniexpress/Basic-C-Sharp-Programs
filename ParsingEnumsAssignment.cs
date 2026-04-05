using System;

namespace DayOfWeekApp
{
    // Define an enum for the days of the week
    // Enums provide a type-safe way to represent a fixed set of constants
    enum DaysOfWeek
    {
        Sunday,     // 0
        Monday,     // 1
        Tuesday,    // 2
        Wednesday,  // 3
        Thursday,   // 4
        Friday,     // 5
        Saturday    // 6
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable of the enum type to store the user's input
            DaysOfWeek currentDay;

            // Display instructions to the user
            Console.WriteLine("Welcome to the Day of the Week Validator!");
            Console.WriteLine("Please enter the current day of the week (e.g., Monday, Tuesday, etc.):");

            // Wrap the input parsing in a try/catch block to handle invalid entries
            try
            {
                // Read the user's input from the console as a string
                string userInput = Console.ReadLine();

                // Convert the string input to the corresponding enum value
                // Enum.Parse converts a string to an enum type
                // typeof(DaysOfWeek) specifies which enum to use
                // true makes the parsing case-insensitive (e.g., "monday" works)
                currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // If successful, display the validated day back to the user
                Console.WriteLine($"You entered: {currentDay}");
                Console.WriteLine($"Numeric value: {(int)currentDay} (0=Sunday through 6=Saturday)");
            }
            catch (ArgumentException)
            {
                // This catch block handles invalid input that doesn't match any enum value
                // Print the error message as specified in the requirements
                Console.WriteLine("Please enter an actual day of the week.");
                
                // Optional: Exit the application or return early since we can't proceed
                // without a valid day (uncomment the next line if needed)
                // return;
            }
            catch (Exception ex)
            {
                // Catch any other unexpected errors (e.g., null input)
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Pause the console so the user can see the output before the window closes
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}