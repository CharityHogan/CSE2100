class ReflectionActivity : Activity
{
    public void DoActivity()
    {
        Start();
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
            
        };

        string[] questions =
        {
            "Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"
        };

        Random rnd = new Random();
        int elapsed = 0;

        Console.WriteLine(prompts[rnd.Next(prompts.Length)]);
        Pause(3);

        while (elapsed < Duration)
        {
            Console.WriteLine(questions[rnd.Next(questions.Length)]);
            Thread.Sleep(5_000);
            elapsed += 5;
        }

        End();
    }
}
