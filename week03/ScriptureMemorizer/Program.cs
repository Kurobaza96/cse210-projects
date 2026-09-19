using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity/Exceeding Requirements:
        // Add a feature to select between 4 differente scriptures.
        // User can request a hint and 1 word will appear.

        List<Scripture> scriptures = new List<Scripture>();

        // Scripture 1
        Reference reference1 = new Reference("Genesis", 1, 26, 27);        
        Scripture scripture1 = new Scripture(reference1, "And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. So God created man in his own image, in the image of God created he him; male and female created he them.");

        // Scripture 2 
        Reference reference2 = new Reference("John", 3, 16);
        Scripture scripture2 = new Scripture(reference2, "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."); // Scripture 3 Reference reference3 = new Reference("Philippians", 4, 13); Scripture scripture3 = new Scripture( reference3, "I can do all things through Christ which strengtheneth me." );

        // Scripture 3
        Reference reference3 = new Reference("Philippians", 4, 13);
        Scripture scripture3 = new Scripture(reference3, "I can do all things through Christ which strengtheneth me.");

        // Scripture 4
        Reference reference4 = new Reference("Psalm", 23, 1);
        Scripture scripture4 = new Scripture(reference4, "The Lord is my shepherd; I shall not want.");


        // Add scriptures to the library 

        scriptures.Add(scripture1);
        scriptures.Add(scripture2); 
        scriptures.Add(scripture3);
        scriptures.Add(scripture4);


        // Display the scripture library 
        Console.WriteLine(" SCRIPTURE MEMORIZER");
        Console.WriteLine(); Console.WriteLine("Choose a scripture:");

        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].GetDisplayText().Split('\n')[0]}");
        }

        Console.WriteLine();
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine(); 

        // Validate the user's choice and select the corresponding scripture        
        int selectedNumber; 
        
        if (!int.TryParse(choice, out selectedNumber) || selectedNumber < 1 || selectedNumber > scriptures.Count)
        {
            Console.WriteLine("Invalid choice."); return;
        }
        Scripture scripture = scriptures[selectedNumber - 1];
        Console.Clear();

        // Main loop to hide words until the user quits or all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words.");
            Console.WriteLine("Type 'hint' to reveal one hidden word.");
            Console.WriteLine("Type 'quit' to exit.");
            Console.WriteLine();

            Console.Write("Your choice: ");

            string input = Console.ReadLine();

            if (input != null && input.ToLower() == "quit")
            {
                return;
            }

            if (input != null && input.ToLower() == "hint")
            {
                scripture.ShowHint();
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}