public class SimpleGoal : Goal
{
    private bool _isCompleteFlag;

    public bool IsCompleteFlag 
    { 
        get => _isCompleteFlag; 
        set => _isCompleteFlag = value; 
    }

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isCompleteFlag = false;
    }

    public override int RecordEvent()
    {
        _isCompleteFlag = true;
        return Points;
    }

    public override bool IsComplete()
    {
        return _isCompleteFlag;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - {(_isCompleteFlag ? "Completed" : "Not Completed")}";
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_isCompleteFlag}";
    }
}
