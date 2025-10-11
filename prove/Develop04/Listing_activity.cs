class ListingActivity : Activity
{
    public void DoActivity()
    {
        Start();
        string[] prompts =
        {
            "List people who you appreciate.",
            "List personal strengths you have.",
            "List things you are grateful for.",
            "List your favorite hobbies.",
            "List places you want to visit."
        };

        Random rnd = new Random();
        Console.WriteLine(prompts[rnd.Next(prompts.Length)]);
        Pause(3);

        int elapsed = 0;
        int count = 0;

        while (elapsed < Duration)
        {
            Console.Write("Enter item: ");
            string input = Console.ReadLine();
            count++;
            elapsed += 2;
        }

        Console.WriteLine("You listed " + count + " items!");
        End();
    }
}