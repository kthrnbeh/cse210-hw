using System;
using System.Collections.Generic;
using System.IO;
using System.Net;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        // Working with my team to develope a journal prompt 
        //https://www.youtube.com/watch?v=3bBiQ1G7BOU Watched this to help me with ideas of what to do.
        //Looks like first thing I need to do is make a menu// I thought about what a menu would look like in python as they can do similar things but in a different method
        //ok I need to make a couple classes , Entry and Jornal// help from https://www.w3schools.com/cpp/default.asp
        //https://chatgpt.com/share/68d46af7-953c-8002-9fc8-8fd62fd20bf8 // watched the how the journal is supposed to work a couple times. stil confusing. 

        static List<Entry> journalEntries = new List<Entry>();
        int menuNumber = 0;
        while (menuNumber != 5)
        {
            //my idea is to write a menu and have it keep going until it gets the number 5
            Console.WriteLine("Please select one of the following choices:");
            //By removing the if this should make the program always give the menu

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would your like to do?");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            if (userInput == 1)
            {
                    WriteEntry(); //Each of these go to the classes
            }
            else if (userInput == 2)
            {
                DisplayAllEntries;
            }
            else if (userInput == 3)
            {
                LoadFromFile();
            }
            else if (userInput == 4)
            {
                SaveToFile();
            }
            else if (userInput = 5)
            {
                Console.WriteLine("Quit selected. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid Choice")
            }


        }





    }
    static void WriteEntry
    {
        string filename = "prompt.txt" //looked up how to get a prompt.txt
        Random random = new Random(); // the team I am apart of helped here
        int index = random.Next(prompts.Length);// c++ is not the same as python but both do index
        string prompt = prompt[index];

        Console.WritLine(prompt);
        Console.Write(",");
        string response = Console.ReadLine();

        // I saw that I needed to add this to one of the classes not main
        Entry newEntry = New Entry();
        newEntry.date = DateOnly.Time.Now.ToShortDateString();
        new.Entry = prompt;
        new.Entry = response;

        JournalEntries.add(newEntry);

    }
    static void DisplayEntry
    {
        foreach(Entry entry in journalEntries)
        Console.WriteLine($"Date: {entry.date} - Prompt: {entry.prompt}");
        Console.WriteLine($"Response: {entry.response}");
    }


   static void SaveFile()
{
    Console.Write("Filename");
    string filename = Console.ReadLine();
    List<string> lines = new List<string>();
    foreach (Entry entry in journalEntries)
        lines.Add($"{entry.date}{entry.prompt{entry.response}}")
    
    }
        File.WriteAllLines(filename, lines);
Console.WriteLine("Saved.");

{
    public string newEntry;
    public string display;
        {
        Entry.add(dateTxt)
        Entry.add(propmt)
            Entry.add(response)
        // make list to add dates, prompt,resonse happen? right? 
    }
         public string save;
    public string load; // I want to load this text or previous files //follow video
        {
            //create txt file to load 
        }       
    
    }
    public class Save
{
        
}
        
}
    
