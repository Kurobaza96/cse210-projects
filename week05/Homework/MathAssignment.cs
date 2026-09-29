public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    // Constructor to initialize the math assignment with student name, topic, section, and problems
    public MathAssignment(
        string studentName,
        string topic,
        string section,
        string problems)
        : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    // Method to get the homework list for the math assignment
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}