public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent(ref int score)
    {
        score += _points;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}
