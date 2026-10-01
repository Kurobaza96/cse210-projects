using System;
using System.Threading;

class Program
{

    // Creativity and exceeding requirements:
    // I added a simple item counter to the Listing Activity so the user
    // can see how many positive things they were able to list during
    // the activity. I also created 2 spinners for Reflection Activity 
    // and countdown animations. 
    // Additionally, I added a prompt to repeat the activity 
    // or return to the main menu after each activity is completed.

    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                bool repeat = true;

                while (repeat)
                {
                    BreathingActivity activity = new BreathingActivity();
                    activity.Run();

                    repeat = AskToRepeat();
                }
            }
            else if (choice == 2)
            {
                bool repeat = true;

                while (repeat)
                {
                    ReflectionActivity activity = new ReflectionActivity();
                    activity.Run();

                    repeat = AskToRepeat();
                }
            }
            else if (choice == 3)
            {
                bool repeat = true;

                while (repeat)
                {
                    ListingActivity activity = new ListingActivity();
                    activity.Run();

                    repeat = AskToRepeat();
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Mindfulness Program!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid choice. Please select 1-4.");
                Thread.Sleep(2000);
            }
        }
    }

    // Method to ask the user if they want to repeat the activity or return to the main menu
    static bool AskToRepeat()
    {
        Console.WriteLine();
        Console.WriteLine("What would you like to do next?");
        Console.WriteLine("1. Repeat this activity");
        Console.WriteLine("2. Return to the main menu");
        Console.Write("Select an option: ");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}