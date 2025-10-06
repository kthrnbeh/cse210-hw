using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        //Verify that you can run the project. Did.
        //Test your class by returning to the Main method in the Program.cs file. 
        // Create a simple assignment, call the method to get the summary, and then display it to the screen.

        Assignment assignment = new Assignment("Gary, Steven", "History");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment math = new MathAssignment("GaryBob","Fraction", "8.3"," 8-19");
        Console.WriteLine(math.GetSummary());
        WritingAssignment write = new WritingAssignment("Mary Waters","European Histroy","The Causes of World war 2 by Mary Waters.");
        Console.WriteLine(write.GetSummary());
    }
}