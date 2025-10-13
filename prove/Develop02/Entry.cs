public class Entry
{
    public string _dateText;
    public string _prompt;
    public string _response;

    public void Display()
    {
        // TODO: print date, prompt, response nicely
        Console.WriteLine($"{_dateText} :{_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine();
    }
}
