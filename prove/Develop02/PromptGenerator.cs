class PromptGenerator
{
    public List<string> Prompts = new List<string>()
    {
        // TODO: add at least 5 prompts
        // "Who was the most interesting person I interacted with today?",
        // "What was the best part of my day?",
        // "How did I see the hand of the Lord in my life today?",
        // "What was the strongest emotion I felt today?",
        // "If I had one thing I could do over today, what would it be?"
    };

    private static readonly Random rng = new Random();

    public string GetRandomPrompt()
    {
        // TODO: int i = rng.Next(0, Prompts.Count); return Prompts[i];
        return "";
    }

    // (Optional) load prompts from prompt.txt
    public void TryLoadFromFile(string path)
    {
        // TODO: if (File.Exists(path)) Prompts = new List<string>(File.ReadAllLines(path));
        // else keep defaults
    }
}