using System;

public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.currentCount = 0;
    }

    public override void DisplayGoal()
    {
        string status = IsCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} ({Description}) - Completed {currentCount}/{targetCount} times");
    }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            currentCount++;
            int totalPoints = Points;
            Console.WriteLine($"Progress recorded! You earned {Points} points.");
            if (currentCount >= targetCount)
            {
                isCompleted = true;
                totalPoints += bonusPoints;
                Console.WriteLine($"Checklist goal completed! Bonus {bonusPoints} points awarded!");
            }
            return totalPoints;
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
            return 0;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Description},{Points},{targetCount},{currentCount},{bonusPoints},{IsCompleted}";
    }
}
