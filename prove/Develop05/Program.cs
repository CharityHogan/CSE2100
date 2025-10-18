using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;

    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();

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
                    Console.WriteLine($"Total Points: {totalPoints}");
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type: 1. Simple 2. Eternal 3. Checklist");
        string type = Console.ReadLine();

        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter goal description:");
        string desc = Console.ReadLine();
        Console.WriteLine("Enter points for this goal:");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (type == "1")
            newGoal = new SimpleGoal(name, desc, points);
        else if (type == "2")
            newGoal = new EternalGoal(name, desc, points);
        else if (type == "3")
        {
            Console.WriteLine("Enter how many times this goal must be completed:");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bonus points for completing this goal:");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(name, desc, points, target, bonus);
        }

        if (newGoal != null)
            goals.Add(newGoal);
    }

    static void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("Select a goal to record progress (enter number):");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayGoal();
        }

        int choice = int.Parse(Console.ReadLine());
        if (choice > 0 && choice <= goals.Count)
        {
            totalPoints += goals[choice - 1].RecordEvent();
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(totalPoints);
            foreach (var goal in goals)
            {
                sw.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines("goals.txt");
            totalPoints = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(':');
                string type = parts[0];
                string data = parts[1];

                Goal loadedGoal = GoalFactory.CreateGoal(data, type);
                if (loadedGoal != null)
                    goals.Add(loadedGoal);
            }

            Console.WriteLine("Goals loaded!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
