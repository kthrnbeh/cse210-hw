public class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _activity = "Breathing Activity";
        _description = "";

    }
    public string RandomPrompt();
    {
        StartMessageDisplay();
        DateTime startTime = DateTime.Now;
    DateTime stopTime = startTime.AddSeconds(_time);

    //While loop to tell it when to stop
        do {
            while(DateOnly.Time < stopTime);
        }
        
    //have user breath in for 5 seconds
    // have user breath out for 5 seconds
    // repeat(loop)
    Console.WriteLine("Breath In")
        CountDown(5);
        Console.WriteLine("Breathout")
        CountDown(5);
        EndMessageDisplay();
    }
}