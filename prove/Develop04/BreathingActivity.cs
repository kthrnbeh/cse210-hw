

public class BreathingActivity : Activity
{   


    public BreathingActivity():base("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        //_activity = "Breathing Activity";
        //_description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        //_time = 0;
    }

    public void BreathingCycle() // void not returning anything
    {
        DisplayStartMessage();
        
        
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_time);
        const int cycleTime = 5; // ohhh I need to set the timer her for them
        const int totalTime = cycleTime + 2;
        while (DateTime.Now < stopTime)// not equal
        {
          if (DateTime.Now.AddSeconds(totalTime) >= stopTime) 
        {
            break; // Stop the loop
        }
            //While loop to tell it when to stop
            //have user breathe in for 5 seconds
            Console.WriteLine("Breathe In...");
            Thread.Sleep(1000);
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("3");
            Thread.Sleep(1000);
            CountDown(cycleTime);

            Console.WriteLine();

            Console.WriteLine();
            // have user breathe out for 5 seconds
            Console.WriteLine("Breathe Out...");
            Thread.Sleep(1000);
             Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b\b");
            CountDown(cycleTime);
        }
        DisplayEndMessage();
       
    }

    //While loop to tell it when to stop
    //have user breathe in for 5 seconds
    // have user breathe out for 5 seconds
    // repeat(loop)
}

//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch?f1url=%3FappId%3Droslyn%26k%3Dk(CS7036)
//https://www.c-sharpcorner.com/blogs/understanding-constants-in-c-sharp2
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements