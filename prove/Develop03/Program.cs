using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        new Scripture(new Reference("Proverbs", 3, 5, 6),
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
        
        new Scripture(new ReferenceEqualityComparer("John, 3, 16),
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlating life."),

        new Scripture(new ReferenceEqualityComparer("Philippians", 4, 13),
        "I can do all things through Christ which strengtheneth me.")))
    };

    Random random = new Random();
    Scripture scripture = scriptures[Random.Next(scriptures.Count)];

    while (true)
    {
        SafeClear();
    Console.writeLine(scripture.GetDisplayText());
        console.writeLine("\nPress enter to hide more words or type 'quit' to end:");
        string input = Console.ReadLine();
    }
}