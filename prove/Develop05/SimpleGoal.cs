using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            isCompleted = true;
            Console.WriteLine($"Goal completed! You earned {Points} points.");
            return Points;
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
            return 0;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Description},{Points},{IsCompleted}";
    }
}
