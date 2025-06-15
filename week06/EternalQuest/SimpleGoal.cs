public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent(ref int score)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            score += _points;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
    {
        string status = _isComplete ? "X" : " ";
        return $"[{status}] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}
