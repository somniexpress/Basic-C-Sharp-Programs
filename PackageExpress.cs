using System;

namespace PackageExpressShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            string weightInput = Console.ReadLine(); // Read user input as string
            decimal weight = decimal.Parse(weightInput); // Convert input to decimal for precise calculation

            // Check if weight exceeds 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End program if weight is too high
            }

            // Prompt user for package width
            Console.WriteLine("Please enter the package width:");
            string widthInput = Console.ReadLine();
            decimal width = decimal.Parse(widthInput);

            // Prompt user for package height
            Console.WriteLine("Please enter the package height:");
            string heightInput = Console.ReadLine();
            decimal height = decimal.Parse(heightInput);

            // Prompt user for package length
            Console.WriteLine("Please enter the package length:");
            string lengthInput = Console.ReadLine();
            decimal length = decimal.Parse(lengthInput);

            // Calculate total dimensions (width + height + length)
            decimal dimensionsTotal = width + height + length;

            // Check if total dimensions exceed 50
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End program if dimensions are too large
            }

            // Calculate shipping quote:
            // Multiply width * height * length to get volume
            decimal volume = width * height * length;
            // Multiply volume by weight
            decimal product = volume * weight;
            // Divide by 100 to get the quote amount
            decimal quote = product / 100;

            // Display the quote formatted as currency with two decimal places
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Keep console open until user presses a key
            Console.ReadLine();
        }
    }
}