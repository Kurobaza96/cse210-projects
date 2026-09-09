public class Job
{
    // Member variables
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    // Displays the job information
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}