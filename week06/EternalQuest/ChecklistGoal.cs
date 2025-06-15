public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _target;
    private int _amountCompleted;

    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted = 0)
        : base(name, description, points)
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent(ref int score)
    {
        _amountCompleted++;
        score += _points;

        if (_amountCompleted == _target)
        {
            score += _bonus;
            Console.WriteLine($"Congratulations! You have earned {_points} points and a bonus of {_bonus} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "X" : " ";
        return $"[{status}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}
