using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // The abstract class Person
    // Abstract classes cannot be instantiated directly
    abstract class PersonOne
    {
        // Property to store the first name
        public string firstName { get; set; }

        // Property to store the last name
        public string lastName { get; set; }

        // Abstract method that must be implemented by any class that inherits from Person
        public abstract void SayName();
    }


    // Employee class inherits from the abstract Person class
    class Employee : PersonOne
    {
        // Implementation of the abstract SayName() method
        // This method displays the full name of the employee
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
