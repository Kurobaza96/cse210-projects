
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        // Create a list to hold activities
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(
            new DateTime(2026, 10, 13), 30, 5.0));

        activities.Add(new Cycling(
            new DateTime(2026, 10, 13), 45, 20.0));

        activities.Add(new Swimming(
            new DateTime(2026, 10, 13), 30, 40));

        // Display summaries for each activity
        Console.WriteLine("EXERCISE TRACKING PROGRAM");
        Console.WriteLine("-------------------------");

        // Display summaries for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
