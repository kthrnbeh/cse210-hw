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
        string path = "scripture.txt";
        // "path" is just a variable that holds the file name we want to use

        if (!File.Exists(path))  // checkingi
        // File.Exists(path) checks if that file really exists on the computer
        // ! means "not", so this runs if the file is missing
        {
            Console.WriteLine("Could not find " + path); 
            // tell the user the file isn’t there
            return; 
            // stop the program here if we don’t have the file
        }

        // ------------------- STEP 2: LOAD ONE SCRIPTURE -------------------
        string[] lines = File.ReadAllLines(path);  
        // ReadAllLines = grab every line in the file and put them into an array
        // each "line" in this array looks like: Book|Chapter|Start|End|Text

        string line = lines[0];  
        // take the FIRST line only (later we could add random to pick one)

        string[] parts = line.Split('|');  
        // Split breaks the line into pieces wherever it sees a "|"
        // now parts[0] is book, parts[1] is chapter, etc.

        string book = parts[0];  
        int chapter = int.Parse(parts[1]);  
        int startVerse = int.Parse(parts[2]);  
        int endVerse = int.Parse(parts[3]);  
        string text = parts[4];  
        // assign each part into the right variable (turning numbers from text into int)

        // ------------------- STEP 3: BUILD A REFERENCE -------------------
        Reference reference;  
        // Reference is your custom class that holds the scripture address
        // (like "1 Nephi 1:1" or "Moses 1:1-3")

        if (startVerse == endVerse)  
        {
            reference = new Reference(book, chapter, startVerse); 
            // if start and end are the same → single-verse constructor
        }
        else
        {
            reference = new Reference(book, chapter, startVerse, endVerse); 
            // if different → multiple-verse constructor
        }

        // ------------------- STEP 4: BUILD A SCRIPTURE -------------------
        Scripture scripture = new Scripture(reference, text);  
        // Scripture is your custom class that:
        // - stores the reference
        // - splits the verse text into Word objects
        // - knows how to display itself and hide words

        Random rng = new Random();  
        // random number generator (lets Scripture choose random words to hide)

        // ------------------- STEP 5: LOOP UNTIL SCRIPTURE IS GONE -------------------
        while (true)  // "forever" loop until we break out
        {
            Console.Clear();  
            // wipe the screen so it looks clean each time

            Console.WriteLine(scripture.GetDisplay());  
            // ask Scripture to show itself
            // Scripture calls Word.Present() on every word inside it

            if (scripture.IsFullyHidden())  
            // ask Scripture: "are ALL words hidden?"
            {
                Console.WriteLine("\nAll words hidden. Nice work!");
                break;  // stop the loop if they are
            }

            Console.Write("\nPress Enter to hide 3 words, or type 'quit': "); 
            string input = Console.ReadLine();  
            // wait for user to press a key or type "quit"

            if (input == "quit" || input == "QUIT")  
            // if user typed quit (uppercase or lowercase)
            {
                break;  // end the loop
            }

            scripture.HideRandomWords(3, rng);  
            // tell Scripture: "hide 3 random words"
            // Scripture uses rng.Next(...) to pick which Word objects to hide
            // Each Word then changes itself (_hidden = true)
        }
    }
}
