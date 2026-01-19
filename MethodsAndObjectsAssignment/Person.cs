using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    // Define a base class called Person
    public class Person
    {
        
    // Property to store the first name of the person
    public string FirstName { get; set; }

        // Property to store the last name of the person
        public string LastName { get; set; }

        // Void method that prints the full name of the person
        public void SayName()
        {
            // Write the full name to the console in the format "Name: [full name]"
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    // Define a class called Employee that inherits from Person
    public class Employee : Person
    {
        // Property to store the employee's ID
        public int Id { get; set; }
    }
}
