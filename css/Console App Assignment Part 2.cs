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
            
            // ========== INFINITE LOOP DEMONSTRATION ==========
            // The following loop was originally an infinite loop
            // Below is the FIXED version with comments explaining the solution
            
            /*
            // ORIGINAL INFINITE LOOP (commented out to prevent execution):
            // This loop would run forever because the condition never becomes false
            // int counter = 0;
            // while (counter < 10)
            // {
            //     Console.WriteLine($"Loop iteration: {counter}");
            //     // ERROR: counter is never incremented, so it always stays 0
            //     // This creates an infinite loop because 0 < 10 is always true
            // }
            */
            
            // FIXED LOOP: The infinite loop has been corrected
            // The fix was adding an increment statement to change the loop variable
            // This ensures the condition eventually becomes false
            Console.WriteLine("\n=== DEMONSTRATING FIXED LOOP ===");
            int counter = 0;  // Initialize counter variable to control loop execution
            
            // While loop that executes as long as the condition is true
            // Condition: counter < 10
            while (counter < 10)
            {
                // Display the current iteration number
                Console.WriteLine($"Loop iteration: {counter}");
                
                // FIX: Increment the counter variable by 1 each iteration
                // This is the key change that fixes the infinite loop
                // Without this line, counter would always be 0 and the loop would never end
                // With this line, counter increases from 0 to 1, 2, 3... until it reaches 10
                // When counter reaches 10, the condition (10 < 10) becomes false and the loop exits
                counter++;  // This is equivalent to: counter = counter + 1;
            }
            
            // Explanation of the fix:
            // 1. The infinite loop occurred because the loop variable 'counter' never changed
            // 2. The condition 'counter < 10' was always true since counter remained at 0
            // 3. Adding 'counter++' increments the counter by 1 each iteration
            // 4. After 10 iterations, counter becomes 10, making the condition false
            // 5. The loop then terminates naturally
            
            Console.WriteLine("\nLoop completed successfully after 10 iterations!");
            
            // SECOND LOOP: Prints off each string in the array one at a time
            // This loop displays the modified array contents to the console
            Console.WriteLine("\n=== MODIFIED ARRAY CONTENTS ===");
            for (int i = 0; i < myStrings.Length; i++)
            {
                // Output each string in the array on its own line
                Console.WriteLine(myStrings[i]);
            }
            
            // Additional demonstration of preventing infinite loops with different approaches
            Console.WriteLine("\n=== ADDITIONAL LOOP EXAMPLES ===");
            
            // Example 1: For loop - naturally prevents infinite loops when properly configured
            // For loops have built-in initialization, condition, and increment
            Console.WriteLine("For loop example (automatically prevents infinite loops):");
            for (int i = 0; i < 5; i++)  // i++ ensures the loop progresses
            {
                Console.WriteLine($"  For loop iteration: {i}");
            }
            
            // Example 2: While loop with user-controlled exit condition
            // This shows another way to avoid infinite loops by using a flag
            Console.WriteLine("\nWhile loop with user-controlled exit (type 'exit' to stop):");
            bool continueLoop = true;
            int userCounter = 0;
            
            while (continueLoop && userCounter < 3)  // Two conditions prevent infinite looping
            {
                Console.WriteLine($"  Automated iteration {userCounter + 1}");
                userCounter++;
                
                // In a real scenario, you might check user input here
                // For demonstration, we'll just limit to 3 iterations
                if (userCounter >= 3)
                {
                    continueLoop = false;  // Flag prevents infinite loop
                }
            }
            
            Console.WriteLine("\nAll loops executed successfully without infinite looping!");
            
            // Pause the console so the user can see the results before exiting
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}