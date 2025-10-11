using System;
using System.Threading;

class Activity
{
    public string Name;
    public string Description;
    public int Duration;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Starting " + Name + " Activity!");
        Console.WriteLine(Description);
        Console.WriteLine("Duration: " + Duration + " seconds");
        Console.Write("Get ready...");
        Pause(3);
    }

    public void End()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine("You have completed the " + Name + " Activity for " + Duration + " seconds.");
        Pause(3);
    }

    public void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}