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

        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            CountDown(4);

            Console.Write("Breathe out... ");
            CountDown(6);
        }

        EndMessageDisplay();
    }
}
