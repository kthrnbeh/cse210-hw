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
    // Format: "GoalType|Name|Description|Points"
         return $"EternalGoal{_name}|{_description}|{_points}";
    }


    public override string GetDetails()
    {
        // Format: "[ ] Goal Name (Description)"
        return $"[ ] {_name} ({_description})";
    }
    public static EternalGoal FromParts(string[] parts)
    {
    // parts[0] is "EternalGoal"
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);

    // Just create the object. No completion status is needed.
        EternalGoal goal = new EternalGoal(name, description, points);
        return goal;
    }
}
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract