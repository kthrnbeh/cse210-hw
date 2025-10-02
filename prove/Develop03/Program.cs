using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        // just a greeting to show the program started

        // ------------------- STEP 1: FIND THE FILE -------------------
        // a variable that stores the name of the file we want to open
        string path = "scriptures.txt";  

        // print out where the program is looking (debug helper)
        Console.WriteLine("Looking for file in: " + Directory.GetCurrentDirectory());

        // check if the file actually exists
        if (!File.Exists(path))  
        {
            Console.WriteLine("Could not find " + path);
            // if the file isn’t found → stop the program
            return;  
        }

        // ------------------- STEP 2: LOAD ONE SCRIPTURE -------------------
        string[] lines = File.ReadAllLines(path);  
        // ReadAllLines = function that grabs every line from the file
        // Each line is stored in the array "lines"

        string line = lines[0];  
        // take the FIRST line only (you could later pick a random one)

        string[] parts = line.Split('|');  
        // Split() = method that cuts the line into parts wherever "|" appears
        // Example: "Moses|1|1|3|And God said..." becomes 5 parts

        string book = parts[0];  // first part → book name
        int chapter = int.Parse(parts[1]);  // second part → number
        int startVerse = int.Parse(parts[2]);  
        int endVerse = int.Parse(parts[3]);  
        string text = parts[4];  // last part → scripture words

        // ------------------- STEP 3: BUILD A REFERENCE -------------------
        Reference reference;  
        // Reference is your own CLASS (custom data type)
        // It knows how to store book, chapter, and verse numbers

        if (startVerse == endVerse)
        {
            reference = new Reference(book, chapter, startVerse);
            // if start and end are the same, we only need one verse
        }
        else
        {
            reference = new Reference(book, chapter, startVerse, endVerse);
            // if different, we pass both startVerse and endVerse
        }

        // ------------------- STEP 4: BUILD A SCRIPTURE -------------------
        Scripture scripture = new Scripture(reference, text);  
        // Scripture is another CLASS (custom type you made)
        // It uses the Reference and the text, and then it splits the text into Word objects

        Random rng = new Random();  
        // Random = built-in class that helps us pick random numbers
        // We’ll give it to Scripture to hide random words

        // ------------------- STEP 5: LOOP UNTIL SCRIPTURE IS GONE -------------------
        while (true)  
        {
            Console.Clear();  
            // clears the console so it looks clean each round

            Console.WriteLine(scripture.GetDisplay());  
            // Scripture.GetDisplay() is a METHOD
            // It asks every Word to show itself (hidden or normal)
            // and combines them into one string for printing

            if (scripture.IsFullyHidden())  
            {
                Console.WriteLine("\nAll words hidden. Nice work!");
                break;  // exit the while loop
            }

            Console.Write("\nPress Enter to hide 3 words, or type 'quit': ");
            string input = Console.ReadLine();

            if (input == "quit" || input == "QUIT")
            {
                break;  // end the loop if the user wants to quit
            }

            scripture.HideRandomWords(3, rng);  
            // tells the Scripture object:
            // “please pick 3 Word objects and set them to hidden”
        }
    }
}
