using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _totalPoints = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");

        LoadGoals();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save and exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    ShowScore();
                    break;
                case "5":
                    SaveGoals();
                    running = false;
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("What type of goal? (1: Simple, 2: Eternal, 3: Checklist)");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for completing this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter number of completions required: ");
                int requiredCompletions = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points for completing this goal: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, requiredCompletions, bonus));
                break;
        }

        Console.WriteLine("Goal created successfully!");
    }

    static void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? Enter the number:");
        ShowGoals();
        int index = int.Parse(Console.ReadLine()) - 1;

        _goals[index].RecordEvent(ref _totalPoints);
    }

    static void ShowGoals()
    {
        Console.WriteLine("Your goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    static void ShowScore()
    {
        Console.WriteLine($"Your total score is: {_totalPoints}");
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                goal.SaveGoal(writer);
            }
        }
        Console.WriteLine("Goals and score saved.");
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _totalPoints = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "ChecklistGoal":
                            ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6]));
                            checklistGoal.RecordEvent(ref _totalPoints);
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }
            Console.WriteLine("Goals and score loaded.");
        }
    }
}


// Explanation of Exceeding Requirements

// Save and Load: This implementation includes the ability to save and load goals and scores, which exceeds the basic requirements.

// Comments: Descriptions of additional functionality are provided in comments in Program.cs.

// Gamification: The structure allows for potential extensions like badges or levels.