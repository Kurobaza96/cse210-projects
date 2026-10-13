
using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    // Constructor to initialize the activity with date and duration in minutes
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Method to get the date of the activity
    public int GetMinutes()
    {
        return _minutes;
    }


    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to get a summary of the activity
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min): " +
               $"Distance: {GetDistance():F2} km, " +
               $"Speed: {GetSpeed():F2} kph, " +
               $"Pace: {GetPace():F2} min per km";
    }
}
