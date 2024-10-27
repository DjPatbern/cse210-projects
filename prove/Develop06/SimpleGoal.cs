public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent(ref int totalPoints)
    {
        _isComplete = true;
        totalPoints += _points;
        Console.WriteLine($"Goal completed! You earned {_points} points.");
    }

    public override void SaveGoal(System.IO.StreamWriter writer)
    {
        writer.WriteLine($"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}");
    }
}
