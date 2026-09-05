using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter their grade percentage
        Console.WriteLine("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letter;

        // Stores the letter grade in the variable letter based on the grade percentage
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print the letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

        //Print if the student passed or failed
        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you failed the course. Better luck next time!");
        }   
    }
}