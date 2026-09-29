public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor to initialize the writing assignment with student name, topic, and title
    public WritingAssignment(
        string studentName,
        string topic,
        string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to get the writing information for the writing assignment
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}