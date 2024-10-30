class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine("Now breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(4);
            
        }

        DisplayEndingMessage();
    }
}