using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        // Generate a random number between 1 and 100
        int magicNumber = random.Next(1, 101);

        // First prompt the user to guess
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        // Loop until the user guesses the magic number
        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

            // Continue prompting the user for another guess until they get it right
            Console.Write("Take another guess? ");
            guess = int.Parse(Console.ReadLine());
        }

        // If the user guesses the magic number, print a congratulatory message
        Console.WriteLine("Yes, the number is " + magicNumber + "! You guessed it!");
    }
}