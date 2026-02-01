using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program   // Main program class
    {
        static void Main(string[] args)  // Entry point of the console application
        {
            // Using 'var' to create a variable
            // The compiler automatically figures out the type (Person)
            var person1 = new Person("Naif", 30);

            // Displaying information to the console
            Console.WriteLine("Name: " + person1.Name);     // Prints the person's name
            Console.WriteLine("Age: " + person1.Age);       // Prints the person's age
            Console.WriteLine("Species: " + Person.Species); // Accesses the const variable

            // Keeps the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}
