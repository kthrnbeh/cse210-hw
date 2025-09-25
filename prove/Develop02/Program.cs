using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Entry> journalEntries = new List<Entry>();
    static Random rng = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        // Working with my team to develope a journal prompt 
        // https://www.youtube.com/watch?v=3bBiQ1G7BOU Watched this to help me with ideas of what to do.
        // Looks like first thing I need to do is make a menu
        // ok I need to make a couple classes , Entry and Journal
        // https://chatgpt.com/share/68d46af7-953c-8002-9fc8-8fd62fd20bf8

        int menuNumber = 0;
        while (menuNumber != 5)
        {
            // my idea is to write a menu and have it keep going until it gets the number 5
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out menuNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            if (menuNumber == 1)
            {
                WriteEntry(); // Each of these go to the classes
            }
            else if (menuNumber == 2)
            {
                DisplayAllEntries();
            }
            else if (menuNumber == 3)
            {
                LoadFromFile();
            }
            else if (menuNumber == 4)
            {
                SaveToFile();
            }
            else if (menuNumber == 5)
            {
                Console.WriteLine("Quit selected. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }

    static void WriteEntry()
    {
        string filename = "prompt.txt"; // looked up how to get a prompt.txt

        if (!File.Exists(filename))
        {
            Console.WriteLine($"Prompt file '{filename}' not found.");
            return;
        }

        string[] prompts = File.ReadAllLines(filename);
        if (prompts.Length == 0)
        {
            Console.WriteLine("No prompts found in prompt.txt");
            return;
        }

        int index = rng.Next(prompts.Length); // index
        string prompt = prompts[index];

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        // add this to one of the classes not main
        Entry newEntry = new Entry();
        newEntry.date = DateTime.Now.ToShortDateString();
        newEntry.prompt = prompt;
        newEntry.response = response;

        journalEntries.Add(newEntry);
    }

    static void DisplayAllEntries()
    {
        foreach (Entry entry in journalEntries)
        {
            Console.WriteLine($"Date: {entry.date} - Prompt: {entry.prompt}");
            Console.WriteLine($"Response: {entry.response}");
        }
    }

    static void SaveToFile()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        List<string> lines = new List<string>();
        foreach (Entry entry in journalEntries)
        {
            lines.Add($"{entry.date}|{entry.prompt}|{entry.response}");
        }

        File.WriteAllLines(filename, lines);
        Console.WriteLine("Saved.");
    }

    static void LoadFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        journalEntries.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length != 3) continue;

            Entry newEntry = new Entry();
            newEntry.date = parts[0];
            newEntry.prompt = parts[1];
            newEntry.response = parts[2];

            journalEntries.Add(newEntry);
        }
    }
}

class Entry
{
    public string date;
    public string prompt;
    public string response;
}
