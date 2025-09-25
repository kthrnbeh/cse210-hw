using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

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

        list<string> prompt = ["  Who was the most interesting person I interacted with today?",
        "What was the best part of my day?","How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"];

        int menuNumber = -1;
        while (menuNumber != 5)
        {
            //my idea is to write a menu and have it keep going until it gets the number 5
            Console.WriteLine("Please select one of the following choices:");
            //By removing the if this should make the program always give the menu

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would your like to do?");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            if (userInput == 1)
            {
                Journal.add(newEntry);
            }
            else if (userInput == 2)
            {
                Journal.add(display);
            }
            else if (userInput == 3)
            {
                Journal.add(load);
            }
            else if (userInput == 4)
            {
                Journal.add(save)
            }
            else
            {
                Console.WriteLine("Quit selected. Goodbye!");
            }


        }



        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

    }
    public class Entry
    {
        public string dateText;
        public string prompt;
        public string response;

        void public Display()
        {
            Console.WriteLine($"{dateText}-{prompt}"); // suggestion
            Console.WriteLine($"What would you like to do?{response}");
        }



    }
    public class Journal
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
    }
        
}
    
