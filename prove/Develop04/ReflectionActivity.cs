public class ReflecionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        // Add prompts here.
        Think of a time when you stood up for someone else.
        Think of a time when you did something really difficult.
        Think of a time when you helped someone in need.
        Think of a time when you did something truly selfless.
    };

    private List<string> _questions = new List<string>()
    {
        // Add questions here.
        Why was this experience meaningful to you?
        Have you ever done anything like this before?
        How did you get started?
        How did you feel when it was complete?
        What made this time different than other times when you were not as successful?
        What is your favorite thing about this experience?
        What could you learn from this experience that applies to other situations?
        What did you learn about yourself through this experience?
        How can you keep this experience in mind in the future?
    };

    public ReflecionActivity()
    {
        // Set the activity name and description.
        // The base class constructor is implicitly called first if parameterless.
        _activity = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public string GetRandomPrompt()
    {
        // Get a random prompt from the _prompts list.
        return _prompts[_random.Next](_prompts.Count);
    }

    public string GetRandomQuestion()
    {
        // Get a random question from the _questions list.
        return _questions[_random.Next](_questions.Count);
        

    }

    public void DisplayPrompt()
    {
        // Display the prompt to the user.
        Console.WriteLine("");
    }

    public void DisplayQuestion()
    {
        // Display a random question to the user and then pause with a spinner.
    }

    public void StartActivity()
    {
        // Start the activity by displaying the starting message and prompting for duration.
        // Show the random prompt.
        // Loop for the specified duration.
        // Inside the loop, display random questions, pausing with a spinner after each one.
        // End the activity by displaying the finishing message.
    }
}