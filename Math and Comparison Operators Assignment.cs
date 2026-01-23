using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print program title
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("====================================\n");

            // PERSON 1 DATA COLLECTION
            Console.WriteLine("Person 1");
            Console.WriteLine("--------");

            // Get Person 1's hourly rate from user input
            Console.Write("Please enter hourly rate: $");
            string hourlyRateInput1 = Console.ReadLine();
            
            // Convert input string to decimal for precise monetary calculations
            decimal hourlyRate1;
            while (!decimal.TryParse(hourlyRateInput1, out hourlyRate1) || hourlyRate1 <= 0)
            {
                // Handle invalid input with error message and retry
                Console.Write("Invalid input. Please enter a positive number for hourly rate: $");
                hourlyRateInput1 = Console.ReadLine();
            }

            // Get Person 1's hours worked per week from user input
            Console.Write("Please enter hours worked per week: ");
            string hoursPerWeekInput1 = Console.ReadLine();
            
            // Convert input string to decimal for precise calculations
            decimal hoursPerWeek1;
            while (!decimal.TryParse(hoursPerWeekInput1, out hoursPerWeek1) || hoursPerWeek1 <= 0 || hoursPerWeek1 > 168)
            {
                // Handle invalid input with validation (max 168 hours in a week)
                Console.Write("Invalid input. Please enter a positive number (max 168) for hours per week: ");
                hoursPerWeekInput1 = Console.ReadLine();
            }

            Console.WriteLine(); // Blank line for readability

            // PERSON 2 DATA COLLECTION
            Console.WriteLine("Person 2");
            Console.WriteLine("--------");

            // Get Person 2's hourly rate from user input
            Console.Write("Please enter hourly rate: $");
            string hourlyRateInput2 = Console.ReadLine();
            
            // Convert input string to decimal for precise monetary calculations
            decimal hourlyRate2;
            while (!decimal.TryParse(hourlyRateInput2, out hourlyRate2) || hourlyRate2 <= 0)
            {
                // Handle invalid input with error message and retry
                Console.Write("Invalid input. Please enter a positive number for hourly rate: $");
                hourlyRateInput2 = Console.ReadLine();
            }

            // Get Person 2's hours worked per week from user input
            Console.Write("Please enter hours worked per week: ");
            string hoursPerWeekInput2 = Console.ReadLine();
            
            // Convert input string to decimal for precise calculations
            decimal hoursPerWeek2;
            while (!decimal.TryParse(hoursPerWeekInput2, out hoursPerWeek2) || hoursPerWeek2 <= 0 || hoursPerWeek2 > 168)
            {
                // Handle invalid input with validation (max 168 hours in a week)
                Console.Write("Invalid input. Please enter a positive number (max 168) for hours per week: ");
                hoursPerWeekInput2 = Console.ReadLine();
            }

            Console.WriteLine(); // Blank line for readability

            // ANNUAL SALARY CALCULATIONS
            // Calculate Person 1's annual salary: hourly rate × hours per week × 52 weeks
            decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
            
            // Calculate Person 2's annual salary: hourly rate × hours per week × 52 weeks
            decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

            // DISPLAY RESULTS
            // Display Person 1's annual salary formatted as currency
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine($"${annualSalary1:N2}\n"); // N2 format shows 2 decimal places
            
            // Display Person 2's annual salary formatted as currency
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine($"${annualSalary2:N2}\n"); // N2 format shows 2 decimal places

            // INCOME COMPARISON
            // Compare salaries to see if Person 1 makes more than Person 2
            bool person1MakesMore = annualSalary1 > annualSalary2;
            
            // Display the comparison statement and result
            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.WriteLine(person1MakesMore.ToString()); // Convert boolean to string for display

            // Keep console window open until user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}