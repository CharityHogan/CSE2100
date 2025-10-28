using System;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        address address1 = new Address("100 Main St", "New Yourk", "NY", "USA");

        lecture lecture = new Lecture("C# Basics", "Learn the basics of C#", "Nov 10", "10:00 AM", address1, "Dr. Smith", 50);
        reception reception = new RankException("Tech Meetup", "Networking for developers", "Dec 5", "6:00 PM", address1, "rsvp@techmeet.com");
        outDoorGathering outdoor = new outDoorGathering("Picnic Day", "Fun outdoor games", "May 15", "12:00 PM", address1, "Sunny");
        
    }
}