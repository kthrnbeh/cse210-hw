public class BreathingActivity : Activity
{

    public BreathingActivity() : base()
    {
        _activity = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void BreathingCycle() // void not returning anything
    { 
        StartMessageDisplay();
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_time);
        
        while (DateTime.Now <= stopTime)
        {
            //While loop to tell it when to stop
            //have user breathe in for 5 seconds
            Console.Write("Breathe In");
            CountDown(5);
            
            // have user breathe out for 5 seconds
            Console.WriteLine("Breathe Out");
            CountDown(5);
        }

        EndMessageDisplay();
    }

    //While loop to tell it when to stop
    //have user breathe in for 5 seconds
    // have user breathe out for 5 seconds
    // repeat(loop)
}

//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives
