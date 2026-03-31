using System;
using System.Collections.Generic;

namespace StringArrayAppender
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional array of strings with initial values
            // This array will store the base strings that will be modified
            string[] myStrings = new string[] 
            { 
                "Hello", 
                "Good morning", 
                "Welcome", 
                "Greetings", 
                "Hi there" 
            };
            
            // Display the original array contents to the user
            Console.WriteLine("=== ORIGINAL ARRAY CONTENTS ===");
            for (int i = 0; i < myStrings.Length; i++)
            {
                Console.WriteLine($"Index {i}: {myStrings[i]}");
            }
            
            // Ask the user to input some text
            // This text will be appended to each string in the array
            Console.Write("\nEnter some text to append to each string: ");
            string userInput = Console.ReadLine();
            
            // FIRST LOOP: Iterates through each string in the array
            // This loop adds the user's text to the end of each string
            // No output is produced during this loop - it only modifies the array
            for (int i = 0; i < myStrings.Length; i++)
            {
                // Append the user's input to the current string
                // The + operator concatenates (joins) two strings together
                // The result is stored back into the same array position
                myStrings[i] = myStrings[i] + userInput;
            }
            
            // ========== LOOP WITH < OPERATOR DEMONSTRATION ==========
            // This loop uses the "<" (less than) operator as the comparison condition
            // The loop continues as long as the counter is LESS THAN the specified limit
            Console.WriteLine("\n=== LOOP USING < OPERATOR ===");
            Console.WriteLine("This loop runs while counter < 5 (counter is less than 5)");
            Console.WriteLine("--------------------------------------------------------");
            
            // Initialize counter variable starting at 0
            int counter1 = 0;
            
            // While loop condition uses "<" operator
            // This loop will execute while counter1 is less than 5
            // The loop will stop when counter1 reaches 5 (not including 5)
            while (counter1 < 5)
            {
                // Display the current iteration with explanation
                Console.WriteLine($"Iteration {counter1}: counter1 = {counter1} which is < 5, so loop continues");
                
                // Increment counter to eventually make the condition false
                counter1++;
            }
            
            // Show final result after loop completes
            Console.WriteLine($"\nLoop completed! Final counter1 value = {counter1}");
            Console.WriteLine($"The condition 'counter1 < 5' became false when counter1 reached {counter1}");
            Console.WriteLine($"Total iterations executed: {counter1} (counter values 0 through {counter1 - 1})");
            
            // ========== LOOP WITH <= OPERATOR DEMONSTRATION ==========
            // This loop uses the "<=" (less than or equal to) operator as the comparison condition
            // The loop continues as long as the counter is LESS THAN OR EQUAL TO the specified limit
            Console.WriteLine("\n\n=== LOOP USING <= OPERATOR ===");
            Console.WriteLine("This loop runs while counter <= 5 (counter is less than or equal to 5)");
            Console.WriteLine("--------------------------------------------------------------");
            
            // Initialize counter variable starting at 0
            int counter2 = 0;
            
            // While loop condition uses "<=" operator
            // This loop will execute while counter2 is less than or equal to 5
            // The loop will stop when counter2 exceeds 5 (when it reaches 6)
            while (counter2 <= 5)
            {
                // Display the current iteration with explanation
                Console.WriteLine($"Iteration {counter2}: counter2 = {counter2} which is <= 5, so loop continues");
                
                // Increment counter to eventually make the condition false
                counter2++;
            }
            
            // Show final result after loop completes
            Console.WriteLine($"\nLoop completed! Final counter2 value = {counter2}");
            Console.WriteLine($"The condition 'counter2 <= 5' became false when counter2 reached {counter2}");
            Console.WriteLine($"Total iterations executed: {counter2} (counter values 0 through {counter2 - 1})");
            
            // ========== COMPARISON OF BOTH LOOP TYPES ==========
            Console.WriteLine("\n\n=== COMPARISON: < OPERATOR vs <= OPERATOR ===");
            Console.WriteLine("┌──────────────┬────────────────┬──────────────────────┬─────────────────┐");
            Console.WriteLine("│ Operator     │ Condition      │ Loop Executes While  │ Total Iterations│");
            Console.WriteLine("├──────────────┼────────────────┼──────────────────────┼─────────────────┤");
            Console.WriteLine("│ <            │ counter < 5    │ 0, 1, 2, 3, 4       │ 5 iterations    │");
            Console.WriteLine("│ <=           │ counter <= 5   │ 0, 1, 2, 3, 4, 5    │ 6 iterations    │");
            Console.WriteLine("└──────────────┴────────────────┴──────────────────────┴─────────────────┘");
            
            Console.WriteLine("\nKey Differences Explained:");
            Console.WriteLine("• The '<' operator loop stops BEFORE reaching the limit (5)");
            Console.WriteLine("• The '<=' operator loop includes the limit value (5) as a valid iteration");
            Console.WriteLine("• '<' executes 5 iterations (0-4), '<=' executes 6 iterations (0-5)");
            Console.WriteLine("• The '<=' operator runs one additional iteration compared to '<'");
            
            // ========== PRACTICAL EXAMPLE WITH ARRAYS ==========
            Console.WriteLine("\n\n=== PRACTICAL EXAMPLE: Looping Through Arrays ===");
            
            // Create a sample array to demonstrate practical usage
            string[] fruits = new string[] { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
            
            Console.WriteLine("Array contents with 5 elements (indices 0-4):");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"  Index {i}: {fruits[i]}");
            }
            
            // Demonstrate using < operator with arrays (standard practice)
            Console.WriteLine("\nUsing < operator to loop through array (recommended):");
            Console.WriteLine("for (int i = 0; i < fruits.Length; i++)");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"  Iteration {i}: {fruits[i]}");
            }
            
            // Demonstrate using <= operator with arrays (requires length - 1)
            Console.WriteLine("\nUsing <= operator to loop through array (alternative method):");
            Console.WriteLine("for (int i = 0; i <= fruits.Length - 1; i++)");
            for (int i = 0; i <= fruits.Length - 1; i++)
            {
                Console.WriteLine($"  Iteration {i}: {fruits[i]}");
            }
            
            Console.WriteLine("\nNote: When working with arrays, '<' is typically preferred");
            Console.WriteLine("because it directly uses the array's Length property without subtraction.");
            
            // ========== LIST OF UNIQUE STRINGS ==========
            // Create a list of strings where each item is unique
            // This list contains programming languages with no duplicates
            List<string> uniqueItems = new List<string>();
            
            // Add unique strings to the list
            // Each item appears only once, ensuring uniqueness
            uniqueItems.Add("C#");           // Index 0
            uniqueItems.Add("Python");       // Index 1
            uniqueItems.Add("JavaScript");   // Index 2
            uniqueItems.Add("Java");         // Index 3
            uniqueItems.Add("Ruby");         // Index 4
            uniqueItems.Add("Swift");        // Index 5
            uniqueItems.Add("Kotlin");       // Index 6
            uniqueItems.Add("TypeScript");   // Index 7
            uniqueItems.Add("Go");           // Index 8
            uniqueItems.Add("Rust");         // Index 9
            
            // Display header for the search functionality
            Console.WriteLine("\n\n=== STRING LIST SEARCH DEMONSTRATION ===");
            Console.WriteLine("The list contains the following unique programming languages:");
            
            // Display all items in the list with their indices for reference
            for (int i = 0; i < uniqueItems.Count; i++)
            {
                Console.WriteLine($"  Index {i}: {uniqueItems[i]}");
            }
            
            // Ask the user to input text to search for in the list
            Console.Write("\nEnter a programming language to search for: ");
            string searchText = Console.ReadLine();
            
            // Initialize a flag to track if a match was found
            // This flag helps determine whether to show "not found" message
            bool matchFound = false;
            
            // Initialize variable to store the index of the match
            // Will only be set if a match is found
            int foundIndex = -1;
            
            // Loop that iterates through the list to find matching text
            // This loop will stop early once a match is found (uses break statement)
            Console.WriteLine("\nSearching...");
            
            // Create a separate counter to track search iterations
            int searchIterations = 0;
            
            for (int i = 0; i < uniqueItems.Count; i++)
            {
                searchIterations++; // Increment counter for each iteration
                
                // Check if the current list item matches the search text
                // Using StringComparison.OrdinalIgnoreCase for case-insensitive search
                // This allows "c#" to match "C#" regardless of case
                if (uniqueItems[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    // Match found! Store the index and set the flag to true
                    matchFound = true;
                    foundIndex = i;
                    
                    // Display the index of the matching list item
                    Console.WriteLine($"✓ Match found at index {i} after {searchIterations} search iteration(s).");
                    Console.WriteLine($"  Item at index {i}: {uniqueItems[i]}");
                    
                    // BREAK: Stop the loop from executing once a match has been found
                    // This is the key statement that exits the loop early
                    // Without this break, the loop would continue searching through
                    // all remaining items even though we already found what we need
                    break;
                }
                else
                {
                    // Optional: Show search progress (commented out to reduce output)
                    // Console.WriteLine($"  Checking index {i}: {uniqueItems[i]} - no match");
                }
            }
            
            // Check if the user's input wasn't found in the list
            // This code executes after the loop completes (either by break or finishing)
            if (!matchFound)
            {
                // Tell the user their input is not on the list
                Console.WriteLine($"✗ '{searchText}' was NOT found in the list.");
                Console.WriteLine($"  Searched through all {searchIterations} items but no match was found.");
            }
            else
            {
                // Display success message with the found index
                Console.WriteLine($"\n✓ Successfully found '{searchText}' at index {foundIndex}.");
                Console.WriteLine($"  The loop stopped early after {searchIterations} iteration(s) instead of checking all {uniqueItems.Count} items.");
            }
            
            // Demonstrate the efficiency of using break with a second example
            Console.WriteLine("\n--- Additional Search Example (Case-Insensitive) ---");
            Console.WriteLine("Try searching for 'JAVA' or 'java' to see case-insensitive matching:");
            Console.Write("Enter another search term (or press Enter to skip): ");
            string secondSearch = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(secondSearch))
            {
                bool secondMatchFound = false;
                int secondFoundIndex = -1;
                int secondIterations = 0;
                
                for (int i = 0; i < uniqueItems.Count; i++)
                {
                    secondIterations++;
                    
                    // Case-insensitive comparison
                    if (uniqueItems[i].Equals(secondSearch, StringComparison.OrdinalIgnoreCase))
                    {
                        secondMatchFound = true;
                        secondFoundIndex = i;
                        Console.WriteLine($"✓ Found '{secondSearch}' at index {i} after {secondIterations} iteration(s).");
                        break; // Exit loop immediately when match is found
                    }
                }
                
                if (!secondMatchFound)
                {
                    Console.WriteLine($"✗ '{secondSearch}' was not found in the list after checking all {secondIterations} items.");
                }
            }
            
            // SECOND LOOP: Prints off each string in the array one at a time
            // This loop displays the modified array contents to the console
            Console.WriteLine("\n\n=== MODIFIED ARRAY CONTENTS ===");
            for (int i = 0; i < myStrings.Length; i++)
            {
                // Output each string in the array on its own line
                Console.WriteLine(myStrings[i]);
            }
            
            // Pause the console so the user can see the results before exiting
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}