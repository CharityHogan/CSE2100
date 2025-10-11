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
}