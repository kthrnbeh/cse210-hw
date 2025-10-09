using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq; // Added for ReflectionActivity to shuffle questions

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        //first step is to make a menu
        //Taking ideas from Develope 2 for the menu
        int menuNumber = 0;
        // My idea is to write a menu and have it keep going until it gets the number 4 (Quit)
        while (menuNumber != 4)
        {
            // FIX: Menu display MUST happen BEFORE reading input.
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            // FIX: Corrected typo to Reflection Activity
            Console.WriteLine("2. Start Reflection Activity"); 
            // FIX: Corrected name to Listing Activity
            Console.WriteLine("3. Start Listing Activity");    
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the Menu: ");

            string userInput = Console.ReadLine();
            // Input Validation copied from the journal program (Exception Handling)
            if (!int.TryParse(userInput, out menuNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Thread.Sleep(2000); // Give user time to read the error
                continue; // Restart the loop
            }

            if (menuNumber == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();//new breathing activity
                // FIX: Consolidated all setup/run/end calls into one method (Abstraction)
                breathingActivity.RunActivity();
            }
            else if (menuNumber == 2)
            {
                // FIX: Corrected class name typo (ReflectionActivity)
                ReflectionActivity reflectionActivity = new ReflectionActivity(); 
                // FIX: Consolidated all setup/run/end calls into one method (Abstraction)
                reflectionActivity.RunActivity();
            }
            else if (menuNumber == 3)
            {
                // FIX: Corrected class name typo (ListingActivity)
                ListingActivity listingActivity = new ListingActivity();
                // FIX: Consolidated all setup/run/end calls into one method (Abstraction)
                listingActivity.RunActivity();
            }
            else if (menuNumber == 4)
            {
                Console.WriteLine("Quit selected. Goodbye!");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                Thread.Sleep(2000);
            }
        }
    }
}
//links that helped 
//https://dev.to/zacharypatten/beginner-s-guide-to-console-input-in-c-1654