using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public abstract void RecordEvent(ref int totalPoints);

    public virtual string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_name} - {_description} ({_points} points)";
    }

    public bool IsComplete => _isComplete;
    public string Name => _name;
    public int Points => _points;

    public abstract void SaveGoal(System.IO.StreamWriter writer);
}
