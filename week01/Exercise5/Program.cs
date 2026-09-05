using System;

class Program
{
    static void Main(string[] args)
    {
        // Display the welcome message and prompt the user
        DisplayWelcome();

        string name = PromptUserName();

        
        int number = PromptUserNumber();

        // Calculate the square of the number
        int squaredNumber = SquareNumber(number);

        // Display the result
        DisplayResult(name, squaredNumber);
    }

    // Function that displays the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function that asks for and returns the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function that asks for the favorite number and returns it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function that accepts an integer and returns its square
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function that displays the user's name and squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}