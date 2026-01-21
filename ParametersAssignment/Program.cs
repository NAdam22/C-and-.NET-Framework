using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object using string as the generic type
            Employee<string> stringEmployee = new Employee<string>();

            // Assign a list of strings to the Things property
            stringEmployee.Things = new List<string>()
            {
                "Laptop",
                "Notebook",
                "Pen",
                "Backpack"
            };

            // Write a heading to the console
            Console.WriteLine("Employee with string Things:");

            // Loop through each string in the Things list
            foreach (string thing in stringEmployee.Things)
            {
                // Print each string item to the console
                Console.WriteLine(thing);
            }

            // Add a blank line for better readability
            Console.WriteLine();

            // Instantiate an Employee object using int as the generic type
            Employee<int> intEmployee = new Employee<int>();

            // Assign a list of integers to the Things property
            intEmployee.Things = new List<int>()
            {
                10,
                20,
                30,
                40
            };

            // Write a heading to the console
            Console.WriteLine("Employee with int Things:");

            // Loop through each integer in the Things list
            foreach (int number in intEmployee.Things)
            {
                // Print each integer item to the console
                Console.WriteLine(number);
            }

            // Keeps the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
