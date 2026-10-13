
using System;

public class Running : Activity
{
    private double _distance;

    // Constructor to initialize the running activity with date, duration in minutes, and distance in kilometers
    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    // Method to get the distance covered during the running activity
    public override double GetDistance()
    {
        return _distance;
    }

    // Method to get the speed of the running activity    
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    // Method to get the pace of the running activity
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
