using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        // Working with my team to develope a journal prompt 
        //https://www.youtube.com/watch?v=3bBiQ1G7BOU Watched this to help me with ideas of what to do.
        //Looks like first thing I need to do is make a menu
        // I thought about what a menu would look like in python as they can do similar things but in a different method
        //ok I need to make a couple classes , Entry and Jornal
        //Need 
        string prompt;
        string quit;
        string write; // looked at reading and it  said this was the right way
                         // activity prep 2 and I am trying to figure it out with my teacm
        string load;
        string save;

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
        }    

    }
    public class Entry
    {
        static void prompt();
        {
            
        }

    }
    public class Journal
    {

    }
}