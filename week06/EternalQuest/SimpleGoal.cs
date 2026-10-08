public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor for creating a new SimpleGoal
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // Constructor for loading a SimpleGoal from a string representation
    public SimpleGoal(
        string name,
        string description,
        int points,
        bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Method to record an event for the SimpleGoal
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }

        return 0;
    }

    // Method to check if the SimpleGoal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Method to get the details string for the SimpleGoal
    public override string GetDetailsString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";

        return $"{checkbox} [Simple] {GetName()} ({GetDescription()})";
    }

    // Method to get the string representation for saving/loading the SimpleGoal
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|" +
               $"{GetPoints()}|{_isComplete}";
    }
}