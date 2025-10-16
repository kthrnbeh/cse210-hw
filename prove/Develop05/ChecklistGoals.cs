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
        _amountCompleted = 0; // int
        _target = target;
        _bonus = bonus;
    }

    // OVERRIDES (names exactly as diagram)
    public override int RecordEvent()
    {
        // TODO:
        //  - increment _amountCompleted meaning add to amountcompleted
        if (IsComplete)
        {
            return 0; //
        }

            _amountCompleted++;
        

        //  - award base points
        //  - if now equals _target → include _bonus
        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"{_points + _bonus}");
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
        // Must match the order: current|target|bonus
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override string GetDetails()
    {
        // TODO: return "[ ] Name — Completed X/Y (+points each, +bonus bonus)"
        if (_amountCompleted >= _target)
        {
            return $"[X]ChecklistGoal {_name}|{_description} ({_amountCompleted}/{_target}) (+{_points} +{_bonus} bonus)";
        }
        else
        {
            return $"[]CheckListGoal {_name} — {_description} ({_amountCompleted}/{_target}) (+{_points})";
        }
    }

    // CORRECTED FromParts METHOD
    public static ChecklistGoal FromParts(string[] parts)
    {
        // parts[0] is "ChecklistGoal"
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        int amountCompleted = int.Parse(parts[4]);
        int target = int.Parse(parts[5]);
        int bonus = int.Parse(parts[6]);

        // 1. Create the goal with its main parameters
        ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);

        // 2. Set the current progress from the file
        goal._amountCompleted = amountCompleted;

        // 3. Return the fully loaded goal
        return goal;
    }
}
