public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent(ref int totalPoints)
    {
        totalPoints += _points;
        Console.WriteLine($"You earned {_points} points for {_name}.");
    }

    public override string GetDetailsString()
    {
        return $"[∞] {_name} - {_description} (Ongoing, {_points} points each time)";
    }

    public override void SaveGoal(System.IO.StreamWriter writer)
    {
        writer.WriteLine($"EternalGoal|{_name}|{_description}|{_points}");
    }
}
