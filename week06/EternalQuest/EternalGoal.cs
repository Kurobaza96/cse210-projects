public class EternalGoal : Goal
{

    // Constructor for creating a new EternalGoal
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // Constructor for loading an EternalGoal from a string representation
    public override int RecordEvent()
    {
        return GetPoints();
    }

    // Method to check if the EternalGoal is complete
    public override bool IsComplete()
    {
        return false;
    }

    // Method to get the details string for the EternalGoal
    public override string GetDetailsString()
    {
        return $"[ ] [Eternal] {GetName()} ({GetDescription()})";
    }

    // Method to get the string representation for saving/loading the EternalGoal
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}