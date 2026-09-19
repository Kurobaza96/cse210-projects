using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity/Exceeding Requirements:
        // 

        Reference reference = new Reference("Genesis", 1, 26, 27);

        string text = "And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. So God created man in his own image, in the image of God created he him; male and female created he them.";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide more words or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if (input != null && input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}