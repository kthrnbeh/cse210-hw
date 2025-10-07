public class BreathingActivity : Activity
{

    public BreathingActivity():base()
    {
        _activity = "Breathing Activity";
        _description = "";

    }
    public string BreathingCycle(); //name didn't really relate
    { 
         StartMessageDisplay();
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_time);
        while(DateTime.Now<stopTime) {
            //While loop to tell it when to stop
         //have user breath in for 5 seconds
         Console.Write("Breathe In");
          CountDown(5);
         // have user breath out for 5 seconds
        // repeat(loop)
        // Console.WriteLine("Breath In")
       
        Console.WriteLine("Breathout")
        CountDown(5);
        EndMessageDisplay();
                string s = animationstrings(i);
            Console.Write(s);
            Thread.Speed(1000);
            Console.Write("\b\b");
            if (i>=animationstrings.count)
            {
                i=0;
            }
        }
    


    //While loop to tell it when to stop

    //have user breath in for 5 seconds
    // have user breath out for 5 seconds
    // repeat(loop)
        
}
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives