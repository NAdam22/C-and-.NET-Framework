using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    // Main program class
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate a new Employee object and initialize its properties
            Employee employee = new Employee
            {
                FirstName = "Sample", // Set the first name
                LastName = "Student", // Set the last name
                Id = 1                // Set the employee ID (optional example)
            };

            // Call the SayName() method inherited from the Person class
            employee.SayName();

            // Wait for user input before closing the console
            Console.ReadLine();
        }
    }
}
