using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("Whats your first name?");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name?");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName},{firstName}{lastName}.");
    }
}
using System;

class Program
{
    static void Main(string[] args)
# The program awards the letter grade for User as they put in there score.

    {
        Console.Write("Please enter your test score:");
        string score = Console.ReadLine();
        int scoreAsInt = int.Parse(score);
        if (90 > 80)
        {
            Console.Write("A");
        }
        else if (80 > 70)
        {
            Console.Write("B");
        }
        else if (70 > 60)
        {
            Console.Write("C");
        }
        else if (60 > 50)
        {
            Console.Write("D");
        }
        else
        {
            Console.Write("F");
        }
        Console.WriteLine($"Your Letter Grade is {scoreAsInt}.");
            
        }
    }

}
