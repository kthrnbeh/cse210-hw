// Purpose: One-and-done goal. 
// Represents a goal that can only be completed once and then marked as done.



public class SimpleGoal : Goal
{
    // ATTRIBUTE (private)
    protected bool _done; // true after the goal is first completed

    // CONSTRUCTOR
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        // TODO: Initialize _done = false
        // This ensures the goal starts as incomplete
        _done = false;
    }

    // OVERRIDES — implements required behaviors from base Goal class
    public override int RecordEvent()
    {
        // TODO:
        // 1. Check if _done is false (meaning not yet complete)
        // 2. If not complete:
        //      - Mark _done = true
        //      - Return _points (earned for completing this goal)
        // 3. If already complete:
        //      - Return 0 or ignore (no additional points awarded)
        // This method MUST return an integer (the number of points earned).
        // return 0; // placeholder — replace once logic is written
        if (_done == false)
        {
            _done = true;
            Console.WriteLine("[x]");
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        // TODO:
        // Return whether this goal is complete or not
        // Simply return _done (true if completed, false otherwise)
        return _done; // placeholder — replace with _done
    }

    public override string GetstringRepresent()
    {
        // TODO:
        // Return a string version of this goal suitable for saving to file.
        // Example format: "Simple|name|description|points|done"
        // Keep it simple and easy to parse later when loading goals back in.
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_done}"; // placeholder — replace when implemented
    }

    public override string GetDetails()
    {
        // TODO:
        // Return a display string for listing this goal in the console.
        // Example output:
        //    "[ ] Read Scriptures — Read daily for strength (+100 points)"
        // or "[X] Run a Marathon — Goal completed! (+1000 points)"
        // Use [ ] if not done, [X] if complete.
        if (_done == false) // ohhhh if the goal is not met it will not do the x or not be done if it is.. it will x
        {
            return $" [ ]SimpleGoal, {_name}, {_description}, {_points}";
        }
        else
        {
            return $" [X]SimpleGoal, {_name}, {_description}, {_points}";
        }
    }

    public static SimpleGoal FromParts(string[] parts)
    {
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        bool isComplete = bool.Parse(parts[4]);
        SimpleGoal goal = new SimpleGoal(name, description, points);
        goal._done = isComplete;
        return goal;
    }
}
