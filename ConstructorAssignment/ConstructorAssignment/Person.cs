using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{

    // This class represents a simple Person
    class Person
    {
        // A constant variable: its value can NEVER change
        // Constants are compile-time values
        public const string Species = "Human";

        // Regular instance variables (fields)
        public string Name;
        public int Age;

        // First constructor (default constructor)
        // This constructor runs when no arguments are passed
        public Person()
        {
            Name = "Unknown"; // Sets a default name
            Age = 0;          // Sets a default age
        }

        // Second constructor that takes parameters
        // This constructor is CHAINED to the first constructor using : this()
        public Person(string name, int age) : this()
        {
            // Overrides the default values set by the first constructor
            Name = name;
            Age = age;
        }
    }
}
