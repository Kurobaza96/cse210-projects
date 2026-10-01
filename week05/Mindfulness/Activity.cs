using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // Constructor to initialize the activity with name and description
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    // Method to get the duration of the activity
    protected int GetDuration()
    {
        return _duration;
    }

    // Method to display the starting message for the activity
    protected void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    // Method to display the ending message for the activity
    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine();

        ShowSpinner(2);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    // Method to show a spinner animation for a specified number of seconds
    protected void ShowSpinner(int seconds)
    {
        string[] symbols = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(symbols[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            index++;

            if (index >= symbols.Length)
            {
                index = 0;
            }
        }
    }

    // Method to show a spinner animation 2 for a specified number of seconds
    protected void ShowDots(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(500);

            Console.Write(".");
            Thread.Sleep(500);

            Console.Write(".");
            Thread.Sleep(500);

            Console.Write("\b\b\b   \b\b\b");
        }
    }

    // Method to show a countdown timer for a specified number of seconds
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Method to pause the program for a specified number of seconds
    protected void Pause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }
}