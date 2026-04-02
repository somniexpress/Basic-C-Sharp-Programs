using System;

namespace ConsoleApp
{
    // ABSTRACT CLASS: Person serves as the base class for all person-related objects
    // Abstract classes cannot be instantiated directly and provide a template for derived classes
    public abstract class Person
    {
        // PROPERTY: firstName stores the person's first name
        // Auto-implemented property with public getter and setter
        public string firstName { get; set; }

        // PROPERTY: lastName stores the person's last name
        // Auto-implemented property with public getter and setter
        public string lastName { get; set; }

        // ABSTRACT METHOD: SayName must be implemented by any non-abstract derived class
        // This ensures all Person-derived classes have a way to display their name
        public abstract void SayName();
    }

    // INTERFACE: IQuittable defines a contract for any class that can quit or leave
    // Interfaces contain method signatures but no implementation
    // Any class implementing this interface MUST provide implementation for all its members
    public interface IQuittable
    {
        // METHOD SIGNATURE: Quit method takes no parameters and returns void
        // Classes that implement IQuittable must provide their own implementation of this method
        void Quit();
    }

    // DERIVED CLASS: Employee inherits from Person AND implements IQuittable interface
    // The colon (:) is used for both inheritance and interface implementation
    // A class can only inherit from one class but can implement multiple interfaces
    public class Employee : Person, IQuittable
    {
        // IMPLEMENTED ABSTRACT METHOD: Provides concrete implementation of SayName()
        // The 'override' keyword indicates this method replaces the abstract method from Person
        public override void SayName()
        {
            // Displays the full name with "Name: " prefix using string interpolation
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        // IMPLEMENTED INTERFACE METHOD: Provides concrete implementation of Quit() from IQuittable
        // This method must be public because interface members are implicitly public
        // The implementation can be customized to meet specific business requirements
        public void Quit()
        {
            // Custom implementation of the Quit method for Employee objects
            // This could include logging, cleanup operations, notifications, etc.
            Console.WriteLine($"{firstName} {lastName} has quit the company.");
            Console.WriteLine("Processing exit paperwork...");
            Console.WriteLine("Revoking system access...");
            Console.WriteLine("Collecting company property...");
            Console.WriteLine("Exit process completed.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // INSTANTIATE: Create a new instance of the Employee class
            // Employee is a concrete class that implements both Person and IQuittable
            Employee employee = new Employee();

            // INITIALIZE: Set the firstName property inherited from Person
            employee.firstName = "Sample";

            // INITIALIZE: Set the lastName property inherited from Person
            employee.lastName = "Student";

            // CALL INHERITED METHOD: Display the employee's name using SayName()
            // This demonstrates that Employee still has access to all Person functionality
            Console.WriteLine("--- Employee Information ---");
            employee.SayName();

            // POLYMORPHISM: Create an object of interface type IQuittable
            // An object can be referenced by its interface type if it implements that interface
            // This is a key concept in polymorphism - treating objects by what they CAN do, not what they ARE
            IQuittable quittableObject = employee;  // Implicit conversion to interface type
            
            // CALL INTERFACE METHOD: Call the Quit() method using the interface reference
            // Even though quittableObject is of type IQuittable, it refers to an Employee object
            // The runtime will execute the Employee's implementation of Quit()
            Console.WriteLine("\n--- Employee Exit Process ---");
            quittableObject.Quit();

            // DEMONSTRATE DIRECT CALL: We can also call Quit() directly on the Employee object
            // Both approaches work and produce the same result
            Console.WriteLine("\n--- Direct Call Alternative ---");
            employee.Quit();

            // ADDITIONAL DEMONSTRATION: Show that we can have a collection of different types
            // that all implement IQuittable (polymorphism in action)
            Console.WriteLine("\n--- Polymorphism Example ---");
            
            // Create another class that implements IQuittable (simulated)
            // This shows how interfaces allow different classes to be treated uniformly
            Contractor contractor = new Contractor();
            contractor.Name = "John Doe";
            
            // Create an array of IQuittable objects containing different types
            IQuittable[] quittableItems = new IQuittable[] { employee, contractor };
            
            // Loop through each item and call Quit() - each will execute its own implementation
            foreach (IQuittable item in quittableItems)
            {
                item.Quit();
                Console.WriteLine(); // Add blank line between entries
            }

            // WAIT FOR USER: Pause the console so the user can see all output
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    // ADDITIONAL CLASS: Contractor demonstrates that any class can implement IQuittable
    // This shows the flexibility of interfaces - different classes can share common behavior
    public class Contractor
    {
        public string Name { get; set; }

        // Implementing IQuittable interface with a different implementation
        // Note: This is a separate class that also implements IQuittable
        public void Quit()
        {
            Console.WriteLine($"{Name} (Contractor) has ended their contract.");
            Console.WriteLine("Final invoice generated.");
            Console.WriteLine("Contract terminated.");
        }
    }
}