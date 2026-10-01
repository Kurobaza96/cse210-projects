using System;

public class BreathingActivity : Activity
{

    // Constructor to initialize the breathing activity with name and description
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        )
    {
    }

    // Method to run the breathing activity
    public void Run()
    {
        DisplayStartingMessage();

        int elapsedTime = 0;

        while (elapsedTime < GetDuration())
        {
            int remainingTime = GetDuration() - elapsedTime;

            Console.WriteLine();
            Console.Write("Breathe in... ");

            int breatheTime = Math.Min(4, remainingTime);
            ShowCountdown(breatheTime);

            elapsedTime += breatheTime;

            if (elapsedTime >= GetDuration())
            {
                break;
            }

            remainingTime = GetDuration() - elapsedTime;

            Console.WriteLine();
            Console.Write("Breathe out... ");

            breatheTime = Math.Min(4, remainingTime);
            ShowCountdown(breatheTime);

            elapsedTime += breatheTime;
        }

        DisplayEndingMessage();
    }
}