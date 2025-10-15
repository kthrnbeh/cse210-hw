// Purpose: Complete after hitting a target count; bonus on completion.
public class ChecklistGoal : Goal
{
    // FIELDS (as in diagram)
    private int _amountCompleted; // current progress
    private int _target;          // required count to complete
    private int _bonus;           // bonus points at completion

    // CONSTRUCTOR
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        // TODO: set _target, _bonus, and initialize _amountCompleted = 0
    }

    // OVERRIDES (names exactly as diagram)
    public override int RecordEvent()
    {
        // TODO:
        //  - increment _amountCompleted
        //  - award base points
        //  - if now equals _target → include _bonus
        return 0;
    }

    public override bool IsComplete()
    {
        // TODO: return _amountCompleted >= _target
        return false;
    }

    public override string GetstringRepresent()
    {
        // TODO: return "Checklist|name|description|points|current|target|bonus"
        return "";
    }

    public override string GetDetails()
    {
        // TODO: return "[ ] Name — Completed X/Y (+points each, +bonus bonus)"
        return "";
    }
}
