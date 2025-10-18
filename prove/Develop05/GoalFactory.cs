using System;

public static class GoalFactory
{
    public static Goal CreateGoal(string data, string type)
    {
        string[] parts = data.Split(',');
        if (type == "SimpleGoal")
        {
            string name = parts[0];
            string desc = parts[1];
            int points = int.Parse(parts[2]);
            bool completed = bool.Parse(parts[3]);
            var g = new SimpleGoal(name, desc, points);
            if (completed) g.RecordEvent();  // mark as completed
            return g;
        }
        else if (type == "EternalGoal")
        {
            string name = parts[0];
            string desc = parts[1];
            int points = int.Parse(parts[2]);
            return new EternalGoal(name, desc, points);
        }
        else if (type == "ChecklistGoal")
        {
            string name = parts[0];
            string desc = parts[1];
            int points = int.Parse(parts[2]);
            int target = int.Parse(parts[3]);
            int current = int.Parse(parts[4]);
            int bonus = int.Parse(parts[5]);
            bool completed = bool.Parse(parts[6]);

            var g = new ChecklistGoal(name, desc, points, target, bonus);
            for (int i = 0; i < current; i++) g.RecordEvent();  // restore progress
            return g;
        }
        return null;
    }
}
