
using System;

public class Swimming : Activity
{
    private int _laps;

    // Constructor to initialize the swimming activity with date, duration in minutes, and number of laps
    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    // Method to get the distance covered during the swimming activity
    public override double GetDistance()
    {
        return (_laps * 50.0) / 1000;
    }

    // Method to get the speed of the swimming activity
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    // Method to get the pace of the swimming activity
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
