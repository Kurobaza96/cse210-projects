public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor to initialize the assignment with student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get a summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Method to get the student's name
    public string GetStudentName()
    {
        return _studentName;
    }
}