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
            
            // ========== LIST WITH DUPLICATE STRINGS ==========
            // Create a list of strings that has at least two identical strings
            // This list contains programming languages with duplicates to demonstrate multiple matches
            List<string> duplicateList = new List<string>();
            
            // Add strings to the list - note the duplicates
            // "C#" appears at index 0 and index 5 (duplicate)
            // "Python" appears at index 1 and index 8 (duplicate)
            // "JavaScript" appears at index 2 (unique in this list)
            // "Java" appears at index 3 and index 9 (duplicate)
            // "Ruby" appears at index 4 (unique in this list)
            // "Swift" appears at index 6 (unique)
            // "Kotlin" appears at index 7 (unique)
            duplicateList.Add("C#");           // Index 0
            duplicateList.Add("Python");       // Index 1
            duplicateList.Add("JavaScript");   // Index 2
            duplicateList.Add("Java");         // Index 3
            duplicateList.Add("Ruby");         // Index 4
            duplicateList.Add("C#");           // Index 5 - DUPLICATE of index 0
            duplicateList.Add("Swift");        // Index 6
            duplicateList.Add("Kotlin");       // Index 7
            duplicateList.Add("Python");       // Index 8 - DUPLICATE of index 1
            duplicateList.Add("Java");         // Index 9 - DUPLICATE of index 3
            
            // Display header for the duplicate list search functionality
            Console.WriteLine("\n\n=== DUPLICATE LIST SEARCH DEMONSTRATION ===");
            Console.WriteLine("The list contains programming languages WITH duplicates:");
            
            // Display all items in the list with their indices for reference
            for (int i = 0; i < duplicateList.Count; i++)
            {
                Console.WriteLine($"  Index {i}: {duplicateList[i]}");
            }
            
            // Display note about duplicates to help user understand
            Console.WriteLine("\nNOTE: This list contains duplicates:");
            Console.WriteLine("  • 'C#' appears at indices 0 and 5");
            Console.WriteLine("  • 'Python' appears at indices 1 and 8");
            Console.WriteLine("  • 'Java' appears at indices 3 and 9");
            
            // Ask the user to input text to search for in the list
            Console.Write("\nEnter a programming language to search for: ");
            string searchText = Console.ReadLine();
            
            // Initialize a list to store all indices where matches are found
            // This will collect multiple indices since duplicates exist
            List<int> matchingIndices = new List<int>();
            
            // Initialize a counter to track total matches found
            int matchCount = 0;
            
            // Display search header
            Console.WriteLine("\n--- SEARCH RESULTS ---");
            
            // Loop that iterates through the list to find ALL matching text
            // IMPORTANT: No break statement is used in this loop
            // This ensures the loop continues to find ALL occurrences of the search text
            // Unlike the previous example where we stopped at the first match,
            // this loop will iterate through the ENTIRE list to find every match
            for (int i = 0; i < duplicateList.Count; i++)
            {
                // Check if the current list item matches the search text
                // Using StringComparison.OrdinalIgnoreCase for case-insensitive search
                // This allows "c#" to match "C#" regardless of case
                if (duplicateList[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    // Match found! Add the index to our collection
                    matchingIndices.Add(i);
                    matchCount++;
                    
                    // Display the index of the matching list item as we find it
                    // Since there's no break, this will show ALL matches found
                    Console.WriteLine($"✓ Match #{matchCount} found at index {i}: {duplicateList[i]}");
                    
                    // NOTE: No break statement here - we continue searching through
                    // the entire list to find ALL occurrences of the search text
                }
            }
            
            // After the loop completes, check if any matches were found
            // This code executes after checking EVERY item in the list
            if (matchCount == 0)
            {
                // Tell the user their input is not on the list
                Console.WriteLine($"✗ '{searchText}' was NOT found in the list.");
                Console.WriteLine($"  The loop checked all {duplicateList.Count} items but no matches were found.");
            }
            else
            {
                // Display summary of all matches found
                Console.WriteLine($"\n--- SEARCH SUMMARY ---");
                Console.WriteLine($"Found {matchCount} match(es) for '{searchText}':");
                
                // Display all indices where matches were found
                Console.Write("  Indices: ");
                for (int i = 0; i < matchingIndices.Count; i++)
                {
                    if (i > 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(matchingIndices[i]);
                }
                Console.WriteLine();
                
                // Display the values at each matching index
                Console.WriteLine("  Values:");
                foreach (int index in matchingIndices)
                {
                    Console.WriteLine($"    Index {index}: {duplicateList[index]}");
                }
                
                // Demonstrate the difference from the previous search
                Console.WriteLine("\n--- IMPORTANT NOTE ---");
                Console.WriteLine("Unlike the previous search example which used 'break' to stop at the first match,");
                Console.WriteLine("this loop does NOT contain a break statement.");
                Console.WriteLine("This allows the loop to find and display ALL occurrences of the search text,");
                Console.WriteLine("including duplicates, by iterating through the ENTIRE list.");
            }
            
            // Additional demonstration showing the difference with break vs no break
            Console.WriteLine("\n\n=== COMPARISON: WITH BREAK vs WITHOUT BREAK ===");
            Console.WriteLine("┌─────────────────────┬──────────────────────────────────────────────┐");
            Console.WriteLine("│ Search Approach     │ Behavior                                     │");
            Console.WriteLine("├─────────────────────┼──────────────────────────────────────────────┤");
            Console.WriteLine("│ With 'break'        │ Stops at first match, finds only ONE result │");
            Console.WriteLine("│ Without 'break'     │ Continues through entire list, finds ALL    │");
            Console.WriteLine("│                     │ matches including duplicates                 │");
            Console.WriteLine("└─────────────────────┴──────────────────────────────────────────────┘");
            
            // Optional: Show what would happen if break was used (for educational purposes)
            Console.WriteLine("\n--- WHAT IF 'break' WAS USED? ---");
            Console.WriteLine("If this loop contained a 'break' statement, it would have stopped");
            Console.WriteLine("at the first match and would have missed any additional duplicates.");
            Console.WriteLine("For example, searching for 'C#' would only show index 0 and miss index 5.");
            
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