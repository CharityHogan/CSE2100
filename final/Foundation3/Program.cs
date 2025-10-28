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
