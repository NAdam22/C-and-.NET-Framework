using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartConsoleAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // =========================================================
            // PART 1
            // Create an array of strings, ask for user input,
            // append the input to each string, then print the results
            // =========================================================

            // One-dimensional array of strings
            string[] words = { "Hello", "Welcome", "Goodbye" };

            // Ask the user to input some text
            Console.WriteLine("PART 1: Enter text to add to each word:");
            string userText = Console.ReadLine();

            // Loop through the array and append the user's text
            // This updates the array but does NOT print anything yet
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i] + " " + userText;
            }

            // Second loop that prints each updated string
            Console.WriteLine("\nUpdated array:");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            // =========================================================
            // PART 2
            // Create an infinite loop, then fix it
            // =========================================================

            Console.WriteLine("\nPART 2: Fixed infinite loop example");

            // This boolean controls the loop
            bool keepRunning = true;

            // This WOULD be an infinite loop if keepRunning never changed
            while (keepRunning)
            {
                Console.WriteLine("This loop runs once and then stops.");

                // FIX:
                // Setting keepRunning to false stops the infinite loop
                keepRunning = false;
            }

            // =========================================================
            // PART 3
            // Loops using < and <= comparison operators
            // =========================================================

            Console.WriteLine("\nPART 3: Loop using < operator");

            // Loop using < operator
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i is: " + i);
            }

            Console.WriteLine("\nPART 3: Loop using <= operator");

            // Loop using <= operator
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("i is: " + i);
            }

            // =========================================================
            // PART 4
            // Unique list, search for text, show index, stop after match
            // =========================================================

            Console.WriteLine("\nPART 4: Search a unique list");

            // List of unique strings
            List<string> colors = new List<string>
            {
                "Red",
                "Blue",
                "Green",
                "Yellow"
            };

            // Ask the user to search for text
            Console.WriteLine("Enter a color to search for:");
            string colorSearch = Console.ReadLine();

            // Flag to track if a match is found
            bool foundColor = false;

            // Loop through the list
            for (int i = 0; i < colors.Count; i++)
            {
                // Check if the current item matches the user's input
                if (colors[i].Equals(colorSearch, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found '{colors[i]}' at index {i}");
                    foundColor = true;

                    // Stop the loop once a match is found
                    break;
                }
            }

            // If no match was found, notify the user
            if (!foundColor)
            {
                Console.WriteLine("That item is not on the list.");
            }

            // =========================================================
            // PART 5
            // List with duplicate items, show ALL matching indices
            // =========================================================

            Console.WriteLine("\nPART 5: Search a list with duplicates");

            // List with duplicate strings
            List<string> animals = new List<string>
            {
                "Cat",
                "Dog",
                "Bird",
                "Cat",
                "Fish",
                "Dog"
            };

            // Ask the user to search for text
            Console.WriteLine("Enter an animal to search for:");
            string animalSearch = Console.ReadLine();

            // Flag to track matches
            bool foundAnimal = false;

            // Loop through the list and find ALL matches
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].Equals(animalSearch, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Match found at index {i}");
                    foundAnimal = true;
                }
            }

            // If no matches were found, notify the user
            if (!foundAnimal)
            {
                Console.WriteLine("That item is not on the list.");
            }

            // =========================================================
            // PART 6
            // Foreach loop that detects duplicates
            // =========================================================

            Console.WriteLine("\nPART 6: Detect duplicates using foreach");

            // List with duplicate strings
            List<string> letters = new List<string>
            {
                "A",
                "B",
                "C",
                "D",
                "C"
            };

            // List to track items that have already appeared
            List<string> seenItems = new List<string>();

            // Foreach loop to check for duplicates
            foreach (string letter in letters)
            {
                // Check if the item has already appeared
                if (seenItems.Contains(letter))
                {
                    Console.WriteLine(letter + " - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine(letter + " - this item is unique");

                    // Add the item to the seen list
                    seenItems.Add(letter);
                }
            }

            // Keeps the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
