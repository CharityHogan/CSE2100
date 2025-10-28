using System;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        Address address1 = new Address("100 Main St", "New Yourk", "NY", "USA");

        Lecture lecture = new Lecture("C# Basics", "Learn the basics of C#", "Nov 10", "10:00 AM", address1, "Dr. Smith", 50);
        Reception reception = new RankException("Tech Meetup", "Networking for developers", "Dec 5", "6:00 PM", address1, "rsvp@techmeet.com");
        OutdoorGathering outdoor = new outDoorGathering("Picnic Day", "Fun outdoor games", "May 15", "12:00 PM", address1, "Sunny");

        Event[] events = { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.FullDetails());
            Console.WriteLine();
            Console.WriteLine(e.ShortDescription());
            Console.WriteLine("---------------------------");
        }

        Console.ReadLine();
    }
}


class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string s, string c, string st, string co)
    {
        street = s;
        city = c;
        state = st;
        country = co;
    }

    public string GetFullAddress()
    {
        return street + ", " + city + ", " + state + ", " + country;
    }
}

class Event
{
    protected string title;
    protected string description;
    protected string date;
    protected string time;
    protected Address address;

    public Event(string t, string d, string da, string ti, Address a)
    {
        title = t;
        description = d;
        date = da;
        time = ti;
        address = a;
    }

    public string StandardDetails()
    {
        return "Title: " + title + "\nDescription: " + description + "\nDate: " + date + "\nTime: " + time + "\nAddress: " + address.GetFullAddress();
    }

    public virtual string FullDetails()
    {
        return StandardDetails();
    }

    public virtual string ShortDescription()
    {
        return "Event: " + title + " on " + date;
    }
}

class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string t, string d, string da, string ti, Address a, string s, int c)
        : base(t, d, da, ti, a)
    {
        speaker = s;
        capacity = c;
    }

    public override string FullDetails()
    {
        return StandardDetails() + "\nType: Lecture\nSpeaker: " + speaker + "\nCapacity: " + capacity;
    }

    public override string ShortDescription()
    {
        return "Lecture: " + title + " on " + date;
    }
}

class Reception : Event
{
    private string email;

    public Reception(string t, string d, string da, string ti, Address a, string e)
        : base(t, d, da, ti, a)
    {
        email = e;
    }

    public override string FullDetails()
    {
        return StandardDetails() + "\nType: Reception\nRSVP Email: " + email;
    }

    public override string ShortDescription()
    {
        return "Reception: " + title + " on " + date;
    }
}

class OutdoorGathering : Event
{
    private string weather;

    public OutdoorGathering(string t, string d, string da, string ti, Address a, string w)
        : base(t, d, da, ti, a)
    {
        weather = w;
    }

    public override string FullDetails()
    {
        return StandardDetails() + "\nType: Outdoor Gathering\nWeather: " + weather;
    }

    public override string ShortDescription()
    {
        return "Outdoor Gathering: " + title + " on " + date;
    }
}