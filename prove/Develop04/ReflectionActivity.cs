public class ReflectionActivity : Activity
{
    private int _reflection = 5; // 
    private List<string> _prompts = new List<string>() // static made random not work. 
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

    public void GetRandomPrompt() // changed to void no return
    {
        Random random = new Random();//looked up what to do to have a random string. I know I learned this but forgot. 
                                     // Get a random prompt from the _prompts list.
        int index = random.Next(_prompts.Count);//missed s found that in termainal problem
        Console.WriteLine(_prompts[index]);
    }

    public void GetRandomQuestion()
    {
      Random random = new Random();//looked up what to do to have a random string. I know I learned this but forgot. 
                                     // Get a random prompt from the _prompts list.
        int index = random.Next(_questions.Count);
        Console.WriteLine(_questions[index]);
    }

    public void DisplayPrompt()
    {
        // Display the prompt to the user.
        Console.WriteLine($"{GetRandomPrompt}"); // need message for the user 
        CountDown(5);
    }

    public void DisplayQuestion()
    {
        // Display a random question to the user and then pause with a spinner.
        Console.WriteLine($" {GetRandomQuestion}");
        StartSpinner(5);
    }

    public void StartActivity()
    {
        // Start the activity by displaying the starting message and prompting for duration.
        // Show the random prompt.
        // Loop for the specified duration.
        // Inside the loop, display random questions, pausing with a spinner after each one.
        // End the activity by displaying the finishing message.
        StartMessageDisplay();
        DisplayPrompt();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _time)
        {
            //inside the loop display random question
            DisplayQuestion();
        }
        EndMessageDisplay(); //end activyity by displaying the finsished message. 
    }
}
//https://www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/