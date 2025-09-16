using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        //The program awards the letter grade for User as they put in there score.

    {
        Console.Write("Please enter your test score:");
        string score = Console.ReadLine();
        int letter = int.Parse(score);
        if (letter > 90) // I made two mistakes here first I used numbers to  compare instead of letter
        {
            Console.Write("A"); //second I didn't remember how to comment and used # instead of //
        }
        else if (80 > letter) // I inquired the web with how to comment in c+
        {
            Console.Write("B"); //Then asked chatGPT to teach me what I did wrong on the first if statement.
        }
        else if (70 > letter)
        {
            Console.Write("C");
        }
        else if (60 > letter)
        {
            Console.Write("D");
        }
        else
        {
            Console.Write("F"); // I also saw I used score instead of the word letter.I updated that.
        }
        Console.WriteLine($"Your Letter Grade is {letter}."); //Prints letter grade.
            
        }
        
    }
}