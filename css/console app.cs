using System;
using System.Collections.Generic;

namespace ArrayAndListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ========== PART 1: STRING ARRAY ==========
            
            // Create a one-dimensional array of strings with predefined values
            // This array stores 5 different programming languages as examples
            string[] stringArray = new string[] 
            { 
                "C#", 
                "Python", 
                "JavaScript", 
                "Java", 
                "Ruby" 
            };
            
            // Display the available indices to help the user make a selection
            Console.WriteLine("=== STRING ARRAY DEMONSTRATION ===");
            Console.WriteLine($"The string array contains {stringArray.Length} elements (indices 0-{stringArray.Length - 1}):");
            
            // Loop through the array to show users what values are available
            // This helps users understand what index to choose
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine($"  Index {i}: {stringArray[i]}");
            }
            
            // Ask the user to select an index from the string array
            Console.Write("\nSelect an index (0-4) to view the string: ");
            string userInput = Console.ReadLine();
            
            // Try to parse the user's input to an integer
            // Use int.TryParse to safely handle non-numeric input without throwing exceptions
            if (int.TryParse(userInput, out int stringIndex))
            {
                // Check if the index is within the valid range of the array
                // Index must be >= 0 and less than the array length
                if (stringIndex >= 0 && stringIndex < stringArray.Length)
                {
                    // Display the string at the selected index
                    Console.WriteLine($"\nString at index {stringIndex}: {stringArray[stringIndex]}");
                }
                else
                {
                    // Display error message for out-of-range index
                    Console.WriteLine($"\nERROR: Index {stringIndex} does not exist. Valid indices are 0-{stringArray.Length - 1}.");
                }
            }
            else
            {
                // Display error message for invalid (non-numeric) input
                Console.WriteLine("\nERROR: Please enter a valid integer index.");
            }
            
            Console.WriteLine("\nPress Enter to continue to the integer array demo...");
            Console.ReadLine();
            Console.Clear(); // Clear console for next demonstration
            
            
            // ========== PART 2: INTEGER ARRAY ==========
            
            // Create a one-dimensional array of integers with predefined values
            // This array stores 6 different numbers as examples
            int[] intArray = new int[] 
            { 
                10, 
                25, 
                37, 
                42, 
                58, 
                63 
            };
            
            // Display the available indices to help the user make a selection
            Console.WriteLine("=== INTEGER ARRAY DEMONSTRATION ===");
            Console.WriteLine($"The integer array contains {intArray.Length} elements (indices 0-{intArray.Length - 1}):");
            
            // Loop through the array to show users what values are available
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"  Index {i}: {intArray[i]}");
            }
            
            // Ask the user to select an index from the integer array
            Console.Write("\nSelect an index (0-5) to view the integer: ");
            userInput = Console.ReadLine();
            
            // Try to parse the user's input to an integer
            if (int.TryParse(userInput, out int intIndex))
            {
                // Check if the index is within the valid range of the array
                if (intIndex >= 0 && intIndex < intArray.Length)
                {
                    // Display the integer at the selected index
                    Console.WriteLine($"\nInteger at index {intIndex}: {intArray[intIndex]}");
                }
                else
                {
                    // Display error message for out-of-range index
                    Console.WriteLine($"\nERROR: Index {intIndex} does not exist. Valid indices are 0-{intArray.Length - 1}.");
                }
            }
            else
            {
                // Display error message for invalid (non-numeric) input
                Console.WriteLine("\nERROR: Please enter a valid integer index.");
            }
            
            Console.WriteLine("\nPress Enter to continue to the string list demo...");
            Console.ReadLine();
            Console.Clear(); // Clear console for next demonstration
            
            
            // ========== PART 3: STRING LIST ==========
            
            // Create a list of strings with predefined values
            // Lists are dynamically sized collections that can grow or shrink
            List<string> stringList = new List<string>();
            
            // Add strings to the list using the Add method
            // Lists are 0-indexed just like arrays
            stringList.Add("Apple");      // Index 0
            stringList.Add("Banana");     // Index 1
            stringList.Add("Cherry");     // Index 2
            stringList.Add("Date");       // Index 3
            stringList.Add("Elderberry"); // Index 4
            
            // Display the available indices to help the user make a selection
            Console.WriteLine("=== STRING LIST DEMONSTRATION ===");
            Console.WriteLine($"The string list contains {stringList.Count} elements (indices 0-{stringList.Count - 1}):");
            
            // Loop through the list to show users what values are available
            // Note: Lists use the Count property (not Length) to get the number of elements
            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine($"  Index {i}: {stringList[i]}");
            }
            
            // Ask the user to select an index from the list
            Console.Write("\nSelect an index (0-4) to view the string: ");
            userInput = Console.ReadLine();
            
            // Try to parse the user's input to an integer
            if (int.TryParse(userInput, out int listIndex))
            {
                // Check if the index is within the valid range of the list
                // Index must be >= 0 and less than the list count
                if (listIndex >= 0 && listIndex < stringList.Count)
                {
                    // Display the string at the selected index
                    // Lists use the same bracket notation as arrays for accessing elements
                    Console.WriteLine($"\nString at index {listIndex}: {stringList[listIndex]}");
                }
                else
                {
                    // Display error message for out-of-range index
                    Console.WriteLine($"\nERROR: Index {listIndex} does not exist. Valid indices are 0-{stringList.Count - 1}.");
                }
            }
            else
            {
                // Display error message for invalid (non-numeric) input
                Console.WriteLine("\nERROR: Please enter a valid integer index.");
            }
            
            // End of program - prompt user to exit
            Console.WriteLine("\nPress any key to exit the application...");
            Console.ReadKey();
        }
    }
}