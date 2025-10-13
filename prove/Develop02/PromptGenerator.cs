class PromptGenerator
{
    public List<string> Prompts = new List<string>()
    {
        // TODO: add at least 5 prompts
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "If you could talk to one person who would it be?",
        "What is your favorite sent and why?",
        "What would you do with unlimited money?",
        "What's your favorite simple thing that brings you joy and why?" 
    };

    private static readonly Random rng = new Random();

    public string GetRandomPrompt()
    {
        // TODO: int i = rng.Next(0, Prompts.Count); return Prompts[i];
        //get a random index value and look up the string prompts 
        int i = rng.Next(0, Prompts.Count);
        return Prompts[i];
    }

    
}