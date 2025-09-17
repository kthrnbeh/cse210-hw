using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        //Prep 3 Guess My Number
        //Console.Write("What is the magic number?");
        //int magicNumber = int.Parse(Console.ReadLine()); //Part 1 ask user what the magic number is
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100); //Part three random number generator.
        Console.Write("What is your guess?");
        int userGuess = int.Parse(Console.ReadLine());//Part 2 ask user what their guess is.
        while (userGuess != magicNumber) // Part two add while look. //Updated from user guess to random
        {
            if (userGuess < magicNumber) // Part 1 ask until get the proper answer. //updated to random 
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess?");
            userGuess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You guessed it!");
        

    }
}