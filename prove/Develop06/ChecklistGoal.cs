public class ChecklistGoal : Goal
{
    private int _requiredCompletions;
    private int _currentCompletions;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int requiredCompletions, int bonus)
        : base(name, description, points)
    {
        _requiredCompletions = requiredCompletions;
        _currentCompletions = 0;
        _bonus = bonus;
    }

    public override void RecordEvent(ref int totalPoints)
    {
        _currentCompletions++;
        if (_currentCompletions >= _requiredCompletions)
        {
            _isComplete = true;
            totalPoints += _points + _bonus;
            Console.WriteLine($"Goal completed! You earned {_points + _bonus} points!");
        }
        else
        {
            totalPoints += _points;
            Console.WriteLine($"You earned {_points} points. {_requiredCompletions - _currentCompletions} more to complete this goal.");
        }
    }

    public override string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_name} - {_description} (Completed {_currentCompletions}/{_requiredCompletions}, {_points} points per completion, {_bonus} bonus)";
    }

    public override void SaveGoal(System.IO.StreamWriter writer)
    {
        writer.WriteLine($"ChecklistGoal|{_name}|{_description}|{_points}|{_requiredCompletions}|{_currentCompletions}|{_bonus}|{_isComplete}");
    }
}
