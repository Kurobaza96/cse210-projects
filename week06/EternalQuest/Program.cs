using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    //CREATIVITY AND EXCEEDING REQUIREMENTS
    //Level System: The player gains a new level for every 1000 points earned.
    //Level Names: Each level has a different title. Example: Level 3 Temple Guardian
    //Achievements: The player can unlock achievements based on their score.
    //Checklist Bonus: Adds bonus points for completing a checklist goal.
    //List Goals: Displays the type of goal (Simple, Eternal, Checklist) in the list of goals.

    private static List<Goal> _goals = new List<Goal>();
    private static int _score = 0;

    static void Main(string[] args)
    {
        bool running = true;

        Console.WriteLine("======================================");
        Console.WriteLine("          ETERNAL QUEST");
        Console.WriteLine("======================================");
        Console.WriteLine();
        Console.WriteLine("Welcome to your Eternal Quest!");
        Console.WriteLine();

        // Main game loop
        while (running)
        {
            DisplayStatus();
            DisplayMenu();

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    ListGoals();
                    break;

                case "3":
                    RecordEvent();
                    break;

                case "4":
                    SaveGoals();
                    break;

                case "5":
                    LoadGoals();
                    break;

                case "6":
                    running = false;
                    Console.WriteLine("Thank you for playing Eternal Quest!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1-6.");
                    break;
            }

            if (running)
            {
                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    // Displays the current score and level of the player
    static void DisplayStatus()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine($"Level: {GetLevel()} - {GetLevelName()}");
        Console.WriteLine("--------------------------------------");
    }

    // Displays the main menu options to the player
    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Menu:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Record Event");
        Console.WriteLine("  4. Save Goals");
        Console.WriteLine("  5. Load Goals");
        Console.WriteLine("  6. Quit");
        Console.WriteLine();
    }

    static int GetLevel()
    {
        return (_score / 1000) + 1;
    }

    // Returns the name of the level based on the player's current level
    static string GetLevelName()
    {
        int level = GetLevel();

        if (level >= 10)
        {
            return "Eternal Master";
        }
        else if (level >= 7)
        {
            return "Quest Champion";
        }
        else if (level >= 5)
        {
            return "Temple Guardian";
        }
        else if (level >= 3)
        {
            return "Quest Apprentice";
        }
        else
        {
            return "Quest Beginner";
        }
    }

    // Prompts the user to create a new goal and adds it to the list of goals
    static void CreateGoal()
    {
        Console.WriteLine("CREATE NEW GOAL");
        Console.WriteLine();
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine();

        Console.Write("Select goal type: ");
        string type = Console.ReadLine();

        if (type != "1" && type != "2" && type != "3")
        {
            Console.WriteLine("Invalid goal type.");
            return;
        }

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            SimpleGoal goal = new SimpleGoal(
                name,
                description,
                points);

            _goals.Add(goal);

            Console.WriteLine();
            Console.WriteLine("Simple goal created successfully!");
        }
        else if (type == "2")
        {
            EternalGoal goal = new EternalGoal(
                name,
                description,
                points);

            _goals.Add(goal);

            Console.WriteLine();
            Console.WriteLine("Eternal goal created successfully!");
        }
        else
        {
            Console.Write("How many times must this goal be completed? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points for completing the goal: ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(
                name,
                description,
                points,
                target,
                bonus);

            _goals.Add(goal);

            Console.WriteLine();
            Console.WriteLine("Checklist goal created successfully!");
        }
    }

    // Displays the list of goals to the player
    static void ListGoals()
    {
        Console.WriteLine("YOUR GOALS");
        Console.WriteLine();

        if (_goals.Count == 0)
        {
            Console.WriteLine("You do not have any goals yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    // Records an event for a selected goal and updates the score and level accordingly
    static void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You do not have any goals to record.");
            return;
        }

        Console.WriteLine("RECORD EVENT");
        Console.WriteLine();

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.WriteLine();
        Console.Write("Which goal did you accomplish? ");

        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal selectedGoal = _goals[choice - 1];

        int oldLevel = GetLevel();

        int pointsEarned = selectedGoal.RecordEvent();

        if (pointsEarned == 0)
        {
            Console.WriteLine();
            Console.WriteLine(
                "This goal has already been completed.");
            return;
        }

        _score += pointsEarned;

        Console.WriteLine();
        Console.WriteLine("**************************************");
        Console.WriteLine($"Goal recorded: {selectedGoal.GetName()}");
        Console.WriteLine($"Points earned: {pointsEarned}");
        Console.WriteLine($"Current score: {_score}");
        Console.WriteLine("**************************************");

        int newLevel = GetLevel();

        if (newLevel > oldLevel)
        {
            DisplayLevelUp(newLevel);
        }

        CheckAchievements();

        if (selectedGoal is ChecklistGoal checklistGoal)
        {
            if (checklistGoal.IsComplete())
            {
                Console.WriteLine();
                Console.WriteLine("CHECKLIST COMPLETED!");
                Console.WriteLine(
                    $"You completed the goal {checklistGoal.GetTarget()} times.");
                Console.WriteLine(
                    $"Bonus earned: {checklistGoal.GetBonus()} points.");
            }
        }
    }

    // Displays a level-up message when the player reaches a new level
    static void DisplayLevelUp(int newLevel)
    {
        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine("              LEVEL UP!");
        Console.WriteLine("======================================");
        Console.WriteLine($"You reached Level {newLevel}!");
        Console.WriteLine($"New title: {GetLevelName()}");
        Console.WriteLine("Keep going on your Eternal Quest!");
        Console.WriteLine("======================================");
    }

    // Checks for achievements based on the player's score and displays messages when achievements are unlocked
    static void CheckAchievements()
    {
        if (_score == 100)
        {
            Console.WriteLine();
            Console.WriteLine("Achievement Unlocked!");
            Console.WriteLine("FIRST 100 POINTS");
        }

        if (_score >= 1000 && _score - 1000 < 100)
        {
            Console.WriteLine();
            Console.WriteLine("Achievement Unlocked!");
            Console.WriteLine("1,000 POINT HERO");
        }

        if (_score >= 5000 && _score - 5000 < 100)
        {
            Console.WriteLine();
            Console.WriteLine("Achievement Unlocked!");
            Console.WriteLine("ETERNAL QUEST CHAMPION");
        }
    }

    // Saves the current score and goals to a file specified by the user
    static void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);

                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(
                        goal.GetStringRepresentation());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception)
        {
            Console.WriteLine("There was an error saving the file.");
        }
    }

    // Loads the score and goals from a file specified by the user
    static void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(filename);

            if (lines.Length == 0)
            {
                Console.WriteLine("The file is empty.");
                return;
            }

            _score = int.Parse(lines[0]);

            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');

                string goalType = parts[0];

                if (goalType == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal goal = new SimpleGoal(
                        name,
                        description,
                        points,
                        isComplete);

                    _goals.Add(goal);
                }
                else if (goalType == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    EternalGoal goal = new EternalGoal(
                        name,
                        description,
                        points);

                    _goals.Add(goal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);

                    ChecklistGoal goal = new ChecklistGoal(
                        name,
                        description,
                        points,
                        target,
                        bonus,
                        amountCompleted);

                    _goals.Add(goal);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Goals loaded successfully!");
            Console.WriteLine($"Current score: {_score}");
        }
        catch (Exception)
        {
            Console.WriteLine("There was an error loading the file.");
        }
    }

}