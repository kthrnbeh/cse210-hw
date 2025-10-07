public class ReflecionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        // Add prompts here.
    };

    private List<string> _questions = new List<string>()
    {
        // Add questions here.
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
    }

    public string GetRandomQuestion()
    {
        // Get a random question from the _questions list.
    }

    public void DisplayPrompt()
    {
        // Display the prompt to the user.
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