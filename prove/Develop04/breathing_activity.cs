class BreathingActivity : Activity
{
    public void DoActivity()
    {
        Start();
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...:");
            Thread.Sleep(4000);
            elapsed += 4;

            Console.WriteLine("Breathe out...:");
            Thread.Sleep(6000);
            elapsed += 6;
        
        }
        End();
    }
}