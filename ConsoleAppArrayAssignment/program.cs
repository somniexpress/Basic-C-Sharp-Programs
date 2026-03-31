using System;
using System.Collections.Generic; // Required for using List<T>

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==================================================
            // SECTION 1: ONE-DIMENSIONAL ARRAY OF STRINGS
            // ==================================================
            
            // Create a one-dimensional array of strings containing programming languages
            string[] stringArray = { "C#", "Python", "JavaScript", "HTML/CSS", "SQL", "React", "Node.js" };
            
            // Display header for this section
            Console.WriteLine("=" .PadRight(50, '='));
            Console.WriteLine("STRING ARRAY DEMONSTRATION");
            Console.WriteLine("=" .PadRight(50, '='));
            
            // Display the available indices to help the user
            Console.WriteLine("\nAvailable indices in the string array: 0 to " + (stringArray.Length - 1));
            Console.WriteLine("Contents at each index:");
            
            // Loop through the array to show the user what's available at each index
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine($"  Index {i}: {stringArray[i]}");
            }
            
            // Ask the user to select an index
            Console.Write("\nPlease enter an index number (0-" + (stringArray.Length - 1) + ") to see the string at that position: ");
            
            // Try to parse the user's input as an integer
            bool isValidInput = int.TryParse(Console.ReadLine(), out int stringIndex);
            
            // Check if the input is valid AND within the bounds of the array
            if (isValidInput && stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Display the string at the selected index
                Console.WriteLine($"\n✓ String at index {stringIndex} is: \"{stringArray[stringIndex]}\"");
            }
            else
            {
                // Display error message when the user selects an index that doesn't exist
                Console.WriteLine($"\n✗ Error: Index '{stringIndex}' does not exist in the string array.");
                Console.WriteLine($"  Valid indices are 0 through {stringArray.Length - 1}.");
            }
            
            // ==================================================
            // SECTION 2: ONE-DIMENSIONAL ARRAY OF INTEGERS
            // ==================================================
            
            // Create a one-dimensional array of integers
            int[] intArray = { 42, 7, 99, 104, 25, 365, 1000, 8 };
            
            // Display header for this section
            Console.WriteLine("\n" + "=" .PadRight(50, '='));
            Console.WriteLine("INTEGER ARRAY DEMONSTRATION");
            Console.WriteLine("=" .PadRight(50, '='));
            
            // Display the available indices
            Console.WriteLine($"\nAvailable indices in the integer array: 0 to {intArray.Length - 1}");
            Console.WriteLine("Contents at each index:");
            
            // Loop through the integer array to show available values
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"  Index {i}: {intArray[i]}");
            }
            
            // Ask the user to select an index
            Console.Write($"\nPlease enter an index number (0-{intArray.Length - 1}) to see the integer at that position: ");
            
            // Parse user input
            isValidInput = int.TryParse(Console.ReadLine(), out int intIndex);
            
            // Validate the index is within the array bounds
            if (isValidInput && intIndex >= 0 && intIndex < intArray.Length)
            {
                // Display the integer at the selected index
                Console.WriteLine($"\n✓ Integer at index {intIndex} is: {intArray[intIndex]}");
            }
            else
            {
                // Display error message for invalid index selection
                Console.WriteLine($"\n✗ Error: Index '{intIndex}' does not exist in the integer array.");
                Console.WriteLine($"  Valid indices are 0 through {intArray.Length - 1}.");
            }
            
            // ==================================================
            // SECTION 3: LIST OF STRINGS
            // ==================================================
            
            // Create a list of strings (dynamically sized collection)
            List<string> stringList = new List<string>();
            
            // Add items to the list
            stringList.Add("Apple");
            stringList.Add("Banana");
            stringList.Add("Cherry");
            stringList.Add("Grapes");
            stringList.Add("Mango");
            stringList.Add("Orange");
            
            // Display header for this section
            Console.WriteLine("\n" + "=" .PadRight(50, '='));
            Console.WriteLine("STRING LIST DEMONSTRATION");
            Console.WriteLine("=" .PadRight(50, '='));
            
            // Display the available indices in the list
            Console.WriteLine($"\nAvailable indices in the string list: 0 to {stringList.Count - 1}");
            Console.WriteLine("Contents at each index:");
            
            // Loop through the list to show the user what's available
            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine($"  Index {i}: {stringList[i]}");
            }
            
            // Ask the user to select an index from the list
            Console.Write($"\nPlease enter an index number (0-{stringList.Count - 1}) to see the string in the list: ");
            
            // Parse user input
            isValidInput = int.TryParse(Console.ReadLine(), out int listIndex);
            
            // Check if the input is valid AND within the bounds of the list
            if (isValidInput && listIndex >= 0 && listIndex < stringList.Count)
            {
                // Display the string at the selected index in the list
                Console.WriteLine($"\n✓ String at list index {listIndex} is: \"{stringList[listIndex]}\"");
            }
            else
            {
                // Display error message when user selects an index that doesn't exist in the list
                Console.WriteLine($"\n✗ Error: Index '{listIndex}' does not exist in the string list.");
                Console.WriteLine($"  Valid indices are 0 through {stringList.Count - 1}.");
            }
            
            // ==================================================
            // SECTION 4: PROGRAM END
            // ==================================================
            
            // Display closing message
            Console.WriteLine("\n" + "=" .PadRight(50, '='));
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(); // Wait for user input before closing the console window
        }
    }
}