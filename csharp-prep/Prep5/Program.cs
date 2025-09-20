using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        int birthYear;
        promtUserBirthYear(out birthYear);

        DisplayAttribute(userName, squaredNumber, birthYear);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        return number;
    }
    static void promtUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your birth year: ");
        string yearString = Console.ReadLine();
        birthYear = int.Parse(yearString);
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayAttribute(string name, int squaredNumber, int birthYear)
    {
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine($"Your favorite number squared is: {squaredNumber}");
        Console.WriteLine($"You were born in the year {birthYear}. You will turn {2025 - birthYear} years old this year!");
    }
}