using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _activity;
    protected string _description;
    protected int _time;

    public Activity(string activity, string description)
    {
        _activity = activity;
        _description = description;
        _time = 0;
    }

    public void StartMessageDisplay()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activity}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        while (!int.TryParse(Console.ReadLine(), out _time) || _time <= 0)
        {
            Console.Write("Please enter a positive number of seconds: ");
        }

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        StartSpinner(3);
    }

    public void EndMessageDisplay()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        StartSpinner(3);
        Console.WriteLine($"You have completed another {_time} seconds of the {_activity}.");
        StartSpinner(3);
    }

    public void StartSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[index]);
            Thread.Sleep(250);
            Console.Write("\b ");
            Console.Write("\b");
            index = (index + 1) % animationStrings.Count;
        }
        Console.WriteLine();
    }

    public void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b ");
            Console.Write("\b");
        }
        Console.WriteLine();
    }
}