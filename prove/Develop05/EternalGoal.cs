// Purpose: Never completes; awards points every time.
public class EternalGoal : Goal
{
    // CONSTRUCTOR
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // TODO: any eternal-specific init if needed

    }

    // OVERRIDES (names exactly as diagram)
    public override int RecordEvent()
    {
        // TODO: award base points each time; never completes
        Console.WriteLine($"{_points}");
        return _points; //the amount of points each time
    }

    public override bool IsComplete()
    {
        // TODO: always false
        return false;
    }

    public override string GetstringRepresent()
    {
        // TODO: return "Eternal|name|description|points"
       return $"[x]Eternal Goal|{_name}|{_description}|{_points}";
    }

    public override string GetDetails()
    {
        // TODO: return "[ ] Name — Description (+points
        return $"[]Eternal Goal|{_name}|{_description}|{_points}";
            
    }
}
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract