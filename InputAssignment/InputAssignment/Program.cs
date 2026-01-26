using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.WriteLine("Please enter a number:");

            // Read the user's input from the console and store it as a string
            string userInput = Console.ReadLine();

            // Define the file name where the number will be saved
            string fileName = "number.txt";

            // Write the user's input to the text file
            // If the file does not exist, it will be created
            File.WriteAllText(fileName, userInput);

            // Read the contents of the text file back into a string
            string fileContents = File.ReadAllText(fileName);

            // Display the contents of the file to the user
            Console.WriteLine("The number read from the file is:");
            Console.WriteLine(fileContents);

            // Pause the program so the console window stays open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
