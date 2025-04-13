using System;

public abstract class Goal
{
    private string _name; // Encapsulation: private member
    private string _description; // Encapsulation: private member
    private int _points; // Encapsulation: private member

    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string Name => _name; // Public accessor
    public string Description => _description; // Public accessor
    public int Points => _points; // Public accessor

    public abstract int RecordEvent();

    public virtual bool IsComplete() => false;

    public virtual string GetDetailsString()
    {
        return $"{_name}: {_description}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name},{_name},{_description},{_points}";
    }

    public static Goal CreateGoal(string data)
    {
        string[] parts = data.Split(',');
        string goalType = parts[0];

        if (goalType == "SimpleGoal")
        {
            bool isComplete = bool.Parse(parts[4]);
            return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { IsCompleteFlag = isComplete };
        }
        else if (goalType == "EternalGoal")
        {
            return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
        }
        else if (goalType == "ChecklistGoal")
        {
            int currentCount = int.Parse(parts[4]);
            int targetCount = int.Parse(parts[5]);
            int bonusPoints = int.Parse(parts[6]);
            return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), targetCount, bonusPoints) { CurrentCount = currentCount };
        }
        throw new Exception("Unknown goal type.");
    }
}
