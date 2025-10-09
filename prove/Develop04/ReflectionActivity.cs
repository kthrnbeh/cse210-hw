public class ReflectionActivity : Activity
{
    private int _reflection = 5; // coping breathing activity
    
    private List<string> _prompts = new List<string>() 
    {
        // Add prompts here.
        //oh I need quotes 
        "Think of a time when you stood up for someone else.",
        " Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    
    private List<string> _questions = new List<string>()
    {
        // Add questions here.
        //looked at problems in the termanial for answers. 
        " Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        " What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    
    {
        // Set the activity name and description.
        // The base class constructor is implicitly called first if parameterless.

    }
    
   
    private void GetReflectionTime() // don't want anything returned
    {
        Console.Write("How many seconds would you like to reflect? ");
        
        if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
        {
            _reflection = duration;
        }
    }


    
    public string GetRandomPrompt() 
    {
        
        // Random random = new Random(); //  Commented out/deleted redundant local Random instance.
        Random random = GetRandom(); // Use the inherited random object.
        // Get a random prompt from the _prompts list.
        int index = random.Next(_prompts.Count);//missed s found that in termainal problem
        // Console.WriteLine(_prompts[index]); // FIX 6: Delete/comment out. The calling method handles display.
        return _prompts[index]; //  Must RETURN the string.
    }

    // FIX 4: Changed from void to 'string' return type.
    public string GetRandomQuestion()
    {
        // FIX 5: Use the inherited GetRandom() method.
        // Random random = new Random(); // FIX: Commented out/deleted redundant local Random instance.
        Random random = GetRandom(); // Use the inherited random object.
        // Get a random prompt from the _prompts list.
        int index = random.Next(_questions.Count);
        // Console.WriteLine(_questions[index]); // FIX 6: Delete/comment out. The calling method handles display.
        return _questions[index]; // FIX 6: Must RETURN the string.
    }

    public void DisplayPrompt()
    {
        // Display the prompt to the user.
        Console.WriteLine($"--- {GetRandomPrompt()} ---"); 
        
        // Give the user time to read the prompt and prepare.
        Console.WriteLine("Take a few moments to think about the prompt. Press Enter to continue.");
        Console.ReadLine(); // Wait for user input
        CountDown(5); // Now show countdown
    }

    public void DisplayQuestion()
    {
        // Display a random question to the user and then pause with a spinner.
        
        Console.Write($"> {GetRandomQuestion()} ");
        
        
        StartSpinner(_reflection);
        Console.WriteLine(); // Add newline after spinner finishes.
    }

    public void StartActivity()
    {
        // Start the activity by displaying the starting message and prompting for duration.
        // Show the random prompt.
        // Loop for the specified duration.
        // Inside the loop, display random questions, pausing with a spinner after each one.
        // End the activity by displaying the finishing message.
        DisplayStartMessage(); // FIX 9: Corrected name to match base class.
        
        
        GetReflectionTime(); 
        
        DisplayPrompt();
        
        DateTime startTime = DateTime.Now;
        // Loop for the specified duration.
        while ((DateTime.Now - startTime).TotalSeconds < _time)
        {
            //inside the loop display random question
            DisplayQuestion();
        }
        
        DisplayEndMessage(); 
    }
}
//https://www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/
//https://www.tutorialsteacher.com/csharp/inheritance
//https://www.w3schools.com/cpp/cpp_howto_random_number.asp
//https://www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/