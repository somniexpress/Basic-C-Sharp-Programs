using System;

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