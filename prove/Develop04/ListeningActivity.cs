using System;
using System.Collections.Generic;

public class ListeningActivity : Activity
{
    private readonly List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private readonly Random _random = new Random();

    public ListeningActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        StartMessageDisplay();

        if (_cancelRequested)
        {
            return;
        }

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[_random.Next(_prompts.Count)]} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        if (!CountDown(5))
        {
            return;
        }

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime && !_cancelRequested)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input.Trim());
            }
        }

        if (_cancelRequested)
        {
            return;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");

        EndMessageDisplay();
    }
}
