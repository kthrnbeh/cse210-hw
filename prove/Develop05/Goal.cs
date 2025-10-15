// Purpose: Shared attributes/behavior for all goal types.

public abstract class Goal
{
    // FIELDS (private)
    private string _shortName;   // goal title
    private string _description; // goal description
    private int _points;         // base points

    // CONSTRUCTOR
    public Goal(string name, string description, int points)
    {
        // TODO: set common fields
    }

    // POLYMORPHIC API (exact names per diagram)

    public abstract void RecordEvent();
    // TODO: implement in derived types to apply progress/points

    public abstract bool IsComplete();
    // TODO: return completion status (varies by type)

    public abstract string GetDetails();
    // TODO: return a user-friendly line with checkbox/progress/etc.

    public abstract string GetstringRepresent();
    // TODO: return a compact, savable one-line representation (type + fields)
    // NOTE: name kept exactly as in your diagram ("GetstringRepresent")
}
