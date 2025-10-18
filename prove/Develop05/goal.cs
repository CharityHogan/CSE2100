using System;

public abstract class Goal
{
    private string name;
    private string description;
    private int points;
    protected bool isCompleted;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
        this.isCompleted = false;
    }

    public string Name => name;
    public string Description => description;
    public int Points => points;
    public bool IsCompleted => isCompleted;

    public virtual void DisplayGoal()
    {
        string status = isCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {name} ({description})");
    }

    public abstract int RecordEvent();

    public abstract string GetStringRepresentation();
}
