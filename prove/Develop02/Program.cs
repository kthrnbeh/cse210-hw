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
                Journal journaling = new Journal();
            }
            else if (menuNumber == 2)
            {
               
            }
            else if (menuNumber == 3)
            {
                Entry entry = new Entry();
                
            }
            else if (menuNumber == 4)
            {
                
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

 