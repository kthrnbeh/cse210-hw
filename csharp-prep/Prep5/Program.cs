using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome(); //I wrote all the functions first and I forgot that you need to call them first in the main functions.
        string userName = PromptUserName(); // Just like we did in python.
        int userNumber = PromptUserNumber(); //I think the issues I had with buyi last year has made me rusty.
        int userBirthYear = 0;
        PromptUserBirthYear(out userBirthYear); // I didn't see an example of the calling the functions in main.
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber, userBirthYear); //but I am recognizing it from python.
        //DisplayWelcome - Displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        //PromptUserName - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }
        //PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number:");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        //PromtUserBirthYear - Accepts out integer parameter and prompts the user for
        //  the year they were born. The out parameter is set to their birth year. This function does not return a value. 
        // The user's birth year is given back from the function via the out parameter.
        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("Please enter the year you were born:");
            birthYear = int.Parse(Console.ReadLine());
        }
        //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number)
        {
            return number * number;
        }
        //DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's name and squared number. 
        // Calculate hold many years old they will turn this year and display that.
        static void DisplayResult(string name, int squaredNumber, int birthYear)
        {
            Console.WriteLine($"Hey! {name}, your favorite number squared is: {squaredNumber}.");
            int ageThisYear = 2025 - birthYear;
            Console.WriteLine($"Your age this year is: {ageThisYear}");
        }
    }
}
