using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        StartMessageDisplay();

        if (_cancelRequested)
        {
            return;
        }

        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime && !_cancelRequested)
        {
            Console.Write("\nBreathe in... ");
            if (!CountDown(4))
            {
                break;
            }

            Console.Write("Breathe out... ");
            if (!CountDown(6))
            {
                break;
            }
        }

        if (!_cancelRequested)
        {
            EndMessageDisplay();
        }
    }
}
