
using System;

public class Cycling : Activity
{
    private double _speed;

    // Constructor to initialize the cycling activity with date, duration in minutes, and speed in kph
    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    // Method to get the distance covered during the cycling activity
    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    // Method to get the speed of the cycling activity
    public override double GetSpeed()
    {
        return _speed;
    }

    // Method to get the pace of the cycling activity
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}
