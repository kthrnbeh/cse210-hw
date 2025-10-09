using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _activity;
    protected string _description;
    protected int _time;
    protected bool _cancelRequested;

    public Activity(string activity, string description)
    {
        _activity = activity;
        _description = description;
        _time = 0;
    }

    protected void ResetCancellation()
    {
        _cancelRequested = false;
    }

    private bool CheckForCancelKeyPress()
    {
        if (!_cancelRequested && Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            if (keyInfo.Key == ConsoleKey.Q)
            {
                _cancelRequested = true;
                Console.WriteLine();
                Console.WriteLine("Activity cancelled. Returning to the menu...");
                Console.WriteLine();
                return true;
            }
        }

        return false;
    }

    public void StartMessageDisplay()
    {
        ResetCancellation();
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activity}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("Press 'Q' at any time to return to the menu.");
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
        if (_cancelRequested)
        {
            _cancelRequested = false;
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Well done!");
        if (!StartSpinner(3))
        {
            _cancelRequested = false;
            return;
        }
        Console.WriteLine($"You have completed another {_time} seconds of the {_activity}.");
        if (!StartSpinner(3))
        {
            _cancelRequested = false;
        }
    }

    public bool StartSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime && !_cancelRequested)
        {
            Console.Write(animationStrings[index]);
            Thread.Sleep(250);
            Console.Write("\b ");
            Console.Write("\b");
            index = (index + 1) % animationStrings.Count;

            CheckForCancelKeyPress();
        }
        Console.WriteLine();

        return !_cancelRequested;
    }

    public bool CountDown(int seconds)
    {
        for (int i = seconds; i > 0 && !_cancelRequested; i--)
        {
            Console.Write(i);
            for (int step = 0; step < 10 && !_cancelRequested; step++)
            {
                Thread.Sleep(100);
                CheckForCancelKeyPress();
            }

            if (_cancelRequested)
            {
                break;
            }

            Console.Write("\b ");
            Console.Write("\b");
        }
        Console.WriteLine();

        return !_cancelRequested;
    }
}