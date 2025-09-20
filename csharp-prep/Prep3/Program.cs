using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a number between 1 and 100.");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }





    }
}