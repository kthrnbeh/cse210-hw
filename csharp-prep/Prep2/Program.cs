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
        int scoreAsInt = int.Parse(score);
        if (scoreAsInt > 90)
        {
            Console.Write("A");
        }
        else if (scoreAsInt > 80)
        {
            Console.Write("B");
        }
        else if (scoreAsInt > 70)
        {
            Console.Write("C");
        }
        else if (scoreAsInt > 60)
        {
            Console.Write("D");
        }
        else
        {
            Console.Write("F");
        }
        Console.WriteLine($"Your Letter Grade is {scoreAsInt}."); //Prints letter grade.
            
        }
        
    }
}