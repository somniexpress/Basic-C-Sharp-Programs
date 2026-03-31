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
            // Create a list of strings that has at least two identical strings in the list
            // This list contains letters with duplicates to demonstrate duplicate detection
            // Using letters makes it easy to understand the concept
            List<string> letterList = new List<string>();
            
            // Add strings to the list - note the duplicates
            // 'C' appears twice in this list to demonstrate duplicate detection
            letterList.Add("A");  // Index 0 - Unique (first occurrence)
            letterList.Add("B");  // Index 1 - Unique (first occurrence)
            letterList.Add("C");  // Index 2 - Unique (first occurrence)
            letterList.Add("D");  // Index 3 - Unique (first occurrence)
            letterList.Add("C");  // Index 4 - Duplicate (second occurrence of C)
            letterList.Add("E");  // Index 5 - Unique (first occurrence)
            letterList.Add("F");  // Index 6 - Unique (first occurrence)
            letterList.Add("B");  // Index 7 - Duplicate (second occurrence of B)
            letterList.Add("G");  // Index 8 - Unique (first occurrence)
            letterList.Add("A");  // Index 9 - Duplicate (second occurrence of A)
            
            // Display header for the duplicate detection demonstration
            Console.WriteLine("\n\n=== DUPLICATE DETECTION USING FOREACH LOOP ===");
            Console.WriteLine("The list contains the following items:");
            
            // Display all items in the list with their indices for reference
            for (int i = 0; i < letterList.Count; i++)
            {
                Console.WriteLine($"  Index {i}: {letterList[i]}");
            }
            
            Console.WriteLine("\n--- ANALYZING EACH ITEM FOR DUPLICATES ---");
            
            // Create a HashSet to track items that have already been seen
            // HashSet is a collection that only stores unique values
            // It provides O(1) lookup to check if an item has appeared before
            HashSet<string> seenItems = new HashSet<string>();
            
            // Create a list to track items that are duplicates (for optional display)
            // This helps demonstrate which items are duplicates
            List<string> duplicateItems = new List<string>();
            
            // FOREACH LOOP: Evaluates each item in the list
            // foreach is ideal when you need to process every item in a collection
            // without needing to know the index position
            foreach (string currentItem in letterList)
            {
                // Check if the current item has already appeared in the list
                // The HashSet's Contains method checks if the item exists in the collection
                // This is the key logic that determines if an item is unique or a duplicate
                if (seenItems.Contains(currentItem))
                {
                    // This block executes when the item has been seen before
                    // The item is a DUPLICATE (second, third, etc. occurrence)
                    Console.WriteLine($"{currentItem} - this item is a DUPLICATE");
                    
                    // Add to duplicate tracking list for summary (optional)
                    duplicateItems.Add(currentItem);
                }
                else
                {
                    // This block executes when the item has NOT been seen before
                    // The item is UNIQUE (first occurrence)
                    Console.WriteLine($"{currentItem} - this item is UNIQUE");
                    
                    // Add the current item to the HashSet so future occurrences
                    // will be identified as duplicates
                    // This is crucial for tracking what has been seen
                    seenItems.Add(currentItem);
                }
            }
            
            // Display a summary of the duplicate detection results
            Console.WriteLine("\n--- DUPLICATE DETECTION SUMMARY ---");
            Console.WriteLine($"Total items processed: {letterList.Count}");
            Console.WriteLine($"Unique items found: {seenItems.Count}");
            Console.WriteLine($"Duplicate items found: {duplicateItems.Count}");
            
            // Display the unique items (items that appeared at least once)
            Console.Write("\nUnique items (first occurrences): ");
            foreach (string uniqueItem in seenItems)
            {
                Console.Write($"{uniqueItem} ");
            }
            Console.WriteLine();
            
            // Display the duplicate items (items that appeared more than once)
            if (duplicateItems.Count > 0)
            {
                Console.Write("Duplicate items (subsequent occurrences): ");
                foreach (string dupItem in duplicateItems)
                {
                    Console.Write($"{dupItem} ");
                }
                Console.WriteLine();
            }
            
            // Explain how the foreach loop with HashSet works
            Console.WriteLine("\n--- HOW THIS WORKS ---");
            Console.WriteLine("1. The foreach loop iterates through each item in the list in order");
            Console.WriteLine("2. A HashSet called 'seenItems' tracks all unique items encountered");
            Console.WriteLine("3. For each item, we check if it's already in the HashSet:");
            Console.WriteLine("   - If YES: The item is a DUPLICATE (has appeared before)");
            Console.WriteLine("   - If NO: The item is UNIQUE (first time seeing it)");
            Console.WriteLine("4. Unique items are added to the HashSet for future duplicate detection");
            Console.WriteLine("5. This approach correctly identifies duplicates regardless of how many times they appear");
            
            // Demonstrate with a more complex example using programming languages
            Console.WriteLine("\n\n=== ADDITIONAL EXAMPLE: PROGRAMMING LANGUAGES WITH DUPLICATES ===");
            
            // Create a list of programming languages with duplicates
            List<string> languages = new List<string>
            {
                "C#",       // Index 0 - Unique
                "Python",   // Index 1 - Unique
                "Java",     // Index 2 - Unique
                "C#",       // Index 3 - Duplicate
                "JavaScript", // Index 4 - Unique
                "Python",   // Index 5 - Duplicate
                "Ruby",     // Index 6 - Unique
                "Java",     // Index 7 - Duplicate
                "Go",       // Index 8 - Unique
                "C#"        // Index 9 - Duplicate (third occurrence)
            };
            
            Console.WriteLine("Analyzing programming languages list:");
            
            // Reset the HashSet for this new example
            HashSet<string> seenLanguages = new HashSet<string>();
            
            // Use foreach loop to evaluate each language
            foreach (string language in languages)
            {
                // Check if this language has been seen before
                if (seenLanguages.Contains(language))
                {
                    // This is a duplicate occurrence
                    Console.WriteLine($"{language} - this item is a DUPLICATE");
                }
                else
                {
                    // This is the first occurrence (unique so far)
                    Console.WriteLine($"{language} - this item is UNIQUE");
                    // Add to HashSet to detect future duplicates
                    seenLanguages.Add(language);
                }
            }
            
            // Final summary statistics
            Console.WriteLine($"\nSummary: {languages.Count} total items, {seenLanguages.Count} unique values");
            
            // ========== LIST WITH DUPLICATE STRINGS (PREVIOUS SEARCH EXAMPLE) ==========
            // This section is kept for compatibility with previous requirements
            // Create a list of strings that has at least two identical strings in the list
            // This list contains programming languages with duplicates to demonstrate multiple matches
            List<string> duplicateList = new List<string>();
            
            // Add strings to the list - note the duplicates
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
            List<int> matchingIndices = new List<int>();
            
            // Initialize a counter to track total matches found
            int matchCount = 0;
            
            // Display search header
            Console.WriteLine("\n--- SEARCH RESULTS ---");
            
            // Loop that iterates through the list to find ALL matching text
            // No break statement is used to ensure we find ALL occurrences
            for (int i = 0; i < duplicateList.Count; i++)
            {
                // Check if the current list item matches the search text
                if (duplicateList[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    // Match found! Add the index to our collection
                    matchingIndices.Add(i);
                    matchCount++;
                    
                    // Display the index of the matching list item
                    Console.WriteLine($"✓ Match #{matchCount} found at index {i}: {duplicateList[i]}");
                }
            }
            
            // After the loop completes, check if any matches were found
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
                Console.Write("  Indices: ");
                for (int i = 0; i < matchingIndices.Count; i++)
                {
                    if (i > 0) Console.Write(", ");
                    Console.Write(matchingIndices[i]);
                }
                Console.WriteLine();
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