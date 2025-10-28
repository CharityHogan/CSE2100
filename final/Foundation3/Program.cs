using System;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        Address address1 = new Address("100 Main St", "New Yourk", "NY", "USA");

        Lecture lecture = new Lecture("C# Basics", "Learn the basics of C#", "Nov 10", "10:00 AM", address1, "Dr. Smith", 50);
        
    }
}