// Exceeding requirements: The program now loads scriptures from a file and randomly selects one to display.
// This allows users to memorize different scriptures each time the program runs.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden! You've completed the exercise.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide some words, or type 'quit' to end.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }

    // Load scriptures from a file
    static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();
        
        // Read each line and create Scripture objects
        foreach (string line in File.ReadLines(filePath))
        {
            var parts = line.Split('|');
            Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
            scriptures.Add(new Scripture(reference, parts[4]));
        }

        return scriptures;
    }
}
