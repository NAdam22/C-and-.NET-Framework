using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold Employee objects
            List<Employee> employees = new List<Employee>()
            {
                // Add at least 10 employees to the list
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Anna", LastName = "Brown" },
                new Employee { Id = 3, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 4, FirstName = "Sarah", LastName = "Connor" },
                new Employee { Id = 5, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 6, FirstName = "Mike", LastName = "Taylor" },
                new Employee { Id = 7, FirstName = "Emily", LastName = "Davis" },
                new Employee { Id = 8, FirstName = "David", LastName = "Wilson" },
                new Employee { Id = 9, FirstName = "Linda", LastName = "Moore" },
                new Employee { Id = 10, FirstName = "Chris", LastName = "Anderson" }
            };

            // ---------------- FOREACH LOOP VERSION ----------------

            // Create a new list to store employees with the first name "Joe"
            List<Employee> joesForeach = new List<Employee>();

            // Loop through each employee in the employees list
            foreach (Employee employee in employees)
            {
                // Check if the employee's FirstName is "Joe"
                if (employee.FirstName == "Joe")
                {
                    // If true, add the employee to the joesForeach list
                    joesForeach.Add(employee);
                }
            }

            // Display results from the foreach loop
            Console.WriteLine("Employees named Joe (foreach loop):");
            foreach (Employee joe in joesForeach)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName} (ID: {joe.Id})");
            }

            Console.WriteLine(); // Blank line for readability

            // ---------------- LAMBDA EXPRESSION VERSION ----------------

            // Use a lambda expression to filter employees with the first name "Joe"
            List<Employee> joesLambda = employees
                .Where(e => e.FirstName == "Joe")
                .ToList();

            // Display results from the lambda expression
            Console.WriteLine("Employees named Joe (lambda expression):");
            foreach (Employee joe in joesLambda)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName} (ID: {joe.Id})");
            }

            Console.WriteLine(); // Blank line for readability

            // ---------------- ID GREATER THAN 5 USING LAMBDA ----------------

            // Use a lambda expression to find employees with an ID greater than 5
            List<Employee> idGreaterThanFive = employees
                .Where(e => e.Id > 5)
                .ToList();

            // Display employees with ID greater than 5
            Console.WriteLine("Employees with ID greater than 5:");
            foreach (Employee employee in idGreaterThanFive)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} (ID: {employee.Id})");
            }

            // Keep the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
