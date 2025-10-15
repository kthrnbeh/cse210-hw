// Purpose: Complete after hitting a target count; bonus on completion.
using System.Runtime;

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
        _amountCompleted = 0; //int
        _target = target;
        _bonus = bonus;

    }

    // OVERRIDES (names exactly as diagram)
    public override int RecordEvent()
    {
        // TODO:
        //  - increment _amountCompleted meaning add to amountcompleted
        _amountCompleted++;
        
        //  - award base points
        //  - if now equals _target → include _bonus
        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"{_points+_bonus}");
            return _points + _bonus; // when the goal is completed give it bonus
        }
        else
        {
            Console.WriteLine($"{_points}");
            return _points; // if the goal is not yet completed just add points
        }
       
    }

    public override bool IsComplete()
    {
        // TODO: return _amountCompleted >= _target
        return _amountCompleted >= _target;
    }

    public override string GetstringRepresent()
    {
        // TODO: return "Checklist|name|description|points|current|target|bonus"
         return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";

    }

    public override string GetDetails()
    {
        // TODO: return "[ ] Name — Completed X/Y (+points each, +bonus bonus)"
        
    }
}
