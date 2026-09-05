using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int magicNumber = random.Next(1, 101);

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

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

            Console.Write("Take another guess? ");
            guess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Yes, the number is " + magicNumber + "! You guessed it!");
    }
}