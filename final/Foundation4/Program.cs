using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("Nov 3 2022", 30, 3.0));
        activities.Add(new Cycling("Nov 4 2022", 45, 15.0));
        activities.Add(new Swimming("Nov 5 2022", 25, 20));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }

        Console.ReadLine();

    }
}

class Activity
{
    protected string date;
    protected int minutes;

    public Activity(string d, int m)
    {
        date = d;
        minutes = m;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return date + " Activity (" + minutes + " min)";

    }

}

class Running : Activity
{
    private double distance;

    public Running(string d, int m, double dist) : base(d, m)
    {
        distance = dist;
    }

    public override double GetDistance()
    {
        return distance;
    }
    public override double GetSpeed()
    {
        return (distance / minutes) * 60;
    }
    public override double GetPace()
    {
        return minutes / distance;
    }

    public override string GetSummary()
    {
        return date + " Running (" + minutes + " min) - Distance " + GetDistance() + "miles, Speed " + GetSpeed().ToString("0.0") + " mph, Pace " + GetPace().ToString("0.0") + " min/mile";
    }
}



class Cycling : Activity
{
    private double speed;

    public Cycling(string d, int m, double s) : base(d, m)
    {
        speed = s;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return (speed * minutes) / 60;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return date + " Cycling (" + minutes + " min) - Distance " + GetDistance().ToString("0.0") + " miles, Speed " + GetSpeed().ToString("0.0") + " mph, Pace " + GetPace().ToString("0.0") + " min/mile";
    }
}

class Swimming : Activity
{
    private int laps;

    public Swimming(string d, int m, int l) : base(d, m)
    {
        laps = l;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0 * 0.62; // miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / minutes) * 60;
    }

    public override double GetPace()
    {
        return minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return date + " Swimming (" + minutes + " min) - Distance " + GetDistance().ToString("0.0") + " miles, Speed " + GetSpeed().ToString("0.0") + " mph, Pace " + GetPace().ToString("0.0") + " min/mile";
    }
}


// Program 1: Abstraciton with Youtube videos  
//create a video class to store video info and a list of comments, then display each video's details and comments.

// Program 2: Encapsulation with online ordering
// Create classes for Product, Customer, Address, and Order to calculate total costs and print packing and shipping labels
//
// Program 3: Inheritance with Event Planning
// Create a base event class and derived classes for lectures, receptions, andoutdoor events, then display different event descriptions

// Program 4: Polymorphism with Exercise Tracking
// Create a base activity class adn derived classes for running, cycling, and swimming, then calculate and isplay distance, speed, pace, and a summary for each activity