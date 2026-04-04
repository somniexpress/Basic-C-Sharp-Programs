using System;

namespace ConsoleApp
{
    // Employee class represents an employee with unique identification and personal information
    public class Employee
    {
        // PROPERTY: Id uniquely identifies each employee
        // Used as the primary key for equality comparisons
        public int Id { get; set; }

        // PROPERTY: FirstName stores the employee's first name
        public string FirstName { get; set; }

        // PROPERTY: LastName stores the employee's last name
        public string LastName { get; set; }

        // OVERLOADED OPERATOR: == (Equality operator)
        // This allows two Employee objects to be compared using the == operator
        // The 'static' keyword means this operator belongs to the class itself, not an instance
        // The 'public' keyword makes this operator accessible from anywhere
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // NULL CHECK: If both objects are null, they are considered equal
            // ReferenceEquals checks if both references point to the same object (or both are null)
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            // NULL CHECK: If one object is null and the other is not, they are not equal
            // This prevents a NullReferenceException when accessing properties of a null object
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false;
            }

            // COMPARISON: Compare the Id properties of both Employee objects
            // Two employees are considered equal if their Id values match
            return employee1.Id == employee2.Id;
        }

        // OVERLOADED OPERATOR: != (Inequality operator)
        // When overloading ==, you MUST also overload != (they must be overloaded in pairs)
        // This operator returns the logical opposite of the == operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // Returns true if the objects are NOT equal, false if they ARE equal
            // Simply negate (reverse) the result of the == operator
            return !(employee1 == employee2);
        }

        // OVERRIDE: Equals method should be overridden when overloading == operator
        // This maintains consistency between the == operator and the .Equals() method
        // Best practice: Always override Equals when overloading ==
        public override bool Equals(object obj)
        {
            // Check if the object is null or not of type Employee
            if (obj == null || !(obj is Employee))
            {
                return false;
            }

            // Convert the object to Employee type and compare Id properties
            return this.Id == ((Employee)obj).Id;
        }

        // OVERRIDE: GetHashCode must be overridden when overriding Equals
        // This ensures objects that are equal have the same hash code
        // Required for proper functionality in hash-based collections like Dictionary and HashSet
        public override int GetHashCode()
        {
            // Return the hash code of the Id property
            // Since Id uniquely identifies an employee, it's suitable for hash code generation
            return this.Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // INSTANTIATE: Create first Employee object
            Employee employee1 = new Employee();

            // ASSIGN VALUES: Set properties for the first employee
            employee1.Id = 1001;           // Unique identifier for employee 1
            employee1.FirstName = "John";   // First name of employee 1
            employee1.LastName = "Doe";     // Last name of employee 1

            // INSTANTIATE: Create second Employee object
            Employee employee2 = new Employee();

            // ASSIGN VALUES: Set properties for the second employee
            employee2.Id = 1001;           // Same Id as employee1 (intentionally for testing equality)
            employee2.FirstName = "Jane";   // Different first name
            employee2.LastName = "Smith";   // Different last name

            // INSTANTIATE: Create third Employee object with different Id
            Employee employee3 = new Employee();

            // ASSIGN VALUES: Set properties for the third employee
            employee3.Id = 1002;           // Different Id from employee1 and employee2
            employee3.FirstName = "Bob";    // First name of employee 3
            employee3.LastName = "Johnson"; // Last name of employee 3

            // DEMONSTRATION 1: Compare employee1 and employee2 (same Id, different names)
            Console.WriteLine("--- Employee Comparison Demo ---");
            Console.WriteLine($"Employee 1: {employee1.FirstName} {employee1.LastName} (ID: {employee1.Id})");
            Console.WriteLine($"Employee 2: {employee2.FirstName} {employee2.LastName} (ID: {employee2.Id})");
            
            // USE OVERLOADED == OPERATOR: Compare using our custom equality logic
            // This will compare based on Id, not on the object references or other properties
            bool areEqual12 = employee1 == employee2;
            
            // DISPLAY RESULTS: Show whether the employees are considered equal
            Console.WriteLine($"\nAre employee1 and employee2 equal? {areEqual12}");
            Console.WriteLine("(They have the same ID, so they are considered equal despite different names)");
            
            // DEMONSTRATION 2: Compare employee1 and employee3 (different Id)
            Console.WriteLine($"\n--- Different ID Comparison ---");
            Console.WriteLine($"Employee 1: {employee1.FirstName} {employee1.LastName} (ID: {employee1.Id})");
            Console.WriteLine($"Employee 3: {employee3.FirstName} {employee3.LastName} (ID: {employee3.Id})");
            
            // USE OVERLOADED != OPERATOR: Demonstrate the inequality operator
            bool areEqual13 = employee1 == employee3;
            bool areNotEqual13 = employee1 != employee3;
            
            // DISPLAY RESULTS: Show both equality and inequality comparisons
            Console.WriteLine($"\nAre employee1 and employee3 equal? {areEqual13}");
            Console.WriteLine($"Are employee1 and employee3 not equal? {areNotEqual13}");
            Console.WriteLine("(Different IDs means they are not equal)");
            
            // DEMONSTRATION 3: Compare with null values to show operator handles nulls safely
            Console.WriteLine($"\n--- Null Safety Demonstration ---");
            Employee employee4 = null;
            
            // Use overloaded operators with null - our implementation handles null gracefully
            bool isNullEqual = employee4 == employee1;
            bool isNullNotEqual = employee4 != employee1;
            
            Console.WriteLine($"Is null employee equal to employee1? {isNullEqual}");
            Console.WriteLine($"Is null employee not equal to employee1? {isNullNotEqual}");
            
            // DEMONSTRATION 4: Show that different properties don't affect equality
            Console.WriteLine($"\n--- Equality Based Only on ID ---");
            Console.WriteLine("Even though employee1 and employee2 have different names,");
            Console.WriteLine("they are considered equal because their IDs match (1001).");
            Console.WriteLine("This demonstrates that our overloaded == operator only compares Id properties.");
            
            // WAIT FOR USER: Pause the console so the user can see all output
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}